# Editor.EditorUtility.Network

- **Kind:** static class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Tools`
- **Declaring type:** `Editor.EditorUtility`

## Properties

- `static System.Boolean Active`
  - True if the network system is active
- `static System.Boolean Hosting`
  - True if the network system is active and we're the host
- `static System.Boolean Client`
  - True if the network system is active and we're the host
- `static Sandbox.Network.LobbyPrivacy HostPrivacy`
  - Determines who can join a lobby hosted from the editor. Should only be set
before creating a lobby. Persists between lobbies.
- `static Sandbox.Connection[] Channels`
  - Return all of the channels on this connection. 
If you're the host, it should return all client connections.
If you're the client, it should return empty - unless you're in a p2p session (lobby).
Returns empty if you're not connected
- `static Sandbox.Network.NetworkSocket[] Sockets`
  - Return all of the sockets on this connection. 
If you're the host, it should return all active sockets.
If you're the client, it should return empty - unless you're in a p2p session (lobby).
Returns empty if you're not connected

## Methods

### Static methods

- `static System.Void Disconnect()`
  - Disconnect from the current network session
- `static System.Void Connect(System.String address)`
  - Connenct to a network address
- `static System.Void StartHosting()`
  - Start hosting a lobby. If we're not already in play mode, we'll enter play mode first.
