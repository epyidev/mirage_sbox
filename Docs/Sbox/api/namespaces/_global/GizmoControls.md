# Sandbox.Gizmo.GizmoControls

Extendable helper to create common gizmos

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Gizmo`

## Methods

### Static methods

- `static System.IDisposable PushFixedScale(System.Nullable<System.Single> scale)`

### Instance methods

- `System.Boolean BoundingBox(System.String name, BBox value, BBox outValue)`
- `System.Boolean BoundingBox(System.String name, BBox value, BBox outValue, System.Boolean outPressed)`
- `System.Boolean BoundingBox(System.String name, BBox value, BBox outValue, System.Boolean outPressed, Vector3 outResizeAxis)`
- `System.Boolean Capsule(System.String name, Capsule capsule, Capsule outCapsule, Color color)`
- `System.Boolean Position(System.String name, Vector3 position, Vector3 newPos, System.Nullable<Rotation> axisRotation, System.Single squareSize)`
- `System.Boolean Arrow(System.String name, Vector3 axis, System.Single distance, System.Single length, System.Single girth, System.Single axisOffset, System.Single cullAngle, System.Single snapSize, System.String head)`
  - Draw an arrow - return move delta if interacted with
- `System.Boolean DragBox(System.String name, Vector3 size, Rotation rotation, Vector3 movement)`
- `System.Boolean DragSquare(System.String name, Vector2 size, Rotation rotation, Vector3 movement, System.Action drawHandle)`
  - Manipulate a 2d value by moving on 2 axis
- `System.Boolean Rotate(System.String name, Rotation value, Rotation newValue)`
  - A full 3d rotation gizmo. If rotated will return true and newValue will be the new rotation.
- `System.Boolean Rotate(System.String name, Angles outValue)`
- `System.Boolean RotateSingle(System.String name, Color color, System.Single angleDelta, System.Single size, System.Boolean useHalfCircle)`
  - A single rotation axis
- `System.Boolean Scale(System.String name, System.Single value, System.Single outValue)`
  - A front left up position movement widget. If widget was moved then will return true and out will return the new position.
- `System.Boolean Scale(System.String name, Vector3 value, Vector3 outValue, System.Nullable<Rotation> axisRotation, System.Single squareSize)`
- `System.Boolean Sphere(System.String name, System.Single radius, System.Single outRadius, Color color)`
  - A scalable sphere gizmo. Returns true if the gizmo was interacted with and outValue will return the new radius.
