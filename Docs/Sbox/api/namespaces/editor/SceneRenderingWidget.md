# Editor.SceneRenderingWidget

Render a scene to a native widget. This replaces NativeRenderingWidget.

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Frame`

## Constructors

- `SceneRenderingWidget(Editor.Widget parent)`

## Properties

- `Sandbox.Scene Scene`
  - The active scene that we're rendering
- `Sandbox.CameraComponent Camera`
  - The camera to render from. We will fallback to Scene.Camera if this is null
- `Sandbox.Gizmo.Instance GizmoInstance`
  - This widget manages it's own gizmo instance.
- `System.Boolean EnableEngineOverlays`
- `Ray CursorRay`
  - Return a ray for the current cursor position

## Methods

### Instance methods

- `Sandbox.CameraComponent CreateSceneEditorCamera()`
  - Create a hidden scene editor camera, post processing will be copied from a main camera in the scene.
- `virtual System.Void PreFrame()`
  - Called just before rendering.
- `System.Void UpdateGizmoInputs(System.Boolean hasMouseFocus)`
  - Update common inputs for gizmo.
- `Ray GetRay(Vector2 localPosition)`
  - Given a local widget position, return a Ray
