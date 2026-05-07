# Sandbox.SceneNetworkSystem

This is created and referenced by the network system, as a way to route.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Network.GameNetworkSystem`

## Methods

### Instance methods

- `virtual System.Void GetMountedVPKs(Sandbox.Connection source, Sandbox.Network.MountedVPKsResponse msg)`
  - A client has joined and wants to know what VPKs to preload.
- `virtual System.Threading.Tasks.Task MountVPKs(Sandbox.Connection source, Sandbox.Network.MountedVPKsResponse msg)`
  - Asynchronously load and mount any VPKs from the provided server response.
- `virtual System.Void GetSnapshot(Sandbox.Connection source, Sandbox.Network.SnapshotMsg msg)`
  - A client has joined and wants a snapshot of the world.
- `virtual System.Void Dispose()`
- `System.String WorkoutMapName()`
- `virtual System.Void Tick()`
- `virtual System.Threading.Tasks.Task SetSnapshotAsync(Sandbox.Network.SnapshotMsg msg)`
  - We have received a snapshot of the world.
- `virtual System.Boolean AcceptConnection(Sandbox.Connection channel, System.String reason)`
  - Called on the host to decide whether to accept a `Sandbox.Connection`. If any `Sandbox.Component`
that implements this returns false, the connection will be denied.
  - `reason`: The reason to display to the client.
- `virtual System.Void OnConnected(Sandbox.Connection client)`
- `virtual System.Void OnInitialize()`
- `virtual System.Void OnJoined(Sandbox.Connection client)`
- `virtual System.Void OnLeave(Sandbox.Connection client)`
- `virtual System.Void OnHostChanged(Sandbox.Connection previousHost, Sandbox.Connection newHost)`
- `virtual System.Void OnBecameHost(Sandbox.Connection previousHost)`
- `virtual System.IDisposable Push()`
