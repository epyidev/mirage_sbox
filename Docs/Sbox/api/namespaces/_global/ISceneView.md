# Editor.EditorEvent.ISceneView

Allows tools to inject behaviour in the scene editor.

- **Kind:** interface
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Tools`
- **Declaring type:** `Editor.EditorEvent`

## Methods

### Instance methods

- `virtual System.Void DrawGizmos(Sandbox.Scene scene)`
  - Called when a scene editor viewport is drawing gizmos.
  - `scene`: Scene that gizmos are being drawn for.
- `virtual System.Void ShowContextMenu(Editor.EditorEvent.ShowContextMenuEvent ev)`
  - Called when a scene editor viewport wants to show a context menu.
  - `ev`: Event arguments describing what the context menu was opened on.
