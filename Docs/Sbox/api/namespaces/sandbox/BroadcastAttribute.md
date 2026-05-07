# Sandbox.BroadcastAttribute

Marks a method as being an RPC that when invoked will be called for all connected clients including the host.
The state of the object the RPC is called on will be up-to-date including its `Sandbox.GameTransform` and any
properties with the `Sandbox.SyncAttribute` or `Sandbox.HostSyncAttribute` attributes by the time the method
is called on remote clients. The only except is any synchronized properties marked with `Sandbox.SyncAttribute.Query` which
will generally only be received every network tick.

- **Kind:** attribute
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.RpcAttribute`

## Constructors

- `BroadcastAttribute()`
- `BroadcastAttribute(Sandbox.NetPermission permission)`

## Properties

- `Sandbox.NetPermission Permission`
