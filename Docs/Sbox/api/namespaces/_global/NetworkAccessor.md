# Sandbox.GameObject.NetworkAccessor

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.GameObject`

## Constructors

- `NetworkAccessor(Sandbox.GameObject o)`

## Properties

- `System.Boolean Active`
  - Is this object networked?
- `Sandbox.GameObject RootGameObject`
  - Get the GameObject that is the root of this network object
- `System.Boolean IsOwner`
  - Are we the owner of this network object?
- `System.Guid OwnerId`
  - The Id of the owner of this object
- `System.Boolean IsCreator`
  - Are we the creator of this network object
- `System.Guid CreatorId`
  - The Id of the creator of this object
- `System.Boolean IsProxy`
  - Is this object a network proxy? A network proxy is a network object that is not being simulated on the local pc.
This means it's either owned by no-one and is being simulated by the host or owned by another client.
- `Sandbox.Connection OwnerConnection`
  - Try to get the connection that owns this object. This can and will return null
if we don't have information for this connection.
- `Sandbox.Connection Owner`
  - Try to get the connection that owns this object. This can and will return null
if we don't have information for this connection.
- `Sandbox.OwnerTransfer OwnerTransfer`
  - Who can control ownership of this networked object?
- `Sandbox.NetworkOrphaned NetworkOrphaned`
  - Determines what happens when the owner disconnects.
- `Sandbox.NetworkFlags Flags`
  - Network flags which describe the behavior of this networked object.
<b>Can only be changed by the host after the networked object has been spawned.</b>
- `System.Boolean AlwaysTransmit`
  - Determines whether updates for this networked object are always transmitted to clients. Otherwise,
they are only transmitted when the object is determined as visible to each client.
- `System.Boolean Interpolation`
  - Whether the networked object's transform is interpolated.

## Methods

### Instance methods

- `System.Boolean EnableInterpolation()`
  - Enable interpolation for the networked object's transform.
Obsolete: 09/12/2025
- `System.Boolean DisableInterpolation()`
  - Disable interpolation for the networked object's transform.
Obsolete: 09/12/2025
- `System.Boolean ClearInterpolation()`
- `System.Boolean SetOrphanedMode(Sandbox.NetworkOrphaned action)`
  - Set what happens to this networked object when the owner disconnects.
- `System.Boolean SetOwnerTransfer(Sandbox.OwnerTransfer option)`
  - Set who can control ownership of this networked object. Only the current owner can change this.
- `System.Void Refresh()`
  - Send a complete refresh snapshot of this networked object to other clients. This is useful if you have
made vast changes to components or children.
- `System.Void Refresh(Sandbox.GameObject descendent)`
  - Send a refresh for a specific `Sandbox.GameObject` in the hierarchy of this networked object to other clients.
This is useful if you've destroyed or added a new `Sandbox.GameObject` descendent and don't want to refresh
the entire networked object.
- `System.Void Refresh(Sandbox.Component component)`
  - Send a refresh for a specific `Sandbox.Component` in the hierarchy of this networked object to other clients.
This is useful if you've destroyed or added a new `Sandbox.Component` and don't want to refresh the entire object.
- `System.Boolean TakeOwnership()`
  - Become the network owner of this object.
<br /><br />
Note: whether you can take ownership of this object depends on the
`Sandbox.GameObject.NetworkAccessor.OwnerTransfer` of this networked object.
- `System.Boolean AssignOwnership(Sandbox.Connection channel)`
  - Set the owner of this object to the specified `Sandbox.Connection`.
<br /><br />
Note: whether you can assign ownership of this object depends on the
`Sandbox.GameObject.NetworkAccessor.OwnerTransfer` of this networked object.
- `System.Boolean DropOwnership()`
  - Stop being the owner of this object. Will clear the owner so the object becomes
controlled by the server, and owned by no-one.
<br /><br />
Note: whether you can drop ownership of this object depends on the
`Sandbox.GameObject.NetworkAccessor.OwnerTransfer` of this networked object.
- `System.Boolean Spawn()`
- `System.Boolean Spawn(Sandbox.Connection owner)`
