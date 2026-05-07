# EditorModelAttribute

Declare a model to represent this entity in editor. This is a common attribute so it's leaked out of the Editor namespace.

- **Kind:** attribute
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Attribute`

## Constructors

- `EditorModelAttribute(System.String model, System.String staticColor, System.String dynamicColor)`

## Properties

- `System.String Model`
  - The model to display in the editor.
- `System.Boolean CastShadows`
  - Whether the model should cast shadows in the editor.
- `System.Boolean FixedBounds`
  - Don't reorient bounds. This is used for things that have fixed bounds in the game, like info_player_start.
- `Color StaticColor`
  - Tint color for this editor model instance when the entity it represents is static.
- `Color DynamicColor`
  - Tint color for this editor model instance when the entity it represents is dynamic.
