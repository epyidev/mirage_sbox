# Sandbox.SyncFlags

Describes the behaviour of network synchronization.

- **Kind:** enum
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Enum`

## Values

- `FromHost` - The host has ownership over the value.
- `Query` - Query this value for changes rather than counting on set being called. This is appropriate
if the value returned by its getter can change without calling its setter.
- `Interpolate` - The value will be interpolated between ticks. This is currently only supported for `System.Single`, `System.Double`, `Angles`,
`Rotation`, `Transform`, `Vector3`.
