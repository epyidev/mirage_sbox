# Sandbox.Bind.Link

Joins two proxies together, so one can be updated from the other (or both from each other)

- **Kind:** sealed class
- **Namespace:** `Sandbox.Bind`
- **Assembly:** `Sandbox.Bind`

## Properties

- `System.Boolean IsValid`
  - This is updated in tick. Will return false if either binding is invalid. Bindings become
invalid if the object is garbage collected or is an IValid and made invalid.
- `System.Boolean OneWay`
  - True if this should only update from left to right.
- `Sandbox.Bind.Proxy Left`
  - The primary binding. Changes to this value always take priority over the other.
- `Sandbox.Bind.Proxy Right`
  - The secondary binding, if we're OneWay then this will only ever be written to.
