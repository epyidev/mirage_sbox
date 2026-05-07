# Sandbox.DecalDefinition

A decal which can be applied to objects and surfaces.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.GameResource`

## Constructors

- `DecalDefinition()`

## Properties

- `System.Collections.Generic.List<Sandbox.DecalDefinition.DecalEntry> Decals`
- `Sandbox.Texture ColorTexture`
  - The color map to use for the decal including transparency which masks the decal.
This must be set for other textures to use the decal mask.
- `Sandbox.Texture NormalTexture`
  - The normal texture map to use for the decal.
- `Sandbox.Texture RoughMetalOcclusionTexture`
  - The Roughness/Metal/Ambient Occlusion texture map to use for the decal, stored in the respective RGB channels.
- `Sandbox.Texture EmissiveTexture`
  - The emissive texture map to use for the decal.
- `System.Single EmissionEnergy`
  - Strength of the emission effect.
- `Sandbox.Texture HeightTexture`
  - The height texture to use for parallax mapping.
- `System.Single ParallaxStrength`
  - Strength of the parallax effect.
- `Color Tint`
  - Tints the color of the decal's albedo and can be used to adjust the overall opacity of the decal.
- `System.Single ColorMix`
  - Controls the opacity of the decal's color texture without reducing the impact of the normal or rmo texture.
Set to 0 to create a normal/rmo only decal masked by the color textures alpha.
- `System.Single Width`
  - Width of the decal.
- `System.Single Height`
  - Height of the decal.
- `Sandbox.Rendering.FilterMode FilterMode`
  - How the texture gets filtered.
