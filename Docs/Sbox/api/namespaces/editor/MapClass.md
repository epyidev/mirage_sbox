# Editor.MapClass

Represents an entity class used by the map editor

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Constructors

- `MapClass(System.String name)`

## Properties

- `System.String Name`
  - Class name e.g prop_physics
- `System.String DisplayName`
  - Display name e.g Physics Prop
- `System.String Description`
  - Human readable name e.g Physics Prop
- `System.String Icon`
  - Icon ( Material )
- `System.String Category`
  - Category
- `System.Type Type`
  - C# Type of this class
- `System.Boolean IsPointClass`
  - A point entity, i.e. a model entity, etc.
- `System.Boolean IsSolidClass`
  - A solid class entity, triggers, etc., entities that are tied to from a mesh in Hammer
- `System.Boolean IsPathClass`
  - A path entity, will appear in the Path Tool.
- `System.Boolean IsCableClass`
  - A cable entity, will appear in the Path Tool.
- `System.Collections.Generic.List<Editor.MapClassVariable> Variables`
  - List of properties exposed to tools for this class.
- `System.Collections.Generic.List<Editor.Input> Inputs`
  - List of inputs for this class.
- `System.Collections.Generic.List<Editor.Output> Outputs`
  - List of outputs for this class.
- `System.Collections.Generic.List<System.String> Tags`
  - General purpose tags, some with special meanings within Hammer and map compilers.
- `System.Collections.Generic.List<System.Tuple<System.String,System.String[]>> EditorHelpers`
  - In-editor helpers for this class, such as box visualizers for certain properties, etc.
- `System.Collections.Generic.Dictionary<System.String,System.Object> Metadata`
  - General purpose key-value store to alter functionality of UI, map compilation, editor helpers, etc.
- `System.String GameIdent`
  - What game does this belong to? ( TODO: Might not be best place for this? )
- `Sandbox.Package Package`
  - What package did this entity come from?
