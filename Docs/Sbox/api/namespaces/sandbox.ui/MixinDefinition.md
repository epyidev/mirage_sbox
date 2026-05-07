# Sandbox.UI.MixinDefinition

Represents a parsed @mixin definition that can be included elsewhere.

- **Kind:** sealed class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `MixinDefinition()`

## Properties

- `System.String Name`
  - The name of the mixin (e.g., "button" from "@mixin button")
- `System.Collections.Generic.List<Sandbox.UI.MixinParameter> Parameters`
  - Parameter definitions in order, with optional default values.
Key = parameter name (without $), Value = default value (null if required)
- `System.Boolean HasVariadicParameter`
  - Whether this mixin has a variadic parameter (last param ends with ...)
- `System.String Content`
  - The raw content of the mixin body, to be expanded when included.
This includes nested rules which will be parsed during expansion.
- `System.String FileName`
  - Source file for error messages
- `System.Int32 FileLine`
  - Source line for error messages

## Methods

### Instance methods

- `System.String Expand(System.Collections.Generic.Dictionary<System.String,System.String> arguments, System.String contentBlock)`
