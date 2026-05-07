# Editor.MapEditor.History

Undo/redo history for the current active mapdoc

- **Kind:** static class
- **Namespace:** `Editor.MapEditor`
- **Assembly:** `Sandbox.Tools`

## Methods

### Static methods

- `static System.Void MarkUndoPosition(System.String name)`
  - Mark new undo position
- `static System.Void Keep(Editor.MapDoc.MapNode node)`
  - Keeps a map node and all its children, so changes to it can be undone.
- `static System.Void KeepNew(Editor.MapDoc.MapNode node)`
  - Keeps a new object node and all of its children, so they can be deleted on an undo.
