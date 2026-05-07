# Sandbox.ITypeAttribute

When applied to an attribute, which is then applied to a type..
This will make `Sandbox.ITypeAttribute.TargetType` set on the attribute upon load.


This provides a convenient way to know which type the attribute was attached to.

- **Kind:** interface
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Properties

- `System.Type TargetType`
  - The type this attribute was attached to.

## Methods

### Instance methods

- `virtual System.Void TypeRegister()`
  - Called when a class with this attribute is registered via the TypeLibrary.
- `virtual System.Void TypeUnregister()`
  - Called when a class with this attribute is unregistered via the TypeLibrary.
