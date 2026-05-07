# Sandbox.SoundStream

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `SoundStream(System.Int32 sampleRate, System.Int32 channels)`

## Properties

- `System.Int32 SampleRate`
  - Number of samples per second, as set during its creation.
- `System.Int32 Channels`
  - Number of audio channels, as set during its creation.
- `System.Int32 QueuedSampleCount`
- `System.Int32 MaxWriteSampleCount`
- `System.Int32 LatencySamplesCount`

## Methods

### Instance methods

- `System.Void WriteData(System.Span<System.Int16> data)`
- `System.Void Close()`
  - Close the stream: signals that no more data will be written.
Once the internal buffer drains, `Sandbox.SoundHandle.IsPlaying` will become `false`.
- `virtual System.Void Dispose()`
- `Sandbox.SoundHandle Play(System.Single volume, System.Single pitch)`
  - Play sound of the stream.
- `Sandbox.SoundHandle Play(System.Single volume, System.Single pitch, System.Single decibels)`
  - Play sound of the stream.
