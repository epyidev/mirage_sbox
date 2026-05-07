# Editor.EditorScene

- **Kind:** static class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Properties

- `static System.Boolean PlayMode`
  - Should the game start in play mode when hitting play, instead of playing the active scene.
- `static Sandbox.Gizmo.SceneSettings GizmoSettings`
- `static Sandbox.SelectionSystem Selection`

## Methods

### Static methods

- `static System.Void RestoreState()`
- `static System.Void NewScene()`
- `static System.Void Open()`
- `static System.Void OpenScene(Sandbox.SceneFile resource)`
  - Opens the given scene file for editing, if it's not already open.
- `static System.Void OpenPrefab(Sandbox.PrefabFile resource)`
  - Opens the given prefab file for editing, if it's not already open.
- `static System.Void SaveSession()`
- `static System.Void SaveSessionAs()`
- `static System.Void SaveAllSessions()`
- `static System.Void Discard()`
- `static System.Void TogglePlay()`
  - Toggles play mode.
- `static System.Void PlayMap(Editor.Asset asset)`
- `static System.Void Play(Editor.SceneEditorSession session)`
- `static System.Void Play(System.Boolean playMode, Editor.SceneEditorSession playableSession)`
- `static System.Void Stop()`
- `static System.Void SceneEditorTick()`
  - Called once a frame to keep the game camera in sync with the main camera in the editor scene
- `static System.Void LoadFromResource(Sandbox.GameResource resource)`
- `static System.Void UpdatePrefabInstances(Sandbox.PrefabFile prefab)`
  - Update any/all instances of a prefab in any open sessions.
Two passes are needed so that changes propagate through prefab dependency
chains regardless of iteration order (e.g. PrefabA → PrefabC → PrefabB).
- `static System.Void Cut()`
- `static System.Void SelectAll()`
- `static System.Void Copy()`
- `static System.Void Paste()`
- `static System.Void PasteAt(Sandbox.SceneTraceResult tr)`
- `static System.Void PasteAsChild()`
- `static System.Void PasteSpecial()`
- `static System.Void PlaceBoundsOnSurface(System.Collections.Generic.IEnumerable<Sandbox.GameObject> gos, Vector3 position, Vector3 normal)`
- `static System.Void TakeHighResScreenshot(System.Int32 width, System.Int32 height)`
  - Capture a high resolution screenshot using the active scene camera.
