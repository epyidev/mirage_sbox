# Sandbox.Doo.VariableExpression

An expression that evaluates to the current value of a named variable.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Doo.Expression`
- **Declaring type:** `Sandbox.Doo`

## Constructors

- `VariableExpression()`

## Properties

- `System.String VariableName`
  - The name of the variable to read.

## Methods

### Instance methods

- `virtual Sandbox.Variant Evaluate()`
- `virtual System.String GetDebugText()`
- `virtual System.Void CollectArguments(System.Collections.Generic.HashSet<System.String> arguments)`
