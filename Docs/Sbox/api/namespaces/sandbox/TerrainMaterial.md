# Sandbox.TerrainMaterial

Description of a Terrain Material.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.GameResource`

## Constructors

- `TerrainMaterial()`

## Properties

- `System.String AlbedoImage`
- `System.String RoughnessImage`
- `System.String NormalImage`
- `System.String HeightImage`
- `System.String AOImage`
- `Sandbox.Texture BCRTexture`
- `Sandbox.Texture NHOTexture`
- `System.Single UVScale`
- `System.Single Metalness`
- `System.Single NormalStrength`
- `System.Single HeightBlendStrength`
- `System.Boolean HasHeightTexture`
- `System.Single DisplacementScale`
- `System.Boolean NoTiling`
- `Sandbox.TerrainFlags Flags`
- `Sandbox.Surface Surface`

## Methods

### Instance methods

- `virtual System.Void PostLoad()`
- `virtual System.Void PostReload()`
- `virtual Sandbox.Bitmap CreateAssetTypeIcon(System.Int32 width, System.Int32 height)`
