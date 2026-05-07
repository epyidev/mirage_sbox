# Sandbox.AnimationBuilder

Provides ability to generate animations for a `Sandbox.Model` at runtime.
See `Sandbox.ModelBuilder.AddAnimation(System.String,System.Single)`

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.String Name`
  - The name of the animation.
- `System.Single FrameRate`
  - The frames per second of the animation.
- `System.Boolean Looping`
  - This animation loops.
- `System.Boolean Delta`
  - This animation "adds" to the base result.
- `System.Boolean DisableInterpolation`
  - This animation disables interpolation between frames.
- `System.Int32 FrameCount`
  - The number of frames in the animation.

## Methods

### Instance methods

- `Sandbox.AnimationBuilder WithName(System.String name)`
  - Sets the name of the animation.
- `Sandbox.AnimationBuilder WithFrameRate(System.Single frameRate)`
  - Sets the frames per second of the animation.
- `Sandbox.AnimationBuilder WithLooping(System.Boolean looping)`
  - Sets whether the animation loops.
- `Sandbox.AnimationBuilder WithDelta(System.Boolean delta)`
  - Sets whether the animation adds to the base result.
- `Sandbox.AnimationBuilder WithInterpolationDisabled(System.Boolean disableInterpolation)`
  - Sets whether interpolation between frames is disabled.
- `Sandbox.AnimationBuilder AddFrame(System.Span<Transform> boneTransforms)`
- `Sandbox.AnimationBuilder AddFrame(System.Collections.Generic.List<Transform> boneTransforms)`
