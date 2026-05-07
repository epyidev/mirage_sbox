# Sandbox.Frustum

Represents a <a href="https://en.wikipedia.org/wiki/Frustum">frustum</a>.

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Constructors

- `Frustum(Sandbox.Plane right, Sandbox.Plane left, Sandbox.Plane top, Sandbox.Plane bottom, Sandbox.Plane near, Sandbox.Plane far)`
  - Creates a frustum from 6 planes.

## Fields

- `Sandbox.Plane RightPlane`
  - Right plane of the frustum, pointing inwards.
- `Sandbox.Plane LeftPlane`
  - Left plane of the frustum, pointing inwards.
- `Sandbox.Plane TopPlane`
  - Top plane of the frustum, pointing inwards.
- `Sandbox.Plane BottomPlane`
  - Bottom plane of the frustum, pointing inwards.
- `Sandbox.Plane NearPlane`
  - Near plane of the frustum, pointing inwards.
- `Sandbox.Plane FarPlane`
  - Far plane of the frustum, pointing inwards.

## Methods

### Static methods

- `static Sandbox.Frustum FromCorners(Ray tl, Ray tr, Ray br, Ray bl, System.Single near, System.Single far)`
  - Create a frustum from four corner rays. These rays commonly come from SceneCamera.GetRay.

### Instance methods

- `System.Nullable<Vector3> GetCorner(System.Int32 i)`
  - Returns the corner point of one of the 8 corners.
This may return null if i is &gt; 7 or the frustum is invalid.
- `BBox GetBBox()`
  - Returns the AABB of this frustum.
- `System.Boolean IsInside(Vector3 point)`
  - Returns whether the given point is inside this frustum.
- `System.Boolean IsInside(BBox box, System.Boolean partially)`
  - Returns whether given AABB is inside this frustum.
  - `box`: The AABB to test.
  - `partially`: Whether test for partial intersection, or complete encompassing of the AABB within this frustum.
- `System.Boolean IsInside(Vector3 center, System.Single radius, System.Boolean partially)`
  - Returns whether the given sphere is inside this frustum.
  - `center`: The center of the sphere.
  - `radius`: The radius of the sphere.
  - `partially`: Whether test for partial intersection, or complete encompassing of the sphere within this frustum.
- `System.Boolean IsInside(Sandbox.Sphere sphere, System.Boolean partially)`
  - Returns whether the given sphere is inside this frustum.
  - `sphere`: The sphere to test against.
  - `partially`: Whether test for partial intersection, or complete encompassing of the sphere within this frustum.
