# Sandbox.Sprite.Animation

Contains one or multiple frames that can be played in sequence.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Sprite`

## Constructors

- `Animation()`

## Properties

- `System.String Name`
  - The name of the animation. Allows you to play specific animations by name.
- `System.Single FrameRate`
  - The speed of the animation in frames per second.
- `Vector2 Origin`
  - The point at which the rendered sprite is anchored from. This means scaling/rotating a sprite will do so around the origin.
- `Sandbox.Sprite.LoopMode LoopMode`
  - The loop mode of the animation. This determines what should happen when the animation reaches the final frame in playback.
- `System.Collections.Generic.List<Sandbox.Sprite.Frame> Frames`
  - A list of frames that make up the animation. Each frame is a texture that will be displayed in sequence.
- `System.Boolean IsAnimated`
  - True if we have more than one frame
