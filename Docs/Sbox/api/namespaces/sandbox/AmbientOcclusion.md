# Sandbox.AmbientOcclusion

Adds an approximation of ambient occlusion using Screen Space Ambient Occlusion (SSAO).
It darkens areas where ambient light is generally occluded from such as corners, crevices
and surfaces that are close to each other.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.BasePostProcess<T>`

## Constructors

- `AmbientOcclusion()`

## Properties

- `System.Int32 ComponentVersion`
- `System.Single Intensity`
  - The intensity of the darkening effect. Has no impact on performance.
- `System.Int32 Radius`
  - Maximum distance of samples from pixel when determining its occlusion, in world units.
- `System.Single FalloffRange`
  - Gently reduce sample impact as it gets out of the effect's radius bounds
- `Sandbox.AmbientOcclusion.DenoiseModes DenoiseMode`
  - How we should denoise the effect
- `System.Single ThinCompensation`
  - Slightly reduce impact of samples further back to counter the bias from depth-based (incomplete) input scene geometry data
- `Sandbox.AmbientOcclusion.SampleQuality Quality`

## Methods

### Instance methods

- `virtual System.Void Render()`
