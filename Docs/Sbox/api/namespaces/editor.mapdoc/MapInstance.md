# Editor.MapDoc.MapInstance

A map node which allows a target group and its children to be placed with a new position
and orientation in the world without creating a new copy.

Multiple MapInstance classes may reference the same target allowing it to be placed in
multiple locations, but allowing any edits to be applied to all instances.

- **Kind:** sealed class
- **Namespace:** `Editor.MapDoc`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.MapDoc.MapNode`

## Constructors

- `MapInstance(Editor.MapDoc.MapDocument mapDocument)`

## Properties

- `Editor.MapDoc.MapNode Target`
  - The target map node this MapInstance references to copy.
