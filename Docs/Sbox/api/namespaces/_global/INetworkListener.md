# Sandbox.Component.INetworkListener

A `Sandbox.Component` with this interface can react to network events.

- **Kind:** interface
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Component`

## Methods

### Instance methods

- `virtual System.Boolean AcceptConnection(Sandbox.Connection channel, System.String reason)`
  - Called on the host to decide whether to accept a `Sandbox.Connection`. If any `Sandbox.Component`
that implements this returns false, the connection will be denied.
  - `reason`: The reason to display to the client.
- `virtual System.Void OnConnected(Sandbox.Connection channel)`
  - Called when someone joins the server. This will only be called for the host.
- `virtual System.Void OnDisconnected(Sandbox.Connection channel)`
  - Called when someone leaves the server. This will only be called for the host.
- `virtual System.Void OnActive(Sandbox.Connection channel)`
  - Called when someone is all loaded and entered the game. This will only be called for the host.
- `virtual System.Void OnBecameHost(Sandbox.Connection previousHost)`
  - Called when the host of the game has left - and you are now the new host.
