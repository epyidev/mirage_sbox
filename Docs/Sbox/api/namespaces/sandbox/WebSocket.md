# Sandbox.WebSocket

A WebSocket client for connecting to external services.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `WebSocket(System.Int32 maxMessageSize)`
  - Initialized a new WebSocket client.
  - `maxMessageSize`: The maximum message size to allow from the server, in bytes. Default 64 KiB.

## Properties

- `System.Boolean IsConnected`
  - Returns true as long as a WebSocket connection is established.
- `System.String SubProtocol`
  - Get the sub-protocol that was negotiated during the opening handshake.
- `System.Boolean EnableCompression`
  - Enable or disable compression for the websocket. If the server supports it, compression will be enabled for all messages.
Note: compression is disabled by default, and can be dangerous if you are sending secrets across the network.

## Methods

### Instance methods

- `virtual System.Void Dispose()`
  - Cleans up resources used by the WebSocket client. This will also immediately close the connection if it is currently open.
- `System.Void AddSubProtocol(System.String protocol)`
  - Add a sub-protocol to be negotiated during the WebSocket connection handshake.
- `System.Threading.Tasks.Task Connect(System.String websocketUri, System.Threading.CancellationToken ct)`
  - Establishes a connection to an external WebSocket service.
  - `websocketUri`: The WebSocket URI to connect to. For example, "ws://hostname.local:1280/" for unencrypted WebSocket or "wss://hostname.local:1281/" for encrypted.
  - `ct`: A `System.Threading.CancellationToken` which allows the connection attempt to be aborted if necessary.
  - returns: A `System.Threading.Tasks.Task` which completes when the connection is established, or throws if it failed to connect.
- `System.Threading.Tasks.Task Connect(System.String websocketUri, System.Collections.Generic.Dictionary<System.String,System.String> headers, System.Threading.CancellationToken ct)`
- `System.Threading.Tasks.ValueTask Send(System.String message)`
  - Sends a text message to the WebSocket server.
  - `message`: The message text to send. Must not be null.
  - returns: A `System.Threading.Tasks.ValueTask` which completes when the message was queued to be sent.
- `System.Threading.Tasks.ValueTask Send(System.Byte[] data)`
  - Sends a binary message to the WebSocket server.
  - `data`: The message data to send. Must not be null.
  - returns: A `System.Threading.Tasks.ValueTask` which completes when the message was queued to be sent.
- `System.Threading.Tasks.ValueTask Send(System.ArraySegment<System.Byte> data)`
- `System.Threading.Tasks.ValueTask Send(System.Span<System.Byte> data)`
