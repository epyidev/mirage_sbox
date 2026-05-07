# Editor.SceneEditorSession

A SceneEditorSession holds a Scene that is open in the editor.
It creates a widget, has a selection and undo system.

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Constructors

- `SceneEditorSession(Sandbox.Scene scene)`

## Properties

- `static System.Collections.Generic.List<Editor.SceneEditorSession> All`
  - All open editor sessions
- `static Editor.SceneEditorSession Active`
  - The editor session that is currently active
- `System.Boolean IsPrefabSession`
  - Returns true if this session is editing a prefab
- `Sandbox.Scene Scene`
- `System.Boolean ShouldUpdate`
  - Should we call `Sandbox.Scene.EditorTick(System.Single,System.Single)` while this session is visible?
- `System.Action<BBox> OnFrameTo`
- `System.Boolean HasUnsavedChanges`
- `Editor.GameEditorSession GameSession`
  - The game session of this editor session, if playing.
- `System.Boolean IsPlaying`
- `Sandbox.SelectionSystem Selection`
- `Sandbox.Helpers.UndoSystem UndoSystem`

## Methods

### Static methods

- `static System.IDisposable Scope()`
  - Pushes the active scene to the current scope
- `static Editor.SceneEditorSession Resolve(Sandbox.Scene scene)`
  - Resolve a scene to an editor session. If it's a game scene, resolves the parent editor session.
- `static Sandbox.Scene.ISceneEditorSession Resolve(Sandbox.Component component)`
  - Resolve a Component to an editor session.
- `static Sandbox.Scene.ISceneEditorSession Resolve(Sandbox.GameObject go)`
  - Resolve a GameObject to an editor session.
- `static Editor.SceneEditorSession Resolve(Sandbox.SceneFile sceneFile)`
  - Resolve a scene file to an editor session.
- `static Editor.SceneEditorSession Resolve(Sandbox.PrefabFile prefabFile)`
  - Resolve a prefab file to an editor session.
- `static Editor.SceneEditorSession Resolve(Facepunch.ActionGraphs.ISourceLocation sourceLocation)`
  - Resolve an action graph source location to an editor session.
- `static Editor.SceneEditorSession CreateDefault()`
  - Make a new SceneEditorSession with a default scene
- `static Editor.SceneEditorSession CreateFromPath(System.String path)`
  - Opens an editor session from an existing scene or prefab

### Instance methods

- `virtual System.Void Destroy()`
- `System.Void MakeActive(System.Boolean bringToFront)`
  - Makes this scene active and brings it to the front
- `System.Void BringToFront()`
  - Bring this scene tab to the front
- `System.Void Tick()`
- `virtual System.Void OnEdited()`
- `virtual System.Void FrameTo(BBox& modreq(System.Runtime.InteropServices.InAttribute) box)`
- `System.Void Reload()`
- `virtual System.Void Save(System.Boolean saveAs)`
- `virtual System.Void RecordChange(Sandbox.SerializedProperty property)`
- `virtual System.Collections.Generic.IEnumerable<System.Object> GetSelection()`
- `virtual Editor.SceneFolder GetSceneFolder()`
- `System.Void SetPlaying(Sandbox.Scene scene)`
- `virtual System.Void StopPlaying()`
- `System.String SerializeSelection()`
  - Serlialize the current selection to a json string. The aim here is to make something we can transfer back to objects.
- `System.Void DeserializeSelection(System.String selection)`
  - Take a json string created by SerializeSelection and turn it into a selection
- `System.IDisposable SuppressUndoSounds()`
  - Temporarily disables undo/redo sounds.
- `System.Void FullUndoSnapshot(System.String title)`
  - Take a full scene snapshot for the undo system. This is usually a last resort, if you can't do anything more incremental.
- `System.Void PushUndoSelection()`
  - Push the current selection into the undo system
- `virtual System.Void AddUndo(System.String name, System.Action undo, System.Action redo)`
- `virtual ISceneUndoScope UndoScope(System.String name)`
