# Sandbox.Networking

Global manager to hold and tick the singleton instance of NetworkSystem.

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static System.String ServerName`
  - The name of the server you are currently connected to.
- `static System.String MapName`
  - The name of the map being used on the server you're connected to.
- `static System.Int32 MaxPlayers`
  - The maximum number of players allowed on the server you're connected to.
- `static Sandbox.Network.HostStats HostStats`
  - Get the latest host stats such as bandwidth used and the current frame rate.
- `static System.Boolean IsHost`
  - True if we can be considered the host of this session. Either we're not connected to a server, or we are host of a server.
- `static System.Boolean IsClient`
  - True if we're currently connected to a server, and we are not the host
- `static System.Boolean IsConnecting`
  - True if we're currently connecting to the server
- `static System.Boolean IsActive`
  - True if we're currently connecting to the server
- `static Sandbox.Connection HostConnection`
  - The connection of the current network host.
- `static System.Collections.Generic.IReadOnlyList<Sandbox.Connection> Connections`
  - A list of connections that are currently on this server. If you're not on a server
this will return only one connection (Connection.Local). Some games restrict the 
connection list - in which case you will get an empty list.

## Methods

### Static methods

- `static System.Void SetData(System.String key, System.String value)`
  - Set data about the current server or lobby. Other players can query this
when searching for a game. Note: for now, try to keep the key and value as short
as possible, Steam enforce a character limit on server tags, so it could be possible
to reach that limit when running a Dedicated Server. In the future we'll store this
stuff on our backend, so that won't be a problem.
- `static System.String GetData(System.String key, System.String defaultValue)`
  - Get data about the current server or lobby. This data can be used for filtering
when querying lobbies.
- `static Sandbox.Connection FindConnection(System.Guid id)`
- `static System.Threading.Tasks.Task<System.Boolean> JoinBestLobby(System.String ident)`
  - Try to join the best lobby. Return true on success.
- `static System.Void CreateLobby(Sandbox.Network.LobbyConfig config)`
  - Will create a new lobby with the specified `Sandbox.Network.LobbyConfig` to
customize the lobby further.
- `static System.Void CreateLobby()`
  - Will create a new lobby.
- `static System.Void Disconnect()`
  - Disconnect from current multiplayer session.
- `static System.Void Connect(System.UInt64 steamid)`
- `static System.Void Connect(System.String target)`
  - Will try to determine the right method for connection, and then try to connect.
- `static System.Threading.Tasks.Task<System.Boolean> TryConnectSteamId(Sandbox.SteamId steamId, System.Int32 retries)`
- `static System.Threading.Tasks.Task<System.Collections.Generic.List<Sandbox.Network.LobbyInformation>> QueryLobbies(System.Threading.CancellationToken ct)`
  - Get all lobbies for the current game.
- `static System.Threading.Tasks.Task<System.Collections.Generic.List<Sandbox.Network.LobbyInformation>> QueryLobbies(System.String gameIdent, System.Threading.CancellationToken ct)`
  - Get all lobbies for a specific game.
- `static System.Threading.Tasks.Task<System.Collections.Generic.List<Sandbox.Network.LobbyInformation>> QueryLobbies(System.String gameIdent, System.String mapIdent, System.Threading.CancellationToken ct)`
  - Get all lobbies for a specific game and map.
- `static System.Threading.Tasks.Task<System.Collections.Generic.List<Sandbox.Network.LobbyInformation>> QueryLobbies(System.Collections.Generic.Dictionary<System.String,System.String> filters, System.Boolean includeServers, System.Threading.CancellationToken ct)`
