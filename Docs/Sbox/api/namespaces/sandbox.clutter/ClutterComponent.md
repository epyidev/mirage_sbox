# Sandbox.Clutter.ClutterComponent

Clutter scattering component supporting both infinite and volumes.

- **Kind:** sealed class
- **Namespace:** `Sandbox.Clutter`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `ClutterComponent()`

## Properties

- `Sandbox.Clutter.ClutterDefinition Clutter`
  - The clutter containing objects to scatter and scatter settings.
- `System.Int32 Seed`
  - Seed for deterministic generation. Change to get different variations.
- `Sandbox.Clutter.ClutterComponent.ClutterMode Mode`
  - Clutter generation mode - Volume or Infinite streaming.
- `System.Boolean Infinite`
  - Returns true if in infinite streaming mode.
- `BBox Bounds`
- `Sandbox.Clutter.ClutterGridSystem.ClutterStorage Storage`
  - Storage for volume model instances. Serialized with component.

## Methods

### Instance methods

- `System.Void ClearInfinite()`
  - Clears all infinite mode tiles for this component.
- `System.Void InvalidateTileAt(Vector3 worldPosition)`
  - Invalidates the tile at the given world position, causing it to regenerate.
- `System.Void InvalidateTilesInBounds(BBox bounds)`
  - Invalidates all tiles within the given bounds, causing them to regenerate.
- `System.Void Generate()`
- `System.Void Clear()`
