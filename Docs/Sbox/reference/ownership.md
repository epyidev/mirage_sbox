# Ownership

Source: `../guides/networking/ownership.md`. API: `../api/namespaces/sandbox/GameObject.md`, `../api/namespaces/_global/OwnerTransfer.md`.

## Concept

A networked GameObject is **simulated** by exactly one connection at a time:

- If a connection owns the object, that connection runs its logic and pushes its position and synced variables.
- If the object has no owner, the host simulates it.

Every Component naturally inherits the GameObject's ownership state, so the most common code pattern is "skip the body if I am not the simulator":

```csharp
public override void Update()
{
    if ( IsProxy ) return; // someone else is simulating this object

    if ( Input.Pressed( "use" ) )
    {
        TryPickup();
    }
}
```

`IsProxy` is true when the GameObject is being simulated by another client (or the server, from a client's perspective). `Network.OwnerId` returns the owner connection id when you actually need it.

## Owner-transfer policy

Set on a per-object basis:

| Value | Behaviour |
|-------|-----------|
| `OwnerTransfer.Fixed` *(default)* | Only the host can change the owner. |
| `OwnerTransfer.Takeover` | Anyone can change the owner. |
| `OwnerTransfer.Request` | A request must be made to the host to change the owner. |

```csharp
go.Network.SetOwnerTransfer( OwnerTransfer.Takeover );
```

## Taking ownership

```csharp
void TryPickup()
{
    var tr = Physics.Trace.WithoutTags( "player" )
        .Sphere( 16, EyePos, EyePos + LookDir.Forward * 100 )
        .Run();

    if ( !tr.Hit ) return;
    if ( tr.Body.GameObject is not GameObject go ) return;
    if ( !go.Tags.Has( "pickup" ) ) return;

    go.Network.TakeOwnership();
    Carrying = go;
}
```

After this call the calling connection becomes the simulator for that GameObject.

## Dropping ownership

`Network.DropOwnership()` (signature in `../api/namespaces/sandbox/GameObject.md`) hands the object back to the host. After dropping, the host simulates it.

## Why this matters

In a host-authoritative project (us), the right model is usually:

- Host simulates almost everything, mutates the real state.
- Players take ownership of the things they directly drive (their own player GameObject, a vehicle they get into).
- All sensitive mutations (money, inventory) live behind a host-side service that does its own permission check on `Rpc.Caller`, never trusting "owner" alone.

See `rpc-messages.md` for the call routing and `../../../CLAUDE.md` Security and authority checks for the project rule.
