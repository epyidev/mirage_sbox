# Sandbox.SoundFile

A sound resource.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Resource`

## Properties

- `System.Action OnSoundReloaded`
  - Ran when the file is reloaded/recompiled, etc.
- `System.Boolean IsLoaded`
  - true if sound is loaded
- `Sandbox.SoundFormat Format`
  - Format of the audio file.
- `System.Int32 BitsPerSample`
  - Bits per each sample of this sound file.
- `System.Int32 Channels`
  - Number of channels this audio file has.
- `System.Int32 BytesPerSample`
  - Bytes per each sample of this sound file.
- `System.Int32 SampleFrameSize`
  - Size of one sample, typically this would be "sample size * channel count", but can vary on audio format.
- `System.Int32 Rate`
  - Sample rate of this sound file, per second.
- `System.Single Duration`
  - Duration of the sound this sound file contains, in seconds.
- `System.Boolean IsValid`
- `System.Boolean IsValidForPlayback`

## Methods

### Static methods

- `static Sandbox.SoundFile Load(System.String filename)`
  - Load a new sound from disk. Includes automatic caching.
  - `filename`: The file path to load the sound from.
  - returns: The loaded sound file, or null if failed.
- `static Sandbox.SoundFile FromPcm(System.String filename, System.Span<System.Byte> data, System.Int32 channels, System.UInt32 rate, System.Int32 bits, System.Boolean loop)`
- `static Sandbox.SoundFile FromWav(System.String filename, System.Span<System.Byte> data, System.Boolean loop)`
- `static Sandbox.SoundFile FromMp3(System.String filename, System.Span<System.Byte> data, System.Boolean loop)`

### Instance methods

- `virtual System.Void Finalize()`
- `System.Threading.Tasks.Task<System.Boolean> LoadAsync()`
- `System.Void Preload()`
- `System.Threading.Tasks.Task<System.Int16[]> GetSamplesAsync()`
  - Request decompressed audio samples.
