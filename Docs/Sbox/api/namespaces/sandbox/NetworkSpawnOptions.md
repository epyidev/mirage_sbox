# Sandbox.NetworkSpawnOptions

Configurable options when spawning a networked object.

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `NetworkSpawnOptions()`
  - Configurable options when spawning a networked object.

## Properties

- `System.Nullable<Sandbox.NetworkOrphaned> OrphanedMode`
- `System.Nullable<Sandbox.OwnerTransfer> OwnerTransfer`
- `System.Nullable<Sandbox.NetworkFlags> Flags`
- `System.Nullable<System.Boolean> AlwaysTransmit`
- `System.Boolean StartEnabled`
  - Should this networked object start enabled?
- `Sandbox.Connection Owner`
  - Who should be the owner of this networked object?

## Fields

- `static Sandbox.NetworkSpawnOptions Default`
  - The default network spawn options.
