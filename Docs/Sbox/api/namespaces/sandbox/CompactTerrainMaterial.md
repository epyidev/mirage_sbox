# Sandbox.CompactTerrainMaterial

Compact terrain material encoding with base/overlay texture blending.
Packed format (32-bit uint)

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `CompactTerrainMaterial(System.UInt32 packed)`
- `CompactTerrainMaterial(System.Byte baseTextureId, System.Byte overlayTextureId, System.Byte blendFactor, System.Boolean isHole)`

## Properties

- `System.Byte BaseTextureId`
  - Base texture ID (0-31)
- `System.Byte OverlayTextureId`
  - Overlay texture ID (0-31)
- `System.Byte BlendFactor`
  - Blend factor between base and overlay (0-255).
- `System.Boolean IsHole`
  - Whether this pixel is marked as a hole
- `System.UInt32 Packed`
  - Raw packed value
