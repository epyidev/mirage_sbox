# Sandbox.WebSocket.DisconnectedHandler

Event handler which fires when the WebSocket disconnects from the server.

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.MulticastDelegate`
- **Declaring type:** `Sandbox.WebSocket`

## Constructors

- `DisconnectedHandler(System.Object object, System.IntPtr method)`

## Methods

### Instance methods

- `virtual System.Void Invoke(System.Int32 status, System.String reason)`
- `virtual System.IAsyncResult BeginInvoke(System.Int32 status, System.String reason, System.AsyncCallback callback, System.Object object)`
- `virtual System.Void EndInvoke(System.IAsyncResult result)`
