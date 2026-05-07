# Sandbox.DataModel.GameSetting

A `Sandbox.ConVarAttribute` that has been marked with `Sandbox.ConVarFlags.GameSetting`
This is stored as project metadata so we can set up a game without loading it.

- **Kind:** struct
- **Namespace:** `Sandbox.DataModel`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `GameSetting(System.String Name, System.String Title, System.String Group, System.String Default)`
  - A `Sandbox.ConVarAttribute` that has been marked with `Sandbox.ConVarFlags.GameSetting`
This is stored as project metadata so we can set up a game without loading it.

## Properties

- `System.String Name`
- `System.String Title`
- `System.String Group`
- `System.String Default`
- `System.Collections.Generic.List<Sandbox.DataModel.GameSetting.Option> Options`
- `System.Nullable<System.Single> Min`
- `System.Nullable<System.Single> Max`
- `System.Nullable<System.Single> Step`

## Methods

### Instance methods

- `System.Void Deconstruct(System.String Name, System.String Title, System.String Group, System.String Default)`
