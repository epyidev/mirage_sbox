# Sandbox.WebSocket.DataReceivedHandler

Event handler which processes binary messages from the WebSocket service.

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.MulticastDelegate`
- **Declaring type:** `Sandbox.WebSocket`

## Constructors

- `DataReceivedHandler(System.Object object, System.IntPtr method)`

## Methods

### Instance methods

- `virtual System.Void Invoke(System.Span<System.Byte> data)`
- `virtual System.IAsyncResult BeginInvoke(System.Span<System.Byte> data, System.AsyncCallback callback, System.Object object)`
- `virtual System.Void EndInvoke(System.IAsyncResult result)`
