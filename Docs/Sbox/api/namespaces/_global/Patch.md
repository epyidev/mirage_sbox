# Sandbox.Json.Patch

Represents a complete set of changes to be applied to a JSON structure.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Json`

## Constructors

- `Patch()`

## Properties

- `System.Collections.Generic.List<Sandbox.Json.AddedObject> AddedObjects`
  - Objects that need to be added to the target structure.
- `System.Collections.Generic.List<Sandbox.Json.RemovedObject> RemovedObjects`
  - Objects that need to be removed from the target structure.
- `System.Collections.Generic.List<Sandbox.Json.PropertyOverride> PropertyOverrides`
  - Property values that need to be changed on existing objects.
- `System.Collections.Generic.List<Sandbox.Json.MovedObject> MovedObjects`
  - Objects that need to be moved to a different location in the structure.
