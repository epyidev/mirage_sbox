# Sandbox.SoundscapeTrigger

Plays a soundscape when the listener enters the trigger area.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `SoundscapeTrigger()`

## Properties

- `Sandbox.SoundscapeTrigger.TriggerType Type`
  - Determines when/where the soundscape can be heard.
- `Sandbox.Soundscape Soundscape`
- `Sandbox.Audio.MixerHandle TargetMixer`
  - The mixer that the soundscape will play on.
- `System.Boolean StayActiveOnExit`
  - When true the soundscape will keep playing after exiting the area, and will
only stop playing once another soundscape takes over.
- `System.Single Volume`
- `System.Single Radius`
  - The radius of the Soundscape when `Sandbox.SoundscapeTrigger.Type` is set to `Sandbox.SoundscapeTrigger.TriggerType.Sphere`.
- `Vector3 BoxSize`
  - The size of the Soundscape when `Sandbox.SoundscapeTrigger.Type` is set to `Sandbox.SoundscapeTrigger.TriggerType.Box`.
- `System.Boolean Playing`

## Methods

### Instance methods

- `virtual System.Void DrawGizmos()`
- `virtual System.Void OnUpdate()`
- `virtual System.Void OnDisabled()`
- `virtual System.Void OnDestroy()`
- `System.Boolean TestListenerPosition(Vector3 position)`
  - Return true if they should hear this soundscape when in this position
