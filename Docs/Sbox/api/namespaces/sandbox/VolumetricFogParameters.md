# Sandbox.VolumetricFogParameters

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `VolumetricFogParameters()`

## Properties

- `System.Boolean Enabled`
  - Indicates whether the fog system is enabled.
- `System.Single Anisotropy`
  - Level of anisotropy.
- `System.Single Scattering`
  - Scattering value.
- `System.Single DrawDistance`
  - Draw distance.
- `System.Single FadeInStart`
  - Start distance where fading begins.
- `System.Single FadeInEnd`
  - End distance where fading concludes.
- `System.Single IndirectStrength`
  - Strength of indirect illumination.
- `Sandbox.Texture BakedIndirectTexture`
  - Provides indirect lighting from a baked volume texture.
This gets compiled with your map and is provided by an env_volumetric_controller.
