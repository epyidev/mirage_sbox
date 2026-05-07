# Namespace `Sandbox.Clutter`

11 types.

## Classes

- [`ClutterComponent`](./ClutterComponent.md) - Clutter scattering component supporting both infinite and volumes.
- [`ClutterDefinition`](./ClutterDefinition.md) - A weighted collection of Prefabs and Models for random selection during clutter placement.
- [`ClutterEntry`](./ClutterEntry.md) - Represents a single weighted entry in a `Sandbox.Clutter.ClutterDefinition`.
- [`ClutterGridSystem`](./ClutterGridSystem.md) - Game object system that manages clutter generation.
- [`ClutterInstance`](./ClutterInstance.md) - Represents a single clutter instance to be spawned.
- [`Scatterer`](./Scatterer.md) - Base class to override if you want to create custom scatterer logic.
- [`SimpleScatterer`](./SimpleScatterer.md)
- [`SlopeMapping`](./SlopeMapping.md) - Maps an clutter entry to a slope angle range.
- [`SlopeScatterer`](./SlopeScatterer.md) - Scatterer that filters and selects assets based on the slope angle of the surface.
- [`TerrainMaterialMapping`](./TerrainMaterialMapping.md) - Maps a terrain material to a list of clutter entries that can spawn on it.
- [`TerrainMaterialScatterer`](./TerrainMaterialScatterer.md) - Scatterer that selects assets based on the terrain material at the hit position.

## Structs

- [`ClutterInstance`](./ClutterInstance.md) - Represents a single clutter instance to be spawned.
