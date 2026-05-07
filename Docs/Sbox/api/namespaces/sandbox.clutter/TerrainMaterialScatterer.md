# Sandbox.Clutter.TerrainMaterialScatterer

Scatterer that selects assets based on the terrain material at the hit position.
Useful for placing different vegetation on different terrain textures (grass, dirt, rock, etc).

- **Kind:** class
- **Namespace:** `Sandbox.Clutter`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Clutter.Scatterer`

## Constructors

- `TerrainMaterialScatterer()`

## Properties

- `RangedFloat Scale`
  - Scale range for spawned objects.
- `System.Single Density`
  - Points per square meter (density).
- `System.Single HeightOffset`
  - Offset from ground surface.
- `System.Boolean AlignToNormal`
  - Align objects to surface normal.
- `System.Boolean RandomYaw`
  - Apply random rotation around vertical axis.
- `System.Collections.Generic.List<Sandbox.Clutter.TerrainMaterialMapping> Mappings`
  - Define which entries spawn on which terrain materials.
- `System.Boolean UseFallback`
  - Use random clutter entry if no material mapping matches or no terrain is present.

## Methods

### Instance methods

- `virtual System.Collections.Generic.List<Sandbox.Clutter.ClutterInstance> Generate(BBox bounds, Sandbox.Clutter.ClutterDefinition clutter, Sandbox.Scene scene)`
