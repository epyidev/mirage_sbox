# Capsule

A capsule object, defined by 2 points and a radius. A capsule is a cylinder with round ends (inset half spheres on each end).

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`

## Constructors

- `Capsule(Vector3 a, Vector3 b, System.Single r)`

## Properties

- `Vector3 RandomPointInside`
  - Returns a random point within this capsule.
- `Vector3 RandomPointOnEdge`
  - Returns a random point on the edge of this capsule.
- `System.Single Volume`
  - Gets the volume of the capsule in cubic units.
- `BBox Bounds`
  - Gets the Bounding Box of the capsule.

## Fields

- `Vector3 CenterA`
  - Position of point A.
- `Vector3 CenterB`
  - Position of point B.
- `System.Single Radius`
  - Radius of a capsule.

## Methods

### Static methods

- `static Capsule FromHeightAndRadius(System.Single height, System.Single radius)`
  - Creates a capsule where Point A is radius units above the ground and Point B is height minus radius units above the ground.

### Instance methods

- `System.Single GetEdgeDistance(Vector3 localPos)`
  - Calculates the distance from a given point to the edge of the capsule.
  - `localPos`: Position in the same coordinate space as the capsule
- `System.Boolean Contains(Vector3 point)`
  - Determines if the capsule contains the specified point.
