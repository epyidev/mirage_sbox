# Sandbox.Voice

Records and transmits voice/microphone input to other players.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `Voice()`

## Properties

- `System.Single Volume`
- `Sandbox.Voice.ActivateMode Mode`
- `System.String PushToTalkInput`
- `System.Boolean WorldspacePlayback`
- `System.Boolean Loopback`
- `System.Boolean LipSync`
- `Sandbox.SkinnedModelRenderer Renderer`
- `System.Single MorphScale`
- `System.Single MorphSmoothTime`
- `Sandbox.RealTimeSince LastPlayed`
  - How long has it been since this sound played?
- `System.Single LaughterScore`
  - Laughter score for the current audio frame, between 0 and 1
- `Sandbox.Audio.MixerHandle VoiceMixer`
- `Sandbox.Audio.Mixer TargetMixer`
- `System.Single Distance`
- `Sandbox.Curve Falloff`
- `System.Collections.Generic.IReadOnlyList<System.Single> Visemes`
  - A list of 15 lipsync viseme weights. Requires `Sandbox.Voice.LipSync` to be enabled.
- `System.Boolean IsRecording`
- `System.Boolean IsListening`
  - Returns true if the mic is listening. Even if it's listening, it might
not be playing - because it will only record and transmit if it can hear sound.
- `System.Single Amplitude`
  - Measure of audio loudness.

## Methods

### Instance methods

- `virtual System.Void OnUpdate()`
- `virtual System.Collections.Generic.IEnumerable<Sandbox.Connection> ExcludeFilter()`
  - Exclude these connection from hearing our voice.
- `virtual System.Boolean ShouldHearVoice(Sandbox.Connection connection)`
  - Whether we want to hear voice from a particular connection.
