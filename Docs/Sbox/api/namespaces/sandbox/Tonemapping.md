# Sandbox.Tonemapping

Applies a tonemapping effect to the camera.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.BasePostProcess<T>`

## Constructors

- `Tonemapping()`

## Properties

- `Sandbox.Tonemapping.TonemappingMode Mode`
  - Which tonemapping algorithm to use for color grading.
- `Sandbox.Tonemapping.ExposureColorSpaceEnum ExposureMethod`
- `System.Boolean AutoExposureEnabled`
- `System.Single MinimumExposure`
- `System.Single MaximumExposure`
- `System.Single ExposureCompensation`
- `System.Single Rate`
- `System.Int32 ComponentVersion`

## Methods

### Instance methods

- `virtual System.Void Render()`
