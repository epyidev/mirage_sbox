# Sandbox.UI.MixinParameter

A single parameter in a mixin definition.

- **Kind:** struct
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `MixinParameter(System.String name, System.String defaultValue, System.Boolean isVariadic)`
  - A single parameter in a mixin definition.

## Fields

- `System.String Name`
  - Parameter name without the $ prefix (and without ... for variadic)
- `System.String DefaultValue`
  - Default value, or null if the parameter is required
- `System.Boolean IsVariadic`
  - Whether this is a variadic parameter (collects remaining arguments)
