# Sandbox.Connection

A connection, usually to a server or a client.

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `Connection()`

## Properties

- `System.Guid Id`
  - This connection's unique identifier.
- `System.Boolean CanSpawnObjects`
  - Can this connection spawn networked objects?
- `System.Boolean CanRefreshObjects`
  - Can this connection refresh networked objects that they own?
- `System.Boolean CanDestroyObjects`
  - Can this connection destroy networked objects they own?
- `System.Single Latency`
- `System.String Name`
- `System.Single Time`
- `System.String Address`
- `System.Boolean IsHost`
- `System.Boolean IsConnecting`
  - True if this channel is still currently connecting.
- `System.Boolean IsActive`
  - True if this channel is fully connnected and fully logged on.
- `System.Int32 MessagesSent`
  - How many messages have been sent to this connection?
- `System.Int32 MessagesRecieved`
  - How many messages have been received from this connection?
- `Sandbox.Network.ConnectionStats Stats`
  - Get stats about this connection such as bandwidth usage and how many packets are being
sent and received.
- `System.Single Ping`
  - The ping of this connection (in milliseconds.)
- `System.String DisplayName`
- `Sandbox.SteamId SteamId`
- `Sandbox.SteamId OwnerSteamId`
  - The SteamID of the account that actually owns the game in a Steam Family.
If not in a Steam Family this is the same as `Sandbox.Connection.SteamId`
- `Sandbox.SteamId PartyId`
  - The Id of the party that this user is a part of. This can be used to compare to other users to 
group them into parties.
- `System.DateTimeOffset ConnectionTime`
- `static Sandbox.Connection Local`
  - This is a "fake" connection for the local player. It is passed to RPCs when calling them
locally etc.
- `static System.Collections.Generic.IReadOnlyList<Sandbox.Connection> All`
  - A list of connections that are currently on this server. If you're not on a server
this will return only one connection (Connection.Local). Some games restrict the 
connection list - in which case you will get an empty list.
- `static Sandbox.Connection Host`
  - The connection of the current network host.

## Methods

### Static methods

- `static Sandbox.Connection Find(System.Guid id)`
  - Find a `Sandbox.Connection` for a Connection Id.

### Instance methods

- `virtual System.Boolean HasPermission(System.String permission)`
  - Get whether this connection has a specific permission.
- `System.Single DistanceSquared(Vector3 position)`
  - Calculate the closest distance (squared) to a position based on the Pvs sources from
this `Sandbox.Connection`.
- `virtual System.Void Kick(System.String reason)`
  - Kick this `Sandbox.Connection` from the server. Only the host can kick clients.
  - `reason`: The reason to display to this client.
- `System.Void SendLog(Sandbox.LogLevel level, System.String message)`
  - Log a message to the console for this connection.
- `System.Void SendMessage(T t)`
  - Send a message to this connection.
- `System.String GetUserData(System.String key)`
- `System.Boolean HasInventoryItem(System.Int32 definitionId)`
  - Check if this connection has a specific inventory item in their Steam Inventory
- `System.Boolean Down(System.String action)`
  - Action is currently pressed down for this `Sandbox.Connection`.
- `System.Boolean Pressed(System.String action)`
  - Action was pressed for this `Sandbox.Connection` within the current update context.
- `System.Boolean Released(System.String action)`
  - Action was released for this `Sandbox.Connection` within the current update context.
- `System.Threading.Tasks.Task<System.Object> SendRequest(T t)`
  - Send a message to this connection, wait for a response
- `System.Void SendResponse(System.Guid requestId, T t)`
  - Send a response message to this connection.
