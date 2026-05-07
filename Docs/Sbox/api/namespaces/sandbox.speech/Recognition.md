# Sandbox.Speech.Recognition

- **Kind:** static class
- **Namespace:** `Sandbox.Speech`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static System.Boolean IsListening`
  - Whether or not we are currently listening for speech.
- `static System.Boolean IsSupported`
  - Whether or not speech recognition is supported and a language is available.

## Methods

### Static methods

- `static System.Void Start(Sandbox.Speech.Recognition.OnSpeechResult callback, System.Collections.Generic.IEnumerable<System.String> choices)`
- `static System.Void Stop()`
  - Stop any active listening for speech.
