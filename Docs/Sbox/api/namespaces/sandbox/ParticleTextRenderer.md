# Sandbox.ParticleTextRenderer

Renders particles as 2D sprites

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.ParticleRenderer`

## Constructors

- `ParticleTextRenderer()`

## Properties

- `Sandbox.TextRendering.Scope Text`
- `Vector2 Pivot`
- `System.Single Scale`
- `System.Single DepthFeather`
- `System.Single FogStrength`
- `System.Boolean Additive`
- `System.Boolean Shadows`
- `System.Boolean Lighting`
- `System.Boolean Opaque`
  - Indicates whether the sprite is opaque, optimizing rendering by skipping sorting.
- `Sandbox.Rendering.FilterMode TextureFilter`
- `System.Boolean FaceVelocity`
  - Aligns the sprite to face its velocity direction.
- `System.Single RotationOffset`
  - Offset applied to the rotation when facing velocity.
- `System.Boolean MotionBlur`
  - Enables motion blur effects for the sprite.
- `System.Boolean LeadingTrail`
  - Determines whether the motion blur effect includes a leading trail.
- `System.Single BlurAmount`
  - Amount of blur applied to the sprite during motion blur.
- `System.Single BlurSpacing`
  - Spacing between blur samples in the motion blur effect.
- `System.Single BlurOpacity`
  - Opacity of the blur effect applied to the sprite.
- `Sandbox.ParticleSpriteRenderer.BillboardAlignment Alignment`
  - Alignment mode for the sprite's billboard behavior.
- `Sandbox.ParticleTextRenderer.ParticleSortMode SortMode`
  - Sorting mode used for rendering particles.
- `System.Boolean IsSorted`
  - Interface property to determine if particles should be sorted
- `Sandbox.Texture RenderTexture`
  - Provides texture for rendering the sprite
