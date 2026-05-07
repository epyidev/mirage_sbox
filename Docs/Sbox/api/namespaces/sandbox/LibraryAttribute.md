# Sandbox.LibraryAttribute

- **Kind:** attribute
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Attribute`

## Constructors

- `LibraryAttribute()`
- `LibraryAttribute(System.String name)`

## Properties

- `System.String Name`
  - This is the name that will be used to create this class.
If you don't set it via the attribute constructor it will be set
to the name of the class it's attached to
- `System.String FullName`
  - The full class name
- `System.String Title`
  - A nice presentable name to show
- `System.String Description`
  - We use this to provide a nice description in the editor
- `System.String Group`
  - We use this to organize groups of entities in the editor
- `System.Boolean Editable`
  - We use this to filter entities to show in the entity list in the editor
