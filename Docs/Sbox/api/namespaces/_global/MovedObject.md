# Sandbox.Json.MovedObject

Represents an object that should be moved to a new location during patching.

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Json`

## Fields

- `Sandbox.Json.ObjectIdentifier Id`
  - The identifier of the object to move
- `Sandbox.Json.ObjectIdentifier NewParent`
  - The new parent object
- `System.String NewContainerProperty`
  - The property name in the new parent that will contain this object
- `System.Boolean IsNewContainerArray`
  - Whether the object is being moved to an array (true) or as a direct property (false)
- `System.Nullable<Sandbox.Json.ObjectIdentifier> NewPreviousElement`
  - The previous sibling in the new location (null if first or not in array)
