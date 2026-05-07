# Sandbox.MorphCollection

Used to access and manipulate morphs.

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `MorphCollection()`

## Properties

- `System.Int32 Count`
  - Amount of morphs.

## Methods

### Instance methods

- `virtual System.Void ResetAll()`
  - Reset all morphs to their default values.
- `virtual System.Void ResetAll(System.Single fadeTime)`
  - Reset all morphs to their default values.
- `virtual System.Void Reset(System.Int32 i)`
  - Reset morph number i to its default value.
- `virtual System.Void Reset(System.Int32 i, System.Single fadeTime)`
  - Reset morph number i to its default value.
- `virtual System.Void Reset(System.String name)`
  - Reset named morph to its default value.
- `virtual System.Void Reset(System.String name, System.Single fadeTime)`
  - Reset named morph to its default value.
- `virtual System.Void Set(System.Int32 i, System.Single weight)`
  - Set indexed morph to this value.
- `virtual System.Void Set(System.String name, System.Single weight)`
  - Set named morph to this value.
- `virtual System.Void Set(System.Int32 i, System.Single weight, System.Single fadeTime)`
  - Set indexed morph to this value.
- `virtual System.Void Set(System.String name, System.Single weight, System.Single fadeTime)`
  - Set named morph to this value.
- `virtual System.Single Get(System.Int32 i)`
  - Get indexed morph value (Note: Currently, this only gets the override morph value)
- `virtual System.Single Get(System.String name)`
  - Get named morph value (Note: Currently, this only gets the override morph value)
- `virtual System.String GetName(System.Int32 index)`
  - Retrieve name of a morph at given index.
