# Sandbox.MapInstance

Allows you to load a map into the Scene. This can be either a vpk or a scene map.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `MapInstance()`

## Properties

- `System.String MapName`
- `System.Boolean UseMapFromLaunch`
- `System.Boolean EnableCollision`
- `System.Boolean IsLoaded`
  - True if the map is loaded
- `System.Action OnMapLoaded`
  - Called when the map has successfully loaded
- `System.Action OnMapUnloaded`
  - Called when the map has been unloaded
- `BBox Bounds`
  - Get the world bounds of the map
- `System.Boolean NoOrigin`
- `System.Int32 ComponentVersion`

## Methods

### Instance methods

- `virtual System.Void OnTagsChanged()`
- `virtual System.Threading.Tasks.Task OnLoad(Sandbox.LoadingContext context)`
- `System.Void UnloadMap()`
  - Unload the current map.
- `virtual System.Void OnUpdate()`
- `virtual System.Void OnCreateObject(Sandbox.GameObject go, Sandbox.MapLoader.ObjectEntry kv)`
  - Override this to add components to a map object.
Only called for map objects that are not implemented.
