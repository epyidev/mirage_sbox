# Sandbox.Terrain.TerrainMaterialInfo

Information about terrain materials at a specific position

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Terrain`

## Properties

- `System.Int32 BaseTextureId`
  - The base (primary) material index at this position
- `System.Int32 OverlayTextureId`
  - The overlay (secondary) material index at this position
- `System.Single BlendFactor`
  - Blend factor between base and overlay (0-1, where 0 = full base, 1 = full overlay)
- `System.Boolean IsHole`
  - Whether this position is marked as a hole
- `Sandbox.TerrainMaterial BaseMaterial`
  - The base terrain material resource (if available)
- `Sandbox.TerrainMaterial OverlayMaterial`
  - The overlay terrain material resource (if available)

## Methods

### Instance methods

- `Sandbox.TerrainMaterial GetDominantMaterial()`
  - Gets the dominant material at this position based on blend factor
- `System.Int32 GetDominantMaterialIndex()`
  - Gets the dominant material index at this position based on blend factor
