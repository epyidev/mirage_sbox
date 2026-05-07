# Sandbox.RenderTextureAsset

Asset that owns a GPU render target texture which can be shared across runtime systems.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.GameResource`

## Constructors

- `RenderTextureAsset()`

## Properties

- `Sandbox.Texture Texture`
- `Vector2Int Size`
  - Resolution of the render target in pixels.
- `Sandbox.ImageFormat Format`
  - Color format used when building the render target. Unsupported formats fall back to RGBA8888.
- `Color ClearColor`
  - Optional clear colour applied when the texture is (re)created.
