# Sandbox.Component.INetworkSnapshot

When implemented on a `Sandbox.Component` or `Sandbox.GameObjectSystem` it can read and write
data to and from a network snapshot.

- **Kind:** interface
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Component`

## Methods

### Instance methods

- `virtual System.Void ReadSnapshot(Sandbox.ByteStream reader)`
  - Read data from the snapshot.
- `virtual System.Void WriteSnapshot(Sandbox.ByteStream writer)`
  - Write data to the snapshot.
