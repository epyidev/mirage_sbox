# Sandbox.Audio.MultiChannelBuffer

Holds up to 8 mix buffers, which usually represent output speakers.

- **Kind:** sealed class
- **Namespace:** `Sandbox.Audio`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `MultiChannelBuffer(System.Int32 channelCount)`

## Properties

- `System.Int32 ChannelCount`
  - How many channels do we have

## Methods

### Instance methods

- `virtual System.Void Dispose()`
  - Delete and release all resources. Cannot be used again.
- `Sandbox.Audio.MixBuffer Get(Sandbox.Audio.AudioChannel i)`
  - Get MixBuffer number i
- `Sandbox.Audio.MixBuffer Get(System.Int32 i)`
  - Get MixBuffer number i
- `System.Void Silence()`
  - Silence all buffers
- `System.Void CopyFrom(Sandbox.Audio.MultiChannelBuffer other)`
  - Set this buffer to this value
- `System.Void CopyFromUpmix(Sandbox.Audio.MultiChannelBuffer other)`
  - Copies from one buffer to the other. If the other has less channels, we'll upmix
- `System.Void MixFrom(Sandbox.Audio.MultiChannelBuffer samples, System.Single mix)`
  - Mix the target buffer into this buffer
- `System.Void Scale(System.Single volume)`
  - Scale volume of this buffer
