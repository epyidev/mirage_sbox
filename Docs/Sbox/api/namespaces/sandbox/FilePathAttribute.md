# Sandbox.FilePathAttribute

When added to a string property, will become a file picker for the given extension (or all by default)

- **Kind:** attribute
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Attribute`

## Constructors

- `FilePathAttribute()`

## Properties

- `System.String Extension`
  - The extension to filter by. If empty, all files are shown.
Can be a comma separated list of extensions, or a single extension.
