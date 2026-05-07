# Sandbox.SoundHandle.LipSyncAccessor

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.SoundHandle`

## Properties

- `System.Collections.Generic.IReadOnlyList<System.Single> Visemes`
  - A list of 15 lipsync viseme weights. Requires `Sandbox.SoundHandle.LipSyncAccessor.Enabled` to be true.
- `System.Int32 FrameNumber`
  - Count from start of recognition.
- `System.Int32 FrameDelay`
  - Frame delay in milliseconds.
- `System.Single LaughterScore`
  - Laughter score for the current audio frame.
- `System.Boolean Enabled`
  - Enables lipsync processing.
