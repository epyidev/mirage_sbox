# Sandbox.MusicPlayer

Enables music playback. Use this for music, not for playing game sounds.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Int32 SampleRate`
  - Sample rate of the audio being played.
- `System.Int32 Channels`
  - Number of channels of the audio being played.
- `System.Single Duration`
  - Gets the total duration of the video in seconds.
- `System.Single PlaybackTime`
  - Gets the current playback time in seconds.
- `System.Action OnFinished`
  - Invoked when the audio has finished playing.
- `System.Action OnRepeated`
  - Invoked when the audio has repeated.
- `System.Boolean ListenLocal`
  - Place the listener at 0,0,0 facing 1,0,0.
- `Vector3 Position`
  - Position of the sound.
- `System.Boolean Paused`
  - Pause playback of audio.
- `System.Boolean Repeat`
  - Audio will repeat when reaching the end.
- `System.Single Volume`
  - Change the volume of this music.
- `System.Boolean LipSync`
  - Enables lipsync processing.
- `Sandbox.Audio.Mixer TargetMixer`
  - Which mixer do we want to write to
- `System.Single Distance`
- `Sandbox.Curve Falloff`
- `System.Collections.Generic.IReadOnlyList<System.Single> Visemes`
  - A list of 15 lipsync viseme weights. Requires `Sandbox.MusicPlayer.LipSync` to be enabled.
- `System.String Title`
  - Get title of the track.
- `System.ReadOnlySpan<System.Single> Spectrum`
  - 512 FFT magnitudes used for audio visualization.
- `System.Single Amplitude`
  - Approximate measure of audio loudness.

## Methods

### Static methods

- `static Sandbox.MusicPlayer PlayUrl(System.String url)`
  - Plays a music stream from a URL.
- `static Sandbox.MusicPlayer Play(Sandbox.BaseFileSystem filesystem, System.String path)`
  - Plays a music file from a relative path.

### Instance methods

- `virtual System.Void Dispose()`
- `System.Void Stop()`
  - Stops audio playback.
- `System.Void Seek(System.Single time)`
  - Sets the playback position to a specified time in the audio, given in seconds.
