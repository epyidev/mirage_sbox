# Sandbox.Mesh.VertexBufferLockHandler<T>

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.MulticastDelegate`
- **Declaring type:** `Sandbox.Mesh`

## Constructors

- `VertexBufferLockHandler<T>(System.Object object, System.IntPtr method)`

## Methods

### Instance methods

- `virtual System.Void Invoke(System.Span<T> data)`
- `virtual System.IAsyncResult BeginInvoke(System.Span<T> data, System.AsyncCallback callback, System.Object object)`
- `virtual System.Void EndInvoke(System.IAsyncResult result)`
