# Sandbox.Speech.Recognition.OnSpeechResult

Called when we have a result from speech recognition.

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.MulticastDelegate`
- **Declaring type:** `Sandbox.Speech.Recognition`

## Constructors

- `OnSpeechResult(System.Object object, System.IntPtr method)`

## Methods

### Instance methods

- `virtual System.Void Invoke(Sandbox.Speech.SpeechRecognitionResult result)`
- `virtual System.IAsyncResult BeginInvoke(Sandbox.Speech.SpeechRecognitionResult result, System.AsyncCallback callback, System.Object object)`
- `virtual System.Void EndInvoke(System.IAsyncResult result)`
