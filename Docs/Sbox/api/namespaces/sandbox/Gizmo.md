# Sandbox.Gizmo

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static Sandbox.Gizmo.GizmoControls Control`
  - Holds fully realized controls to manipulate some value
- `static Sandbox.Gizmo.GizmoDraw Draw`
  - Draw a shape using the gizmo library
- `static Sandbox.SceneWorld World`
- `static Ray PreviousRay`
- `static Ray CurrentRay`
- `static System.Single RayDepth`
- `static System.String ControlMode`
- `static Transform Transform`
- `static System.String Path`
- `static System.Object Object`
- `static Sandbox.SceneCamera Camera`
- `static System.Boolean IsHovered`
- `static System.Boolean IsSelected`
- `static System.Boolean IsChildSelected`
- `static System.Boolean WasClicked`
- `static System.Boolean HasSelected`
- `static System.Boolean HasHovered`
- `static System.Boolean HasClicked`
- `static System.Boolean HasMouseFocus`
- `static Vector2 CursorPosition`
  - The current cursor position, in screen space
- `static Vector2 CursorMoveDelta`
  - The delta of cursor movement between this frame and last, in screen space
- `static Vector2 CursorDragDelta`
  - The delta of cursor movement between last press and now, in screen space.
If left mouse isn't down, will return CursorMoveDelta
- `static Sandbox.KeyboardModifiers KeyboardModifiers`
  - The current keyboard modifiers
- `static System.Boolean IsCtrlPressed`
- `static System.Boolean IsShiftPressed`
- `static System.Boolean IsAltPressed`
- `static System.Boolean WasLeftMouseReleased`
- `static System.Boolean IsLeftMouseDown`
- `static System.Boolean WasLeftMousePressed`
- `static System.Boolean WasRightMouseReleased`
- `static System.Boolean IsRightMouseDown`
- `static System.Boolean WasRightMousePressed`
- `static System.Boolean IsDoubleClicked`
- `static Transform CameraTransform`
  - The cameras transform - in world space
- `static Transform LocalCameraTransform`
  - The cameras transform - in local space
- `static System.Boolean IsPressed`
- `static System.Boolean HasPressed`
- `static Ray PressRay`
- `static Sandbox.Gizmo.SceneSettings Settings`
- `static Sandbox.Gizmo.GizmoHitbox Hitbox`
  - Allows creating a gizmo hitbox which will be interactable using the mouse (or vr deck2 super controller)

## Methods

### Static methods

- `static System.Void EndInstance(Sandbox.Gizmo.Instance previous)`
- `static System.Void Select(System.Boolean allowUnselect, System.Boolean allowMultiSelect)`
- `static System.IDisposable Scope(System.String path, Transform tx)`
  - Create a new scope - any changes to colors and transforms will be stored
and reverted when exiting the scope.
- `static System.IDisposable Scope(System.String path, Vector3 position)`
  - Create a new scope - any changes to colors and transforms will be stored
and reverted when exiting the scope.
- `static System.IDisposable Scope(System.String path, Vector3 position, Rotation rotation, System.Single scale)`
  - Create a new scope - any changes to colors and transforms will be stored
and reverted when exiting the scope.
- `static System.IDisposable Scope(System.String path)`
  - Create a new scope - any changes to colors and transforms will be stored
and reverted when exiting the scope.
- `static System.IDisposable ObjectScope(T obj, Transform tx)`
  - Create a new scope - any changes to colors and transforms will be stored
and reverted when exiting the scope.
- `static System.Nullable<Vector3> GetPositionOnPlane(Vector3 position, Vector3 planeNormal, Ray ray)`
  - Get the distance from a point on a plane
- `static Vector3 GetMouseDelta(Vector3 position, Vector3 planeNormal)`
  - Get the mouse delta at this current position
- `static Vector3 GetMouseDrag(Vector3 position, Vector3 planeNormal)`
  - Get the mouse drag distance at this current position, assuming we are pressed
- `static Vector3 GetMouseDistanceVector(Vector3 position, Vector3 planeNormal)`
  - Get the vector distance from a point on a plane
- `static System.Single GetMouseDistance(Vector3 position, Vector3 planeNormal)`
  - Get the distance from a point on a plane
- `static System.Single GetMouseDistanceDelta(Vector3 position, Vector3 planeNormal)`
  - Get the distance moved from (or towards) a position on a plane
- `static Vector3 Snap(Vector3 input, Vector3 movement)`
  - Will snap this position, depending on the current snap settings and keys that are pressed.
Will snap along if movement is detected along that axis. For example, if movement is 1,0,0 then we'll
only snap on the x axis.
- `static Angles Snap(Angles input, Angles movement)`
  - Will snap this position, depending on the current snap settings and keys that are pressed.
Will snap along if movement is detected along that axis. For example, if movement is 1,0,0 then we'll
only snap on the x axis.
- `static Rotation Snap(Rotation rotationDelta)`
  - Snaps a rotation delta to angle increments.
  - `rotationDelta`: The rotation delta to snap
  - returns: A snapped rotation that aligns to the angle grid
- `static BBox Snap(BBox startBox, BBox movement)`
  - Applies snapping to a box being resized using delta tracking. Returns a properly snapped box.
  - `startBox`: The original box before resizing began
  - `movement`: The accumulated delta changes
  - returns: A new snapped box with proper minimum dimensions
- `static Vector3 Nudge(Rotation rotation, Vector2 direction)`
  - Will give you a nudge vector along the most aligned left and up axis of the rotation
based on left/right/up/down direction and camera angle
