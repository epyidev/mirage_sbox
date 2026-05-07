# Sandbox.Map

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `Map(System.String mapName, Sandbox.MapLoader loader)`

## Properties

- `Sandbox.PhysicsGroup PhysicsGroup`
  - The world physics objects
- `Sandbox.SceneMap SceneMap`
  - The world geometry;

## Methods

### Static methods

- `static System.Threading.Tasks.Task<Sandbox.Map> CreateAsync(System.String mapName, Sandbox.MapLoader loader, System.Threading.CancellationToken cancelToken)`

### Instance methods

- `System.Void Delete()`
