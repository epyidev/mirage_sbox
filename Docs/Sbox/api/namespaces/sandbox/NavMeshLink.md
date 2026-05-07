# Sandbox.NavMeshLink

NavigationLinks connect navigation mesh polygons for pathfinding and enable shortcuts like ladders, jumps, or teleports.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `NavMeshLink()`

## Properties

- `Vector3 LocalStartPosition`
  - Start position relative to the game object's position.
- `Vector3 LocalEndPosition`
  - End position relative to the game object's position.
- `System.Nullable<Vector3> WorldStartPositionOnNavmesh`
  - Start position in world space snapped to the navmesh.
- `System.Nullable<Vector3> WorldEndPositionOnNavmesh`
  - End position in world space snapped to the navmesh.
- `Sandbox.Engine.Resources.NavMeshAreaDefinition Area`
  - The NavMesh area definition to apply to this link.
- `System.Action<Sandbox.NavMeshAgent> LinkEntered`
  - Emitted when an agent enters the link.
- `System.Action<Sandbox.NavMeshAgent> LinkExited`
  - Emitted when an agent exits the link.
- `Vector3 WorldStartPosition`
  - Start position in world space.
- `Vector3 WorldEndPosition`
  - End position in world space.

## Fields

- `System.Boolean IsBiDirectional`
  - Whether this link can be traverse bi-directional or only start towards end.
- `System.Single ConnectionRadius`
  - Radius that will be searched at the start and end positions for a connection to the navmesh.

## Methods

### Instance methods

- `virtual System.Void OnLinkEntered(Sandbox.NavMeshAgent agent)`
  - Called when an agent enters the link.
- `virtual System.Void OnLinkExited(Sandbox.NavMeshAgent agent)`
  - Called when an agent exits the link.
- `virtual System.Void DrawGizmos()`
