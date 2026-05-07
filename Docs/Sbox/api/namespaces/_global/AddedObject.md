# Sandbox.Json.AddedObject

Represents an object that needs to be added during patching.

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Json`

## Fields

- `Sandbox.Json.ObjectIdentifier Id`
  - The identifier for the new object
- `Sandbox.Json.ObjectIdentifier Parent`
  - The parent object that will contain this object
- `System.Nullable<Sandbox.Json.ObjectIdentifier> PreviousElement`
  - The previous sibling when adding to an array (null if first or not in array)
- `System.String ContainerProperty`
  - The property name in the parent that will contain this object
- `System.Boolean IsContainerArray`
  - Whether this object is being added to an array (true) or as a direct property (false)
- `System.Text.Json.Nodes.JsonObject Data`
  - The data for the new object
