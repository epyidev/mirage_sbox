# Sandbox.SceneMap

Map geometry that can be rendered within a `Sandbox.SceneWorld`.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `SceneMap(Sandbox.SceneWorld sceneWorld, System.String map)`
  - Create a scene map within a scene world.

## Properties

- `Sandbox.SceneWorld World`
  - The scene world this map belongs to.
- `System.Boolean IsValid`
  - Is the map valid.
- `BBox Bounds`
  - Bounds of the map.
- `Vector3 WorldOrigin`
- `System.String MapName`
  - cs_assault
- `System.String MapFolder`
  - maps/davej/cs_assault

## Methods

### Static methods

- `static System.Threading.Tasks.Task<Sandbox.SceneMap> CreateAsync(Sandbox.SceneWorld sceneWorld, System.String map, System.Threading.CancellationToken cancelToken)`
  - Create scene map asynchronously for when large maps take time to load.

### Instance methods

- `System.Void Delete()`
  - Delete this scene map. You shouldn't access it anymore.
