# Sandbox.IGameObjectNetworkEvents

Allows listening to network events on a specific GameObject

- **Kind:** interface
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Methods

### Instance methods

- `virtual System.Void NetworkOwnerChanged(Sandbox.Connection newOwner, Sandbox.Connection previousOwner)`
  - Called when the owner of a network GameObject is changed
- `virtual System.Void StartControl()`
  - We have become the controller of this object, we are no longer a proxy
- `virtual System.Void StopControl()`
  - This object has become a proxy, controlled by someone else
