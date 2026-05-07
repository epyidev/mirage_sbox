# Sandbox.NetPermission

Specifies who can invoke an action over the network.

- **Kind:** enum
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Enum`

## Values

- `Anyone` - Anyone can invoke this.
- `HostOnly` - Only the host can invoke this.
- `OwnerOnly` - Only the owner can invoke this. If the action is static, this works the same way as `Sandbox.NetPermission.HostOnly`.
