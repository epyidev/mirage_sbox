# Sandbox.Bind.BindSystem

Data bind system, bind properties to each other.

- **Kind:** class
- **Namespace:** `Sandbox.Bind`
- **Assembly:** `Sandbox.Bind`

## Properties

- `System.String Name`
  - The debug name given to this system (ie Tools, Client, Server)
- `System.Boolean ThrottleUpdates`
  - If true we'll throttle time between link change checks. This should
always be enabled in game, for performance reasons.
- `System.Boolean CatchExceptions`
  - If true we'll catch and remove exceptions when testing links instead of
propagating them to the Tick call.
- `System.Int32 LinkCount`
  - The current amount of active links
- `Sandbox.Bind.Builder Build`
  - A helper to create binds between two properties (or whatever you want)

## Methods

### Instance methods

- `System.Void Tick()`
  - Should be called every frame. Will run through the links and check
for changes, then action those changes. Will also remove dead links.
- `System.Void Flush()`
  - Call a tick with no timer limits, forcing all pending actions to be actioned
- `System.Attribute[] FindAttributes(T obj, System.String property)`
  - For this object, with this property, find the property
that supplies it and return any attributes set on it.
This is useful for editors to allow them to supply the correct
editor, without having access to the property.
