# Sandbox.Component.INetworkSpawn

A `Sandbox.Component` with this interface can listen for when a GameObject
in its ancestors has been network spawned.

- **Kind:** interface
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Component`

## Methods

### Instance methods

- `virtual System.Void OnNetworkSpawn(Sandbox.Connection owner)`
  - Called when this object is spawned on the network.
