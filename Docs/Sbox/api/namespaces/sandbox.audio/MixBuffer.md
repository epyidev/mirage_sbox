# Sandbox.Audio.MixBuffer

Contains 512 samples of audio data, this is used when mixing a single channel

- **Kind:** sealed class
- **Namespace:** `Sandbox.Audio`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `MixBuffer()`

## Properties

- `System.Single LevelMax`
- `System.Single LevelAvg`

## Methods

### Instance methods

- `virtual System.Void Dispose()`
- `System.Void Silence()`
  - Silence this buffer
- `System.Void CopyFrom(Sandbox.Audio.MixBuffer other)`
  - Set this buffer to this value
- `System.Void MixFrom(Sandbox.Audio.MixBuffer other, System.Single scale)`
  - Mix this buffer with another
- `System.Void MixFrom(Sandbox.Audio.MultiChannelBuffer other, System.Single scale)`
  - Mix this buffer with another
- `System.Void Scale(System.Single volume)`
  - Scale the buffer by volume
- `System.Void RandomFill()`
