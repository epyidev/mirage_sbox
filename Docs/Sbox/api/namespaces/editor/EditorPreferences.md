# Editor.EditorPreferences

- **Kind:** static class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Properties

- `static System.Boolean NotificationPopups`
- `static System.Boolean NotificationSounds`
- `static System.Boolean ClearConsoleOnPlay`
- `static System.Boolean FullScreenOnPlay`
- `static System.Boolean FastHotload`
- `static Editor.EditorPreferences.NotificationLevel CompileNotifications`
- `static System.Single ErrorNotificationTimeout`
  - The amount of seconds to keep a notification open if it's an error
- `static System.Single CameraFieldOfView`
  - Camera field of view
- `static System.Single CameraZNear`
  - The closest thing to render
- `static System.Single CameraZFar`
  - The furthest thing to render
- `static System.Single CameraMovementSmoothing`
  - Should we smooth the movement of the camera. This is the smooth time, in seconds. No smoothing
feels pretty jarring, but a bit feels nice. Once you get over half a second it makes everything feel
slow and horrible.
- `static System.Single CameraSpeed`
  - How fast should the camera move
- `static System.Single CameraSensitivity`
- `static System.Boolean CreateObjectsAtOrigin`
- `static System.Boolean InvertOrbitZoom`
  - Should the orbit camera zoom be inverted?
- Inverted: mouse up/left zooms in, mouse down/right zooms out- Standard: mouse down/right zooms in, mouse up/left zooms out
- `static System.Single OrbitZoomSpeed`
  - How fast should the orbit camera zoom?
- `static System.Boolean CameraInvertPan`
  - Should the camera panning be inverted?
- `static System.Boolean HideRotateCursor`
  - Should we hide the eye cursor when rotating the scene camera?
- `static System.Boolean HidePanCursor`
  - Should we hide the eye cursor when panning scene camera?
- `static System.Boolean HideOrbitCursor`
  - Should we hide the eye cursor when orbiting scene camera?
- `static System.Boolean BackfaceSelection`
  - Should we hit the back faces when tracing meshes
- `static System.Boolean BoundsPlacement`
  - Use bounds when dragging in objects
- `static System.Boolean PasteAtCursor`
  - When enabled, pasted or duplicated objects are placed under the cursor and aligned to the hit surface.
- `static System.Boolean UndoSounds`
  - Controls whether a sound is played for any undo/redo operation (success or failure)
- `static System.Collections.Generic.Dictionary<System.String,System.String> ShortcutOverrides`
  - Overrides for any Editor shortcuts.
- `static System.Boolean WindowedLocalInstances`
  - Whether new game instances spawned by the editor are in windowed mode.
- `static System.String NewInstanceCommandLineArgs`
  - Command-line arguments for new game instances spawned by the editor.
- `static System.String DedicatedServerCommandLineArgs`
  - Command-line arguments for new game instances spawned by the editor.
