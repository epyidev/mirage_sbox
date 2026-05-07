# Sandbox.AssetTypeAttribute

Should be applied to a class that inherits from `Sandbox.GameResource`.
Makes the class able to be stored as an asset on disk.

- **Kind:** attribute
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Attribute`

## Constructors

- `AssetTypeAttribute()`

## Properties

- `System.Type TargetType`
  - This gets filled in by the TypeLibrary when the class is registered, it shouldn't be changed manually.
- `System.String Name`
  - The title of this game resource.
- `System.String Extension`
  - File extension for this game resource.
- `System.String Category`
  - Category of this game resource, for grouping in UI.
- `Sandbox.AssetTypeFlags Flags`
  - Flags for this asset type.

## Methods

### Static methods

- `static Sandbox.TypeDescription FindTypeByExtension(System.String extension)`
  - Find a resource type by its extension. The extension should have no period.
