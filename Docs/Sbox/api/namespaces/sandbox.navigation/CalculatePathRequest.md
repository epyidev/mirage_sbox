# Sandbox.Navigation.CalculatePathRequest

Defines the input for a pathfinding request on the navmesh.

- **Kind:** struct
- **Namespace:** `Sandbox.Navigation`
- **Assembly:** `Sandbox.Engine`

## Fields

- `Vector3 Start`
  - Start position of the path, should be close to the navmesh.
- `Vector3 Target`
  - Target/End position of the path, should be close to the navmesh.
- `Sandbox.NavMeshAgent Agent`
  - Optional agent whose configuration is used for path calculation.
