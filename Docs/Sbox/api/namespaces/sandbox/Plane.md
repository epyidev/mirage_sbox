# Sandbox.Plane

Represents a plane.

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Constructors

- `Plane(Vector3 normal, System.Single dist)`
- `Plane(Vector3 origin, Vector3 normal)`
- `Plane(Vector3 origin, Vector3 posA, Vector3 posB)`
  - Creates a new plane from 3 given positions.
  - `origin`: Origin of the plane.
  - `posA`: A position to calculate a normal with.
  - `posB`: Another position to calculate a normal with.

## Properties

- `Vector3 Origin`
  - Origin position of the plane, basically a vector `Sandbox.Plane.Distance` away from world origin in the direction given by `Sandbox.Plane.Normal`.
- `Vector3 Position`
  - Origin position of the plane, basically a vector `Sandbox.Plane.Distance` away from world origin in the direction given by `Sandbox.Plane.Normal`.

## Fields

- `Vector3 Normal`
  - The direction of the plane.
- `System.Single Distance`
  - Distance of the plane from world origin in the direction given by `Sandbox.Plane.Normal`.

## Methods

### Static methods

- `static System.Nullable<Vector3> GetIntersection(Sandbox.Plane vp1, Sandbox.Plane vp2, Sandbox.Plane vp3)`
  - Gets the intersecting point of the three planes if it exists.
If the planes don't all intersect will return null.

### Instance methods

- `System.Single GetDistance(Vector3 point)`
  - Returns the distance from this plane to given point.
- `System.Boolean IsInFront(Vector3 point)`
  - Returns true if given point is on the side of the plane where its normal is pointing.
- `System.Boolean IsInFront(BBox box, System.Boolean partially)`
  - Returns true if given bounding box is on the side of the plane where its normal is pointing.
- `Vector3 SnapToPlane(Vector3 point)`
  - Returns closest point on the plane to given point.
- `System.Boolean TryTrace(Ray ray, Vector3 hitPoint, System.Boolean twosided, System.Double maxDistance)`
  - Trace a Ray against this plane
- `System.Nullable<Vector3> Trace(Ray ray, System.Boolean twosided, System.Double maxDistance)`
  - Trace a Ray against this plane
  - `ray`: The origin and direction to trace from
  - `twosided`: If true we'll trace against the underside of the plane too.
  - `maxDistance`: The maximum distance from the ray origin to trace
  - returns: The hit position on the ray. Or null if we didn't hit.
- `System.Nullable<Vector3> IntersectLine(Line line)`
  - Gets the intersecting point of a line segment.
- `System.Nullable<Vector3> IntersectLine(Vector3 start, Vector3 end)`
  - Gets the intersecting point of a line segment.
- `Vector3 ReflectPoint(Vector3 point)`
  - Reflects a point across the plane.
- `Vector3 ReflectDirection(Vector3 direction)`
  - Reflects a direction across the plane.
