# Editor.EditorUtility.VoiceRecording

- **Kind:** static class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Tools`
- **Declaring type:** `Editor.EditorUtility`

## Methods

### Static methods

- `static System.Void Start(System.Int32 samples, System.Int32 bytesPerSecond)`
  - Start recording data from microphone
- `static System.Void Stop()`
  - Stop recording data from microphone
- `static System.Void Flush()`
  - Flush any recorded data so we don't have it kept in memory
- `static System.Boolean Save(System.String path)`
  - Grab any recorded voice data and save it as a WAV file
