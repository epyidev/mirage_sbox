# Sandbox.VideoPlayer.TextureChangedDelegate

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.MulticastDelegate`
- **Declaring type:** `Sandbox.VideoPlayer`

## Constructors

- `TextureChangedDelegate(System.Object object, System.IntPtr method)`

## Methods

### Instance methods

- `virtual System.Void Invoke(System.ReadOnlySpan<System.Byte> span, Vector2 size)`
- `virtual System.IAsyncResult BeginInvoke(System.ReadOnlySpan<System.Byte> span, Vector2 size, System.AsyncCallback callback, System.Object object)`
- `virtual System.Void EndInvoke(System.IAsyncResult result)`
