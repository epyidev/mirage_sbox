# Sandbox.SpriteRenderer

Renders a sprite in the world

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Renderer`

## Constructors

- `SpriteRenderer()`

## Properties

- `Sandbox.Sprite Sprite`
  - The sprite resource to render. This can be completely static or contain animation(s).
- `System.String StartingAnimationName`
  - The animation that this sprite should start playing when the scene starts.
- `System.Single PlaybackSpeed`
  - The playback speed of the animation. 0 is paused, and negative values will play the animation in reverse.
- `Vector2 Size`
  - The width and height of the sprite in world units.
- `Color Color`
  - The color of the sprite. This is multiplied with the texture color.
- `Color OverlayColor`
- `System.Boolean Additive`
  - Whether or not the sprite should be rendered additively.
- `System.Boolean Shadows`
  - Whether or not the sprite should cast shadows.
- `System.Boolean Opaque`
  - Whether or not the sprite should be rendered opaque. If true, any semi-transparent pixels will be dithered.
- `System.Single AlphaCutoff`
  - Alpha threshold for discarding pixels. Pixels with alpha below this value will be discarded. 
Only used when Opaque is true. Range: 0.0 (transparent) to 1.0 (opaque). Default is 0.5.
- `System.Boolean Lighting`
  - Whether or not the sprite should be lit by the scene's lighting system. Otherwise it will be unlit/fullbright.
- `System.Single DepthFeather`
  - Amount of feathering applied to the depth, softening its intersection with geometry.
- `System.Single FogStrength`
  - The strength of the fog effect applied to the sprite. This determines how much the sprite blends with any fog in the scene.
- `System.Boolean FlipHorizontal`
  - Whether or not the sprite should be flipped horizontally.
- `System.Boolean FlipVertical`
  - Whether or not the sprite should be flipped vertically.
- `Sandbox.Rendering.FilterMode TextureFilter`
  - The texture filtering mode used when rendering the sprite. For pixelated sprites, use `Sandbox.UI.ImageRendering.Point`.
- `Sandbox.SpriteRenderer.BillboardMode Billboard`
  - Alignment mode for the sprite's billboard behavior.
- `System.Boolean IsSorted`
  - Whether or not the sprite should be sorted by depth. If the sprite is opaque, this can be turned off for a performance boost if not needed.
- `System.Action<System.String> OnAnimationStart`
  - This action is invoked when an animation starts playing. The string parameter is the name of the animation that started.
- `System.Action<System.String> OnAnimationEnd`
  - This action is invoked when an animation finishes playing or has looped. The string parameter is the name of the animation.
- `System.Action<System.String> OnBroadcastMessage`
  - This action is invoked when advancing to a new frame that has broadcast messages. The string parameter is the message being broadcast.
- `Sandbox.Sprite.Animation CurrentAnimation`
  - The animation that is currently being played. Returns null if no sprite is set or the sprite has no animations.
- `System.Int32 CurrentFrameIndex`
  - The index of the current frame being displayed. This will change over time if the sprite is animated, and can be set to go to a specific frame even during playback.
- `System.Boolean IsAnimated`
  - Whether or not the sprite is animated. This is true if the sprite has more than one animation.
- `Sandbox.Texture Texture`
  - The texture of the current frame being displayed. Returns a transparent texture when no valid frame is available.
- `System.Int32 ComponentVersion`

## Methods

### Instance methods

- `System.Void PlayAnimation(System.Int32 index)`
  - Play an animation by index (the first animation is index 0).
- `System.Void PlayAnimation(System.String name)`
  - Play an animation by name.
