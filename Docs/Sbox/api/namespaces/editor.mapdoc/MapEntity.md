# Editor.MapDoc.MapEntity

MapEntity in Hammer is a type of `Editor.MapDoc.MapNode` that has a set of key/value pairs.
The keyvalues represent the authoritative state of the entity. 

Entities may have helpers that enhance the presentation and sometimes modification of those keyvalues.
The helpers may come and go; it should always be possible to recreate the helpers from
the parent entity's keyvalues.

Entities may also have zero or more `Editor.MapDoc.MapMesh` children.

- **Kind:** sealed class
- **Namespace:** `Editor.MapDoc`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.MapDoc.MapNode`

## Constructors

- `MapEntity(Editor.MapDoc.MapDocument mapDocument)`

## Properties

- `Sandbox.SerializedObject SerializedObject`
- `Editor.MapClass MapClass`
- `Sandbox.TypeDescription TypeDescription`
- `System.String ClassName`
  - Entity class name like prop_physics

## Methods

### Instance methods

- `System.String GetKeyValue(System.String key)`
  - Gets the value for the key, e.g "model" could return "models/props_c17/oildrum001_explosive.mdl"
- `System.Void SetKeyValue(System.String key, System.String value)`
  - Sets the value for the key, e.g "model" could be set to "models/props_c17/oildrum001_explosive.mdl"
- `System.Void SetDefaultBounds(Vector3 min, Vector3 max)`
  - Sets the default bounds of the entity if it doesn't have a model. By default this is 16x16x16.
