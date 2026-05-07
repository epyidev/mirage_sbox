# Sandbox.CubemapFogController

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `CubemapFogController()`

## Properties

- `System.Single LodBias`
  - Adjust how quickly the cubemap blurs out at closer distances. A value of 0.0 always uses the lowest resolution MIP over the entire range, while a value of 1.0 uses the highest.
- `System.Single StartDistance`
  - The distance from the player at which the fog will start to fade in.
- `System.Single EndDistance`
  - The distance from the player at which the fog will be at full strength.
- `System.Single FalloffExponent`
  - Exponent for distance falloff. For example, 2.0 is proportional to square of distance.
- `System.Single HeightWidth`
  - The distance between the start of the height fog and where it is fully opaque. Setting this to 0 will disable height based blending.
- `System.Single HeightStart`
  - The absolute height in the map at which the height fog will start to fade in.
- `System.Single HeightExponent`
  - Exponent for height falloff. For example, 2.0 is proportional to square of distance.
- `System.Boolean Enabled`
  - Is this cubemap fog active?
- `Sandbox.Texture Texture`
  - Cubemap texture to use for the fog.
- `Transform Transform`
  - Location of the fog.
- `Color Tint`
  - Tint of the fog.
