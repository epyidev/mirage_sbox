# Sandbox.Network.GameNetworkSystem

An instance of this is created by the NetworkSystem when a server is joined, or created.
You should not try to create this manually.

- **Kind:** abstract class
- **Namespace:** `Sandbox.Network`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `GameNetworkSystem()`

## Properties

- `static System.Boolean IsHost`
  - True if we can be considered the host of this session. Either we're not connected to a server, or we are and we are the host.
- `static System.Boolean IsClient`
  - True if we're connected to a server and not the host.
- `static System.Boolean IsConnecting`
  - True if we're currently connecting to the server
- `static System.Boolean IsActive`
  - True if we're currently connected etc

## Methods

### Static methods

- `static System.Void CreateLobby()`
- `static System.Threading.Tasks.Task<System.Collections.Generic.List<Sandbox.Network.LobbyInformation>> QueryLobbies()`
- `static System.Void Disconnect()`
- `static System.Void Connect(System.UInt64 steamid)`
- `static System.Void Connect(System.String target)`
- `static System.Threading.Tasks.Task<System.Boolean> TryConnectSteamId(System.UInt64 steamId)`

### Instance methods

- `virtual System.Void Dispose()`
- `virtual System.Boolean AcceptConnection(Sandbox.Connection channel, System.String reason)`
  - Called on the host to decide whether to accept a `Sandbox.Connection`.
  - `reason`: The reason to display to the client.
- `virtual System.Void GetMountedVPKs(Sandbox.Connection source, Sandbox.Network.MountedVPKsResponse msg)`
- `virtual System.Void GetSnapshot(Sandbox.Connection source, Sandbox.Network.SnapshotMsg msg)`
- `virtual System.Threading.Tasks.Task SetSnapshotAsync(Sandbox.Network.SnapshotMsg data)`
- `virtual System.Threading.Tasks.Task MountVPKs(Sandbox.Connection source, Sandbox.Network.MountedVPKsResponse msg)`
- `virtual System.Void OnInitialize()`
  - Called when the network system should handle initialization.
- `virtual System.Void OnConnected(Sandbox.Connection client)`
  - A client has connected to the server but hasn't fully finished joining yet.
- `virtual System.Void OnJoined(Sandbox.Connection client)`
  - Fully joined the server. Can be called when changing the map too. The game should usually create
some object for the player to control here.
- `virtual System.Void OnLeave(Sandbox.Connection client)`
  - A client has disconnected from the server.
- `virtual System.Void OnBecameHost(Sandbox.Connection previousHost)`
  - The host left the server and you are now in charge.
- `virtual System.Void OnHostChanged(Sandbox.Connection previousHost, Sandbox.Connection newHost)`
  - The current host has been changed.
- `System.Void BroadcastRaw(Sandbox.ByteStream msg, System.Nullable<Sandbox.Connection.Filter> filter)`
- `System.Void Broadcast(T obj, System.Nullable<Sandbox.Connection.Filter> filter)`
- `System.Void Send(System.Guid connectionId, T obj)`
- `virtual System.IDisposable Push()`
  - Allows to push some kind of scope when reading network messages. This is useful if you
need to adjust Time.Now etc.
- `System.Void AddHandler(System.Action<T,Sandbox.Connection,System.Guid> handler)`
- `System.Void AddHandler(System.Func<T,Sandbox.Connection,System.Guid,System.Threading.Tasks.Task> handler)`
- `System.Void AddHandler(System.Action<T,Sandbox.Connection> handler)`
- `virtual System.Void Tick()`
  - Called every frame
