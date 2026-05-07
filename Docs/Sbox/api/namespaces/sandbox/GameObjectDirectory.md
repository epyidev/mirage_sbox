# Sandbox.GameObjectDirectory

New GameObjects and Components are registered with this class when they're created, and 
unregistered when they're removed. This gives us a single place to enforce
Id uniqueness in the scene, and allows for fast lookups by Id.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Int32 Count`
- `System.Int32 GameObjectCount`
- `System.Int32 ComponentCount`

## Methods

### Instance methods

- `Sandbox.Component FindComponentByGuid(System.Guid guid)`
  - Find a Component in the scene by Guid. This should be really really fast.
- `Sandbox.GameObject FindByGuid(System.Guid guid)`
  - Find a GameObject in the scene by Guid. This should be really really fast.
- `System.Collections.Generic.IEnumerable<Sandbox.GameObject> FindByName(System.String name, System.Boolean caseinsensitive)`
  - Find objects with this name. Not performant.
