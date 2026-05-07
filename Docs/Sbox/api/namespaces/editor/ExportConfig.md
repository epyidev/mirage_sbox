# Editor.ExportConfig

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Constructors

- `ExportConfig()`

## Properties

- `Sandbox.Project Project`
- `System.Collections.Generic.Dictionary<System.String,System.Object> AssemblyFiles`
  - If the compile process created any assemblies
- `System.String TargetDir`
  - Where are we putting the exported build?
- `System.String ExecutableName`
  - The target .exe name for this export
- `System.String TargetIcon`
  - The icon for the target .exe
- `System.String StartupImage`
  - The splash screen to use
- `System.UInt32 AppId`
  - The Steam AppID for the target .exe
- `System.DateTime BuildDate`
  - Game's build date

## Fields

- `System.Collections.Generic.HashSet<System.String> CodePackages`
  - Assemblies can reference asset packages. This is a list
of packages that the compiled code references.
