# Sandbox.VideoPlayer

Enables video playback and access to the video texture and audio.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `VideoPlayer()`

## Properties

- `System.Action OnLoaded`
  - Video successfully loaded.
- `System.Action OnAudioReady`
  - Event that is invoked when the audio stream is created and ready to use.
- `System.Action OnFinished`
  - Video finished playing.
- `System.Action OnRepeated`
  - Video started playing again after looping.
- `Sandbox.VideoPlayer.TextureChangedDelegate OnTextureData`
  - If this event is set, texture data will be provided instead of rendering to the texture.
- `System.Boolean Repeat`
  - Sets whether the video should loop when it reaches the end.
- `System.Single Duration`
  - Gets the total duration of the video in seconds.
- `System.Single PlaybackTime`
  - Gets the current playback time in seconds.
- `System.Int32 SampleRate`
  - Audio sample rate.
- `System.Int32 Channels`
  - Number of audio channels.
- `System.Boolean HasAudio`
  - Does the loaded video have audio?
- `System.Boolean IsPaused`
  - Has the video been paused?
- `Sandbox.Texture Texture`
  - Texture of the video frame.
- `System.Int32 Width`
  - Width of the video.
- `System.Int32 Height`
  - Height of the video.
- `Sandbox.VideoPlayer.AudioAccessor Audio`
  - Access audio properties for this video playback.
- `System.Boolean Muted`
  - The video is muted

## Methods

### Instance methods

- `virtual System.Void Dispose()`
- `System.Void Play(System.String url)`
  - Plays a video file from a URL. If there's already a video playing, it will stop.
- `System.Void Play(Sandbox.BaseFileSystem filesystem, System.String path)`
  - Plays a video file from a relative path. If there's already a video playing, it will stop.
- `System.Void Resume()`
  - Resumes video playback.
- `System.Void Stop()`
  - Stops video playback.
- `System.Void Pause()`
  - Pauses video playback.
- `System.Void TogglePause()`
  - Toggle video playback
- `System.Void Seek(System.Single time)`
  - Sets the playback position to a specified time in the video, given in seconds.
- `System.Void Present()`
  - Present a video frame.
