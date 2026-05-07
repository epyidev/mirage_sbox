# Sandbox.PrefabVariable

A prefab variable definition

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `PrefabVariable()`

## Properties

- `System.String Id`
  - A unique id for this variable. This is what it will be referred to in code.
- `System.String Title`
  - A user friendly title for this variable
- `System.String Description`
  - A user friendly description for this variable
- `System.String Group`
  - An optional group for this variable to belong to
- `System.Int32 Order`
  - Lower numbers appear first
- `System.Collections.Generic.List<Sandbox.PrefabVariable.PrefabVariableTarget> Targets`
  - Component variables that are being targetted

## Methods

### Instance methods

- `System.Void AddTarget(System.Guid id, System.String propertyName)`
  - Add a target property
