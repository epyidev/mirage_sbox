# Sandbox.SyncAttribute

Automatically synchronize a property of a networked object from the owner to other clients.

- **Kind:** attribute
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Attribute`

## Constructors

- `SyncAttribute(Sandbox.SyncFlags flags)`
- `SyncAttribute()`

## Properties

- `System.Boolean Query`
  - Query this value for changes rather than counting on set being called. This is appropriate
if the value returned by its getter can change without calling its setter.
            
Obsoleted: 13/12/2024
- `Sandbox.SyncFlags Flags`
  - Flags that describe how this property is synchronized.
