# Sandbox.Sphere

Represents a sphere.

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Constructors

- `Sphere(Vector3 center, System.Single radius)`

## Properties

- `static Sandbox.Sphere Unit`
  - A sphere centered at the origin, with radius 1.
- `System.Single Volume`
  - Volume of this sphere
- `Vector3 RandomPointInside`
  - Returns a random point within this sphere.
- `Vector3 RandomPointOnEdge`
  - Returns a random point on the edge of this sphere.

## Fields

- `Vector3 Center`
  - Center of the sphere.
- `System.Single Radius`
  - Radius of the sphere.

## Methods

### Instance methods

- `System.Boolean Trace(Ray ray, System.Single maxDistance, System.Single distance)`
  - Performs an intersection test between this sphere and given ray.
- `System.Boolean Trace(Ray ray, System.Single maxDistance)`
  - Performs an intersection test between this sphere and given ray.
- `System.Boolean Contains(Vector3 value)`
  - Returns true if sphere contains point. False if the point falls outside the sphere.
- `System.Single GetVolume()`
  - Get the volume of this sphere
- `System.Single GetEdgeDistance(Vector3 localPos)`
  - Calculates the shortest distance from the specified local position to the nearest edge of the object.
