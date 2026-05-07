# RPC messages

Source: `../guides/networking/rpc-messages.md`. Related: `ownership.md`, `../guides/networking/sync-properties.md`.

## What an RPC is

A method on a Component (or a static method anywhere) marked with `[Rpc.*]`. When called, the runtime invokes the method on the configured remote endpoints. Argument types must match what `Sync` properties accept.

## Routing attributes

| Attribute | Effect |
|-----------|--------|
| `[Rpc.Broadcast]` | Broadcasts a network message; the function runs on everyone. |
| `[Rpc.Owner]` | Runs only on the connection that owns the networked object (or on the host if the object has no owner). |
| `[Rpc.Host]` | Runs only on the host. |

Static methods can be RPCs too, they do not need a Component.

Example from the guide:

```csharp
void OnPressed()
{
    PlayOpenEffects();
}

[Rpc.Broadcast]
public void PlayOpenEffects()
{
    Sound.Play( "bing", WorldPosition );
}
```

## NetFlags

Pass them in the attribute constructor, combinable with `|`.

| Flag | Effect |
|------|--------|
| `NetFlags.Reliable` | Default. Retried until delivered. Higher cost. |
| `NetFlags.Unreliable` | May drop or arrive out of order. Cheap and fast. Good for position updates and effects. |
| `NetFlags.SendImmediate` | Skip batching, send straight away. Useful for streaming-style data (voice). |
| `NetFlags.DiscardOnDelay` | Drop if it cannot be sent quickly. Only meaningful on unreliable messages. |
| `NetFlags.HostOnly` | RPC can only be called from the host. |
| `NetFlags.OwnerOnly` | RPC can only be called from the owner of the object it is on. |

```csharp
[Rpc.Broadcast( NetFlags.Unreliable | NetFlags.OwnerOnly )]
public static void PlaySoundAllClients( string soundName, Vector3 position )
{
    // ...
}
```

## Caller info

Inside an RPC body, `Rpc.Caller` exposes the connection that initiated the call. Always validate it before mutating anything:

```csharp
[Rpc.Host]
public void DoSomething()
{
    if ( Rpc.Caller != Network.Owner ) return;
    // safe to act
}
```

## Filtering broadcasts

Wrap the call in `Rpc.FilterExclude` or `Rpc.FilterInclude` to limit which connections actually receive the broadcast:

```csharp
using ( Rpc.FilterExclude( c => c.DisplayName == "Harry" ) )
{
    PlayOpenEffects( "bing", WorldPosition );
}

using ( Rpc.FilterInclude( c => c.DisplayName == "Garry" ) )
{
    PlayOpenEffects( "bing", WorldPosition );
}
```

## Argument constraints

Per the guide: "Supported RPC arguments are the exact same as Sync properties." For exact rules see `../guides/networking/sync-properties.md`.

## CLAUDE.md project rule

Any `[Rpc.Host]` that mutates a GameObject must verify the caller can act on it (see `../../../CLAUDE.md` Security and authority checks). Typical pattern: `go.HasAccess( Rpc.Caller )` or `Rpc.Caller != Network.Owner`.
