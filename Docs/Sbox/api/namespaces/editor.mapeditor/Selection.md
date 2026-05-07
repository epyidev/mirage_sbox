# Editor.MapEditor.Selection

Current selection set for the active map

- **Kind:** static class
- **Namespace:** `Editor.MapEditor`
- **Assembly:** `Sandbox.Tools`

## Properties

- `static Editor.MapEditor.SelectMode SelectMode`
  - The current selection mode e.g Meshes or Objects
- `static Vector3 PivotPosition`
  - The position of the selection's pivot
- `static System.Collections.Generic.IEnumerable<Editor.MapDoc.MapNode> All`
  - All the map nodes in the current selection set

## Methods

### Static methods

- `static System.Void Add(Editor.MapDoc.MapNode node)`
  - Add the map node to the current set
- `static System.Void Set(Editor.MapDoc.MapNode node)`
  - Clear the current set, making the map node the only selected node
- `static System.Void Remove(Editor.MapDoc.MapNode node)`
  - Remove this map node from the current set if it exists
- `static System.Void Clear()`
  - Clear everything from the current selection set
- `static System.Void SelectAll()`
  - Add all to the current selection
- `static System.Void InvertSelection()`
  - Invert the current selection
