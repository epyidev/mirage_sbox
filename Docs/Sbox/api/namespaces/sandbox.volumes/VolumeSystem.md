# Sandbox.Volumes.VolumeSystem

A base GameObjectSystem for handling of IVolume components. You can use this to find volume components
by position.

- **Kind:** sealed class
- **Namespace:** `Sandbox.Volumes`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.GameObjectSystem<T>`

## Constructors

- `VolumeSystem(Sandbox.Scene scene)`

## Methods

### Instance methods

- `T FindSingle(Vector3 position)`
  - Find a volume of this type, at this point. Will return null if none.
- `System.Collections.Generic.IEnumerable<T> FindAll(Vector3 position)`
  - Find all volumes of this type, at this point
