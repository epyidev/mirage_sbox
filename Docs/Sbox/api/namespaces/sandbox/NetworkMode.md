# Sandbox.NetworkMode

Specifies how a `Sandbox.GameObject` should be networked.

- **Kind:** enum
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Enum`

## Values

- `Never` - Never network this `Sandbox.GameObject`.
- `Object` - Network this `Sandbox.GameObject` as a single network object. Objects networked in this
way can have an owner, and synchronized properties with `Sandbox.SyncAttribute`.
- `Snapshot` - Network this `Sandbox.GameObject` to other clients as part of the `Sandbox.Scene` snapshot.
