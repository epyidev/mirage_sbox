# Sandbox.ModelEditor.GameDataAttribute

Indicates that this class/struct should be available as GenericGameData node in ModelDoc

- **Kind:** attribute
- **Namespace:** `Sandbox.ModelEditor`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.LibraryAttribute`

## Constructors

- `GameDataAttribute(System.String name)`

## Properties

- `System.Boolean AllowMultiple`
  - Indicates that this type compiles as list, rather than a single entry in the model.
This will also affect how you retrieve this data via Model.GetData().
