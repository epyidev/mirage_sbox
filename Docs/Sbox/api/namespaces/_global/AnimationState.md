# Sandbox.Sprite.AnimationState

Contains the state of a sprite instance's animation playback.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Sprite`

## Constructors

- `AnimationState()`

## Properties

- `System.Boolean JustFinished`
  - Returns true if the animation finished, looped, or ping-ponged after calling `Sandbox.Sprite.AnimationState.TryAdvanceFrame(Sandbox.Sprite.Animation,System.Single)`

## Fields

- `System.Int32 CurrentFrameIndex`
  - The current frame index in the animation.
- `System.Boolean IsPingPonging`
  - Whether or not the animation is currently ping-ponging. This is only relevant for animations that have `Sandbox.Sprite.LoopMode.PingPong`
- `System.Single TimeSinceLastFrame`
  - The time since the last frame was advanced.
- `System.Single PlaybackSpeed`
  - The speed at which the animation is playing back. A value of 1 means normal speed, 0.5 means half speed, and -1 means reverse playback.

## Methods

### Instance methods

- `System.Void ResetState()`
  - Reset the animation playback state to the beginning (first frame, no ping-pong, zero time-since).
- `System.Boolean TryAdvanceFrame(Sandbox.Sprite.Animation animation, System.Single deltaTime)`
  - Try to advance the frame of a given animation with a given delta time. Returns false if the frame did not advance.
