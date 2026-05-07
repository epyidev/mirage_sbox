# Editor.MapDoc.MapNode

A common class used for all objects in the world object tree.

- **Kind:** class
- **Namespace:** `Editor.MapDoc`
- **Assembly:** `Sandbox.Tools`

## Properties

- `System.String Name`
  - User specified name of this node
- `System.String TypeString`
  - Native C++ type name for this map node (nice for debug, might disappear at some point)
- `Vector3 Position`
  - World position of this map node.
- `Angles Angles`
  - Euler angles of this map node.
- `Vector3 Scale`
  - Non-uniform scalar for this map node.
- `Editor.MapDoc.MapNode Parent`
  - The parent node, at the top level this will be the `Editor.MapDoc.MapWorld`
- `System.Collections.Generic.IEnumerable<Editor.MapDoc.MapNode> Children`
  - Each MapNode can have many children. Children usually transform with their parents, etc.
- `System.Boolean Visible`
  - Visibility of this MapNode, e.g if it's been hidden by the user
- `Editor.MapDoc.MapWorld World`
  - The world this map node belongs to.
- `System.Boolean GeneratesEntityModelGeometry`
  - Does this map node generate models to use?

## Methods

### Instance methods

- `Editor.MapDoc.MapNode Copy()`
  - Creates a copy of this map node.
- `System.Void Remove()`
