# Sandbox.Mounting.PrefabBuilder

A scoped builder for creating prefabs within a Mount.
Typically used inside a `Sandbox.Mounting.ResourceLoader.Load` implementation.

- **Kind:** sealed class
- **Namespace:** `Sandbox.Mounting`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `PrefabBuilder()`

## Methods

### Static methods

- `static System.Void Destroy(Sandbox.PrefabFile prefab)`
  - Unregister and destroy a `Sandbox.PrefabFile` created by `Sandbox.Mounting.PrefabBuilder.Create`.
Call from `Sandbox.Mounting.ResourceLoader.Shutdown` when a mount is disabled.

### Instance methods

- `Sandbox.Mounting.PrefabBuilder WithName(System.String name)`
  - Set the name/resource path of the resulting prefab.
The root `Sandbox.GameObject` name is derived from the filename portion if left unchanged.
- `Sandbox.Mounting.PrefabBuildScope Scope()`
  - Enter a temporary scene scope. GameObjects created inside will become part of this prefab.
- `Sandbox.PrefabFile Create()`
  - Serialize the scene content into a registered `Sandbox.PrefabFile`.
Call after you've created any objects and the `Sandbox.Mounting.PrefabBuilder.Scope` has been disposed.
