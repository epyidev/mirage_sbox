# Sandbox.Navigation.NavMeshPathStatus

- **Kind:** enum
- **Namespace:** `Sandbox.Navigation`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Enum`

## Values

- `StartNotFound` - Start location was not found on the navmesh.
- `TargetNotFound` - Target location was not found on the navmesh.
- `PathNotFound` - No path could be found.
- `Partial` - Path found, but does not reach the target.
The returned path will be to the closest location that can be reached.
- `Complete` - Path found from start to target.
