# Editor.MapClassVariable

Represents a variable.

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Constructors

- `MapClassVariable()`

## Properties

- `System.String Name`
  - The internal name.
- `System.String LongName`
  - The user friendly name for UI.
- `System.String Description`
  - Description for this variable.
- `System.String GroupName`
  - Category or group for this variable.
- `System.Type PropertyType`
  - Data type for this variable.
- `System.Object DefaultValue`
  - Default value for this variable.
- `System.String PropertyTypeOverride`
  - Internal, used to override the type to one the tools understand.
- `System.Collections.Generic.Dictionary<System.String,System.String> Metadata`
  - General purpose key-value store to alter functionality of UI, map compilation, editor helpers, etc.
