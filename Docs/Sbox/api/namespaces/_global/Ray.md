# Ray

A struct describing an origin and direction

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`

## Constructors

- `Ray(Vector3 origin, Vector3 direction)`

## Properties

- `Vector3 Position`
  - Origin of the ray.
- `Vector3 Forward`
  - Direction of the ray.

## Methods

### Instance methods

- `Ray ToLocal(Transform tx)`
  - Convert a ray to be local to this transform
- `Ray ToWorld(Transform tx)`
  - Convert a ray from being local to this transform
- `Vector3 Project(System.Single distance)`
  - Returns a point on the ray at given distance.
  - `distance`: How far from the `Ray.Position` the point should be.
  - returns: The point at given distance.
