# Sandbox.Sprite

Represents a sprite resource that can be static or animated. Sprites are rendererd using the SpriteRenderer component.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.GameResource`

## Constructors

- `Sprite()`

## Properties

- `System.Collections.Generic.List<Sandbox.Sprite.Animation> Animations`
  - A list of animations that can be played. Some animations can consist of multiple frames.
If a sprite is static, it will only contain a single default animation.

## Methods

### Static methods

- `static Sandbox.Sprite FromTexture(Sandbox.Texture texture)`
  - Returns a sprite with a single frame animation using the provided texture.
  - `texture`: The texture to be used
- `static Sandbox.Sprite FromTextures(System.Collections.Generic.IEnumerable<Sandbox.Texture> textures, System.Single frameRate)`

### Instance methods

- `System.Int32 GetAnimationIndex(System.String name)`
  - Get the index of an animation by its name. Returns -1 if not found.
  - `name`: The name of the animation
- `Sandbox.Sprite.Animation GetAnimation(System.Int32 index)`
  - Get an animation by its index. Returns null if out of bounds.
  - `index`: The index of the animation
- `Sandbox.Sprite.Animation GetAnimation(System.String name)`
  - Get an animation by its name. Returns null if not found.
  - `name`: The name of the animation
