# Sandbox.MovieMaker.MovieRecorderFilter

Returns `null` if the passed `gameObject` shouldn't be recorded.
Called once per object.

- **Kind:** sealed class
- **Namespace:** `Sandbox.MovieMaker`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.MulticastDelegate`

## Constructors

- `MovieRecorderFilter(System.Object object, System.IntPtr method)`

## Methods

### Instance methods

- `virtual System.Boolean Invoke(Sandbox.GameObject gameObject)`
- `virtual System.IAsyncResult BeginInvoke(Sandbox.GameObject gameObject, System.AsyncCallback callback, System.Object object)`
- `virtual System.Boolean EndInvoke(System.IAsyncResult result)`
