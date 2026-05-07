# Sandbox.TerrainStorage

Stores heightmaps, control maps and materials.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.GameResource`

## Constructors

- `TerrainStorage()`

## Properties

- `System.UInt16[] HeightMap`
- `System.UInt32[] ControlMap`
- `System.Int32 Resolution`
- `System.Single TerrainSize`
  - Uniform world size of the width and length of the terrain.
- `System.Single TerrainHeight`
  - World size of the maximum height of the terrain.
- `System.Collections.Generic.List<Sandbox.TerrainMaterial> Materials`
- `Sandbox.TerrainStorage.TerrainMaterialSettings MaterialSettings`
- `System.Int32 ResourceVersion`

## Methods

### Instance methods

- `System.Void SetResolution(System.Int32 resolution)`
