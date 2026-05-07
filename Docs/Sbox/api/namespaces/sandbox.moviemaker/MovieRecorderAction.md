# Sandbox.MovieMaker.MovieRecorderAction

Called each time `Sandbox.MovieMaker.MovieRecorder.Capture` is invoked.

- **Kind:** sealed class
- **Namespace:** `Sandbox.MovieMaker`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.MulticastDelegate`

## Constructors

- `MovieRecorderAction(System.Object object, System.IntPtr method)`

## Methods

### Instance methods

- `virtual System.Void Invoke(Sandbox.MovieMaker.MovieRecorder recorder)`
- `virtual System.IAsyncResult BeginInvoke(Sandbox.MovieMaker.MovieRecorder recorder, System.AsyncCallback callback, System.Object object)`
- `virtual System.Void EndInvoke(System.IAsyncResult result)`
