# Sandbox.Rendering.GradientFogSetup

Setup for defining gradient fog in a view

- **Kind:** struct
- **Namespace:** `Sandbox.Rendering`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Boolean Enabled`
  - Whether the fog is enabled.
- `System.Single StartDistance`
  - Start distance of the fog.
- `System.Single EndDistance`
  - End distance of the fog.
- `System.Single StartHeight`
  - The starting height of the gradient fog.
- `System.Single EndHeight`
  - The ending height of the gradient fog.
- `System.Single MaximumOpacity`
  - The maximum opacity of the gradient fog.
- `Color Color`
  - The color of the gradient fog.
- `System.Single DistanceFalloffExponent`
  - The exponent controlling the distance-based falloff of the fog.
- `System.Single VerticalFalloffExponent`
  - The exponent controlling the vertical falloff of the fog.

## Methods

### Instance methods

- `Sandbox.Rendering.GradientFogSetup LerpTo(Sandbox.Rendering.GradientFogSetup desired, System.Single delta, System.Boolean clamp)`
  - Lerp this GradientFogSetup to a another, allowing transition states.
