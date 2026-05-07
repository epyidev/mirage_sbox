# Sandbox.ChangeAttribute

This will invoke a method when the property changes. It can be used with any property but is especially useful
when combined with [Sync] or [ConVar].
<br /><br />
If no name is provided, we will try to call On[PropertyName]Changed. The callback should have 2 arguments - oldValue and newValue, both of the same type as the property itself.

- **Kind:** attribute
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Attribute`

## Constructors

- `ChangeAttribute(System.String name)`

## Properties

- `System.String Name`
  - Name of the method to call on change. If no name is provided, we will try to call On[PropertyName]Changed.
