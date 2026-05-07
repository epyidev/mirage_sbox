# Cone

A tapered shape between two points with a radius at each end.
Supports cones and cylinders, with flat ends.

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`

## Constructors

- `Cone(Vector3 a, Vector3 b, System.Single ra, System.Single rb)`
  - A tapered shape between two points with a radius at each end.
Supports cones and cylinders, with flat ends.

## Properties

- `Vector3 RandomPointInside`
  - Get a random point inside.
- `Vector3 RandomPointOnEdge`
  - Get a random point on the surface.
- `BBox Bounds`
  - Bounding box that contains the shape.

## Fields

- `Vector3 CenterA`
  - Start point.
- `Vector3 CenterB`
  - End point.
- `System.Single RadiusA`
  - Radius at the start.
- `System.Single RadiusB`
  - Radius at the end.

## Methods

### Instance methods

- `System.Single GetEdgeDistance(Vector3 p)`
  - Distance from a point to the surface.
- `System.Boolean Contains(Vector3 p)`
  - Check if a point is inside.
