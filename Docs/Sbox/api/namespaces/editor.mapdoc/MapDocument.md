# Editor.MapDoc.MapDocument

Represents an open map document. A document has a tree of `Editor.MapDoc.MapNode` that represent the world.

- **Kind:** class
- **Namespace:** `Editor.MapDoc`
- **Assembly:** `Sandbox.Tools`

## Properties

- `System.String PathName`
  - The map file name
- `Editor.MapDoc.MapWorld World`
  - The world

## Methods

### Instance methods

- `System.Void DeleteNode(Editor.MapDoc.MapNode node)`
  - Removes the node from the world, deletes all children too.
