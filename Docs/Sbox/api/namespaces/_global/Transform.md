# Transform

A struct containing a position, rotation and scale. This is commonly used in engine to describe
entity position, bone position and scene object position.

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`

## Constructors

- `Transform(Vector3 pos)`
- `Transform()`
- `Transform(Vector3 position, Rotation rotation, System.Single scale)`
- `Transform(Vector3 position, Rotation rotation, Vector3 scale)`

## Properties

- `System.Single UniformScale`
  - A uniform scale component. Generally the scale is uniform, and we'll just access the .x component.
- `Vector3 Forward`
- `Vector3 Backward`
- `Vector3 Up`
- `Vector3 Down`
- `Vector3 Right`
- `Vector3 Left`
- `System.Boolean IsValid`
  - Returns true if position, scale and rotation are valid
- `Ray ForwardRay`
  - Return a ray from this transform, which goes from the center along the Forward

## Fields

- `static Transform Zero`
  - Represents a zero transform, that being, a transform with scale of 1, position of `Vector3.Zero` and rotation of `Rotation.Identity`.
- `Vector3 Position`
  - Position of the transform.
- `Vector3 Scale`
  - Scale of the transform. Does not itself scale `Transform.Position` or `Transform.Rotation`.
- `Rotation Rotation`
  - Rotation of this transform.

## Methods

### Static methods

- `static Transform Lerp(Transform a, Transform b, System.Single t, System.Boolean clamp)`
  - Perform linear interpolation from one transform to another.
- `static Transform Concat(Transform parent, Transform local)`
  - Concatenate (add together) the 2 given transforms and return a new resulting transform.
- `static Transform Parse(System.String str)`
  - Given a string, try to convert this into a transform. The format is `"px,py,pz,rx,ry,rz,rw"`.

### Instance methods

- `Vector3 PointToLocal(Vector3 worldPoint)`
  - Convert a point in world space to a point in this transform's local space
- `Vector3 NormalToLocal(Vector3 worldNormal)`
  - Convert a world normal to a local normal
- `Rotation RotationToLocal(Rotation worldRot)`
  - Convert a world rotation to a local rotation
- `Vector3 PointToWorld(Vector3 localPoint)`
  - Convert a point in this transform's local space to a point in world space
- `Vector3 NormalToWorld(Vector3 localNormal)`
  - Convert a local normal to a world normal
- `Rotation RotationToWorld(Rotation localRotation)`
  - Convert a local rotation to a world rotation
- `Transform ToLocal(Transform child)`
  - Convert child transform from the world to a local transform
- `Transform ToWorld(Transform child)`
  - Convert child transform from local to the world
- `Transform LerpTo(Transform target, System.Single t, System.Boolean clamp)`
  - Linearly interpolate from this transform to given transform.
- `Transform Add(Vector3 position, System.Boolean worldSpace)`
  - Add a position to this transform and return the result.
- `Transform WithPosition(Vector3 position)`
  - Return this transform with a new position.
- `Transform WithPosition(Vector3 position, Rotation rotation)`
  - Return this transform with a new position and rotation
- `Transform WithRotation(Rotation rotation)`
  - Return this transform with a new rotation.
- `Transform WithScale(System.Single scale)`
  - Return this transform with a new scale.
- `Transform WithScale(Vector3 scale)`
  - Return this transform with a new scale.
- `Transform Mirror(Sandbox.Plane plane)`
  - Create a transform that is the mirror of this
- `Transform RotateAround(Vector3 center, Rotation rot)`
  - Rotate this transform around given point by given rotation and return the result.
  - `center`: Point to rotate around.
  - `rot`: How much to rotate by. `Rotation.FromAxis(Vector3,System.Single)` can be useful.
  - returns: The rotated transform.
- `System.Boolean AlmostEqual(Transform tx, System.Single delta)`
  - Returns true if we're nearly equal to the passed transform.
  - `tx`: The value to compare with
  - `delta`: The max difference between component values (used for Position and Scale)
  - returns: True if nearly equal
