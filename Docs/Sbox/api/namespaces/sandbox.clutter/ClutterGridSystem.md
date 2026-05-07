# Sandbox.Clutter.ClutterGridSystem

Game object system that manages clutter generation.
Handles infinite streaming layers and executes generation jobs.

- **Kind:** sealed class
- **Namespace:** `Sandbox.Clutter`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.GameObjectSystem`

## Constructors

- `ClutterGridSystem(Sandbox.Scene scene)`

## Properties

- `Sandbox.Clutter.ClutterGridSystem.ClutterStorage Storage`
  - Storage for painted clutter model instances.
Serialized with the scene - this is the source of truth for painted clutter.

## Methods

### Instance methods

- `System.Void ClearComponent(Sandbox.Clutter.ClutterComponent component)`
  - Clears all tiles for a specific component.
- `System.Void InvalidateTileAt(Sandbox.Clutter.ClutterComponent component, Vector3 worldPosition)`
  - Invalidates the tile at the given world position for a component, causing it to regenerate.
- `System.Void InvalidateTilesInBounds(Sandbox.Clutter.ClutterComponent component, BBox bounds)`
  - Invalidates all tiles within the given bounds for a component, causing them to regenerate.
- `System.Void InvalidateTilesInBounds(BBox bounds)`
  - Invalidates all tiles within the given bounds for ALL infinite clutter components.
Useful for terrain painting where you want to refresh all clutter layers.
- `System.Void Paint(Sandbox.Clutter.ClutterEntry entry, Vector3 pos, Rotation rot, System.Single scale)`
  - Paint instance. Rebuilds on next frame update.
Models are batched, Prefabs become GameObjects.
- `System.Void Erase(Vector3 pos, System.Single radius)`
  - Erase instances. Rebuilds on next frame update.
Erases both model batches and prefab GameObjects.
- `System.Void ClearAllPainted()`
  - Clears all painted clutter (both model instances from storage and prefab GameObjects).
Does not affect clutter owned by ClutterComponent volumes.
- `System.Void Flush()`
  - Flush painted changes and rebuild visual batches immediately.
