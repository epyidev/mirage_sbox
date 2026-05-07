# Editor.EditorEvent.ShowContextMenuEvent

Event args for `Editor.EditorEvent.ISceneView.ShowContextMenu(Editor.EditorEvent.ShowContextMenuEvent)` events.

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Tools`
- **Declaring type:** `Editor.EditorEvent`

## Constructors

- `ShowContextMenuEvent(Editor.SceneEditorSession Session, Editor.Menu Menu, Ray CursorRay, System.Nullable<Sandbox.SceneTraceResult> Trace)`

## Properties

- `Editor.SceneEditorSession Session`
  - Scene editor session that the context menu is being opened for.
- `Editor.Menu Menu`
  - Context menu being opened. Feel free to add options to it in your handler.
- `Ray CursorRay`
  - Cursor ray when right-click was pressed.
- `System.Nullable<Sandbox.SceneTraceResult> Trace`
  - Trace result if we hit an object in the scene when right-clicking.

## Methods

### Instance methods

- `Editor.EditorEvent.ShowContextMenuEvent <Clone>$()`
- `System.Void Deconstruct(Editor.SceneEditorSession Session, Editor.Menu Menu, Ray CursorRay, System.Nullable<Sandbox.SceneTraceResult> Trace)`
