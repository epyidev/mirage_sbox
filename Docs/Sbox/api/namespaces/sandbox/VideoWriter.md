# Sandbox.VideoWriter

Allows the creation of video content by encoding a sequence of frames.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Int32 Width`
- `System.Int32 Height`

## Methods

### Instance methods

- `virtual System.Void Dispose()`
  - Dispose this recorder, the encoder will be flushed and video finalized.
- `System.Threading.Tasks.Task FinishAsync()`
  - Finish creating this video. The encoder will be flushed and video finalized.
- `System.Boolean AddFrame(System.ReadOnlySpan<System.Byte> data, System.Nullable<System.TimeSpan> timestamp)`
- `System.Boolean AddFrame(Sandbox.Bitmap bitmap, System.Nullable<System.TimeSpan> timestamp)`
