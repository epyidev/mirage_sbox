# Line

Represents a line in 3D space.

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`

## Constructors

- `Line(Vector3 a, Vector3 b)`
- `Line(Vector3 origin, Vector3 direction, System.Single length)`

## Properties

- `Vector3 Start`
  - Start position of the line.
- `Vector3 End`
  - End position of the line.
- `Vector3 Delta`
  - Returns the result of b - a
- `Vector3 Center`
  - Returns the midpoint between a and b

## Methods

### Instance methods

- `System.Boolean Trace(Ray ray, System.Single radius, System.Single maxDistance)`
  - Perform a "trace" between this line and given ray. If the 2 lines intersect, returns true.
  - `ray`: The ray to test against.
  - `radius`: Radius of this line, which essentially makes this a capsule, since direct line-to-line intersections are very improbable. Must be above 0.
  - `maxDistance`: Maximum allowed distance from the origin of the ray to the intersection.
  - returns: Whether there was an intersection or not.
- `Vector3 ClosestPoint(Vector3 pos)`
  - Returns closest point on this line to the given point.
- `System.Boolean ClosestPoint(Ray ray, Vector3 point_on_line)`
  - Returns closest point on this line to the given ray.
- `System.Boolean ClosestPoint(Ray ray, Vector3 point_on_line, Vector3 point_on_ray)`
  - Returns closest point on this line to the given ray.
- `System.Single Distance(Vector3 pos)`
  - Returns closest distance from this line to given point.
- `System.Single Distance(Vector3 pos, Vector3 closestPoint)`
  - Returns closest distance from this line to given point.
- `System.Single SqrDistance(Vector3 pos)`
  - Returns closest squared distance from this line to given point.
