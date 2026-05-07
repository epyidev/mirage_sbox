# Editor.MapEditor.HammerSceneEditorSession

- **Kind:** class
- **Namespace:** `Editor.MapEditor`
- **Assembly:** `Sandbox.Tools`

## Constructors

- `HammerSceneEditorSession(Sandbox.Scene scene, Editor.MapDoc.MapWorld mapWorld)`

## Properties

- `static System.Collections.Generic.List<Editor.MapEditor.HammerSceneEditorSession> All`
- `Sandbox.Scene Scene`
- `Editor.MapDoc.MapWorld MapWorld`
- `Sandbox.SelectionSystem Selection`
- `Facepunch.ActionGraphs.ISourceLocation SourceLocation`
- `System.Boolean HasUnsavedChanges`

## Methods

### Static methods

- `static Editor.MapEditor.HammerSceneEditorSession Resolve(System.String mapPathName)`
  - Resolve a map path name to an editor session.
- `static Editor.MapEditor.HammerSceneEditorSession Resolve(Facepunch.ActionGraphs.ISourceLocation sourceLocation)`

### Instance methods

- `System.Void Destroy()`
- `System.Void Focus()`
- `virtual System.Collections.Generic.IEnumerable<System.Object> GetSelection()`
- `virtual ISceneUndoScope UndoScope(System.String name)`
