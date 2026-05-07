# Editor.MapDoc.MapWorld

MapWorld is the root node of a `Editor.MapDoc.MapDocument`, however it can have multiple sub `Editor.MapDoc.MapWorld` of prefabs.

- **Kind:** sealed class
- **Namespace:** `Editor.MapDoc`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.MapDoc.MapNode`

## Properties

- `Sandbox.Scene Scene`
- `Editor.MapEditor.HammerSceneEditorSession EditorSession`
- `System.String MapPathName`
- `System.Collections.Generic.IEnumerable<Editor.MapDoc.MapNode> Children`
  - All children nodes of this world.
