# Sandbox.Navigation.NavMesh

Navigation Mesh - allowing AI to navigate a world

- **Kind:** sealed class
- **Namespace:** `Sandbox.Navigation`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Boolean IsEnabled`
  - Determines wether the navigation mesh is enabled and should be generated
- `System.Boolean IsGenerating`
  - The navigation mesh is generating
- `System.Boolean IsDirty`
  - The navigation mesh is dirty and needs a complete rebuild
- `System.Boolean IncludeStaticBodies`
  - Should the generator include static bodies
- `System.Boolean IncludeKeyframedBodies`
  - Should the generator include keyframed bodies
- `Sandbox.TagSet ExcludedBodies`
  - Don't include these bodies in the generation
- `Sandbox.TagSet IncludedBodies`
  - If any, we'll only include bodies with this tag
- `System.Boolean DeferGeneration`
  - Skip tile generation during scene load. Tiles can then be generated on demand
via `Sandbox.Navigation.NavMesh.GenerateTile(Sandbox.PhysicsWorld,Vector3)`, `Sandbox.Navigation.NavMesh.RequestTileGeneration(Vector3)`, etc.
- `System.Boolean CustomBounds`
  - By Default , the navmesh will calculate bounds based on the world geometry, but if you want to override that, you can set custom bounds here.
- `BBox Bounds`
  - The bounds to generate the navmesh within.
Won't take effect until regenerated or reloaded.
- `System.Boolean EditorAutoUpdate`
  - Constantly update the navigation mesh in the editor
- `System.Boolean DrawMesh`
  - Draw the navigation mesh in the editor
- `System.Single AgentHeight`
  - Height of the agent
- `System.Single AgentRadius`
  - The radius of the agent. This will change how much gap is left on the edges of surfaces, so they don't clip into walls.
- `System.Single AgentStepSize`
  - The maximum height an agent can climb (step)
- `System.Single AgentMaxSlope`
  - The maximum slope an agent can walk up (in degrees)

## Methods

### Static methods

- `static System.Void BakeNavMesh()`

### Instance methods

- `virtual System.Void Dispose()`
- `System.Void SetDirty()`
  - Set the navgiation a dirty, so it will rebuild over the next few frames.
If you need an immediate rebuild, call `Sandbox.Navigation.NavMesh.Generate(Sandbox.PhysicsWorld)` instead.
- `System.Threading.Tasks.Task<System.Boolean> Generate(Sandbox.PhysicsWorld world)`
- `System.Threading.Tasks.Task GenerateTile(Sandbox.PhysicsWorld world, Vector3 worldPosition)`
  - Generates or regenerates the navmesh tile at the given world position.
This function is thread safe but can only be called from the main thread.
- `System.Threading.Tasks.Task GenerateTiles(Sandbox.PhysicsWorld world, BBox bounds)`
  - Generates or regenerates the navmesh tiles overlapping with the given bounds.
This function is thread safe but can only be called from the main thread.
- `System.Void UnloadTile(Vector3 worldPosition)`
  - Removes the navmesh tile at the given world position.
- `System.Void UnloadTiles(BBox bounds)`
  - Removes all navmesh tiles overlapping with the given bounds.
- `System.Void RequestTileGeneration(Vector3 worldPosition)`
  - Queues the navmesh tile at the given world position for incremental generation
over subsequent frames. Fire-and-forget alternative to `Sandbox.Navigation.NavMesh.GenerateTile(Sandbox.PhysicsWorld,Vector3)`.
- `System.Void RequestTilesGeneration(BBox bounds)`
  - Queues all navmesh tiles overlapping with the given bounds for incremental generation
over subsequent frames. Fire-and-forget alternative to `Sandbox.Navigation.NavMesh.GenerateTiles(Sandbox.PhysicsWorld,BBox)`.
- `System.Collections.Generic.List<Vector3> GetSimplePath(Vector3 from, Vector3 to)`
- `Sandbox.Navigation.NavMeshPath CalculatePath(Sandbox.Navigation.CalculatePathRequest request)`
  - Computes a navigation path between the specified start and target positions on the navmesh.
Uses the same pathfinding algorithm as `Sandbox.NavMeshAgent`, taking agent configuration into account if provided.
The result is suitable for direct use with `Sandbox.NavMeshAgent.SetPath(Sandbox.Navigation.NavMeshPath)`.
If a complete path cannot be found, the result may indicate an incomplete or failed path.
- `System.Nullable<Vector3> GetRandomPoint()`
- `System.Nullable<Vector3> GetRandomPoint(BBox box)`
  - Get a random point on the navmesh, within the bounding box. 
This will return null if it can't find a point on the navmesh in a few tries. Returning false doesn't mean it's impossible, our algorithm here isn't the best.
- `System.Nullable<Vector3> GetRandomPoint(Vector3 position, System.Single radius)`
  - Get a random point on the navmesh, within the sphere.
This will return null if it can't find a point on the navmesh in a few tries. Returning false doesn't mean it's impossible, our algorithm here isn't the best.
- `System.Nullable<Vector3> GetClosestPoint(BBox box)`
- `System.Nullable<Vector3> GetClosestPoint(Vector3 position, System.Single radius)`
- `System.Nullable<Vector3> GetClosestEdge(BBox box)`
- `System.Nullable<Vector3> GetClosestEdge(Vector3 position, System.Single radius)`
