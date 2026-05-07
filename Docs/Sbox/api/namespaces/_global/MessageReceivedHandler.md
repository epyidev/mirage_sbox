# Sandbox.WebSocket.MessageReceivedHandler

Event handler which processes text messages from the WebSocket service.

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.MulticastDelegate`
- **Declaring type:** `Sandbox.WebSocket`

## Constructors

- `MessageReceivedHandler(System.Object object, System.IntPtr method)`

## Methods

### Instance methods

- `virtual System.Void Invoke(System.String message)`
- `virtual System.IAsyncResult BeginInvoke(System.String message, System.AsyncCallback callback, System.Object object)`
- `virtual System.Void EndInvoke(System.IAsyncResult result)`
