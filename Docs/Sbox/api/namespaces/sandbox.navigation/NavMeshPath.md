# Sandbox.Navigation.NavMeshPath

Contains the result of a pathfinding operation.

- **Kind:** struct
- **Namespace:** `Sandbox.Navigation`
- **Assembly:** `Sandbox.Engine`

## Properties

- `Sandbox.Navigation.NavMeshPathStatus Status`
  - The outcome of the path calculation.
- `System.Boolean IsValid`
  - True if a path was found.
- `System.Collections.Generic.IReadOnlyList<Sandbox.Navigation.NavMeshPathPoint> Points`
  - Points along the path.
