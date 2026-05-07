# Sandbox.SandboxToolExtensions.PropertyPath

Describes the path to a `Sandbox.SerializedProperty` from either a `Sandbox.GameObject`
or `Sandbox.Component`.

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Tools`
- **Declaring type:** `Sandbox.SandboxToolExtensions`

## Properties

- `System.Collections.Generic.IReadOnlyList<Sandbox.SerializedProperty> Properties`
  - Full path to reach the original property, starting from a property on a `Sandbox.GameObject` or
`Sandbox.Component`.
- `System.String FullName`
  - Names of each property in `Sandbox.SandboxToolExtensions.PropertyPath.Properties`, separated by `'.'`s.
- `System.Collections.Generic.IEnumerable<System.Object> Targets`
  - `Sandbox.GameObject`(s) or `Sandbox.Component`(s) that contain the original property.
