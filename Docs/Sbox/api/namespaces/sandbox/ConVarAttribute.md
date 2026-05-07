# Sandbox.ConVarAttribute

Console variable

- **Kind:** attribute
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Attribute`

## Constructors

- `ConVarAttribute(System.String name, Sandbox.ConVarFlags flags)`
- `ConVarAttribute(Sandbox.ConVarFlags flags)`

## Properties

- `System.String Name`
  - If unset the name will be set to the name of the method/property
- `System.String Help`
  - Describes why this command exists
- `System.Single Min`
  - Minimum value for this command
- `System.Single Max`
  - Maximum value for this command
- `System.Boolean Saved`
  - If true this variable is saved
- `Sandbox.ConVarFlags Flags`
  - Describes the kind of convar this is
