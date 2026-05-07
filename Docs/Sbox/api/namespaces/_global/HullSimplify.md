# Sandbox.PhysicsBodyBuilder.HullSimplify

Settings for simplifying a hull shape.

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.PhysicsBodyBuilder`

## Fields

- `System.Single AngleTolerance`
  - Maximum allowed angle change between faces, in degrees.
- `System.Single DistanceTolerance`
  - Maximum distance a vertex can be moved during simplification.
- `System.Int32 MaxFaces`
  - Maximum number of faces allowed after simplification.
- `System.Int32 MaxEdges`
  - Maximum number of edges allowed after simplification.
- `System.Int32 MaxVerts`
  - Maximum number of vertices allowed after simplification.
- `Sandbox.PhysicsBodyBuilder.SimplifyMethod Method`
  - The simplification method to use.
