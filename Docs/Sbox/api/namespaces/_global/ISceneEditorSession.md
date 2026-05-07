# Sandbox.Scene.ISceneEditorSession

- **Kind:** interface
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Scene`

## Properties

- `Sandbox.Scene Scene`
  - The scene for this session
- `System.Boolean HasUnsavedChanges`
  - True if this scene has unsaved changes
- `Sandbox.SelectionSystem Selection`
  - Selection system for this session
- `Sandbox.GameObject SelectedGameObject`
  - If we have any gameobjects selected, return the first one
- `Sandbox.BaseFileSystem TransientFilesystem`
  - Get the filesystem in which temporary files can be created. These files can be used (and shipped) by a package, but won't be stored in source control.
This is usually used for files that are expected to be re-generated at runtime by the package itself.

## Methods

### Instance methods

- `virtual System.Void AddSelectionUndo()`
  - You have changed the editor's selection, add a new undo entry
- `virtual System.Void OnEditLog(System.String name, System.Object source)`
- `virtual System.Void FrameTo(BBox& modreq(System.Runtime.InteropServices.InAttribute) box)`
- `virtual System.Void Save(System.Boolean forceSaveAs)`
  - Save this scene to disk
- `virtual System.Void RecordChange(Sandbox.SerializedProperty property)`
  - Tell undo about this property change
- `virtual System.Void AddUndo(System.String name, System.Action undo, System.Action redo)`
  - Add a new undo entry
- `virtual ISceneUndoScope UndoScope(System.String name)`
- `virtual System.Collections.Generic.IEnumerable<System.Object> GetSelection()`
  - Gets the current selection from the editor
- `virtual Editor.SceneFolder GetSceneFolder()`
  - Get the folder for this scene. This is a folder in which we can store assets that are referenced by this scene. Things like envmap textures, lightmaps, baked data, etc.
