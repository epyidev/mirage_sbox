# Sandbox.ParticleSpriteRenderer

Renders particles as 2D sprites - can be static or animated

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.ParticleRenderer`

## Constructors

- `ParticleSpriteRenderer()`

## Properties

- `Sandbox.Sprite Sprite`
  - The sprite resource to render. This can be completely static or contain animation(s).
- `System.String StartingAnimationName`
  - The animation that this sprite should start playing when the scene starts.
- `System.Single PlaybackSpeed`
- `System.Single Scale`
  - The scale of the sprite when rendered.
- `System.Boolean Additive`
  - Whether or not the sprite should be rendered additively.
- `System.Boolean Shadows`
  - Whether or not the sprite should cast shadows in the scene.
- `System.Boolean Lighting`
  - Whether or not the sprite should be lit by the scene lighting.
- `System.Boolean Opaque`
  - Indicates whether the sprite is opaque, optimizing rendering by skipping sorting.
- `Sandbox.Rendering.FilterMode TextureFilter`
  - The texture filtering mode used when rendering the sprite. For pixelated sprites use `Sandbox.Rendering.FilterMode.Point`.
- `Sandbox.ParticleSpriteRenderer.BillboardAlignment Alignment`
  - Alignment mode for the sprite's billboard behavior.
- `Sandbox.ParticleSpriteRenderer.ParticleSortMode SortMode`
  - Sorting mode used for rendering particles.
- `System.Single DepthFeather`
  - Amount of feathering applied to the depth, softening its intersection with geometry.
- `System.Single FogStrength`
  - The strength of the fog effect applied to the sprite. This determines how much the sprite blends with any fog in the scene.
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
- `Sandbox.Sprite.Animation CurrentAnimation`
  - The animation that is currently being played. Returns null if no sprite is set or the sprite has no animations.
- `System.Boolean IsAnimated`
  - Whether or not the sprite is animated. This is true if the sprite has more than one animation or if the current animation has more than one frame.
- `System.Boolean IsSorted`
  - Interface property to determine if particles should be sorted
- `Vector2 Pivot`
  - The pivot point of the sprite, used for rotation and scaling. This is in normalized coordinates (0 to 1).
- `Sandbox.Texture Texture`
  - The texture being displayed from the sprite given the current frame/animation.
- `Sandbox.Texture RenderTexture`
  - Provides texture for rendering - implementation for IBatchedParticleSpriteRenderer
- `System.Int32 ComponentVersion`

## Methods

### Instance methods

- `System.Void SetAnimation(System.Int32 index)`
  - Set the animation by index (the first animation is index 0).
- `System.Void SetAnimation(System.String name)`
  - Set the animation by name.
