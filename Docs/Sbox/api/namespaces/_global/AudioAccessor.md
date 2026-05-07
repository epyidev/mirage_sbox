# Sandbox.VideoPlayer.AudioAccessor

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.VideoPlayer`

## Properties

- `System.Boolean ListenLocal`
  - Place the listener at 0,0,0 facing 1,0,0.
- `Vector3 Position`
  - Position of the sound.
- `Sandbox.Audio.Mixer TargetMixer`
  - Which mixer do we want to write to
- `System.Single Volume`
  - Volume of the sound.
- `System.Boolean LipSync`
  - Enables lipsync processing.
- `System.Single Distance`
- `Sandbox.Curve Falloff`
- `System.Collections.Generic.IReadOnlyList<System.Single> Visemes`
  - A list of 15 lipsync viseme weights. Requires `Sandbox.VideoPlayer.AudioAccessor.LipSync` to be enabled.
