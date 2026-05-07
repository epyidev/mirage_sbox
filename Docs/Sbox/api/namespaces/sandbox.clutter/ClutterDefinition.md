# Sandbox.Clutter.ClutterDefinition

A weighted collection of Prefabs and Models for random selection during clutter placement.

- **Kind:** class
- **Namespace:** `Sandbox.Clutter`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.GameResource`

## Constructors

- `ClutterDefinition()`

## Properties

- `System.Collections.Generic.List<Sandbox.Clutter.ClutterEntry> Entries`
  - List of weighted entries
- `System.Boolean IsEmpty`
- `Sandbox.Clutter.ClutterDefinition.TileSizeOption TileSizeEnum`
  - Size of each tile in world units for infinite streaming mode.
- `System.Single TileSize`
  - Gets the tile size as a float value.
- `System.Int32 TileRadius`
  - Number of tiles to generate around the camera in each direction.
Higher values = more visible range but more memory usage.
- `Sandbox.AnyOfType<Sandbox.Clutter.Scatterer> Scatterer`

## Methods

### Instance methods

- `virtual Sandbox.Bitmap CreateAssetTypeIcon(System.Int32 width, System.Int32 height)`
