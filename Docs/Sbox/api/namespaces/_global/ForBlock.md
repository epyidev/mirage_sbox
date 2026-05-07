# Sandbox.Doo.ForBlock

Run a block of code a certain number of times, with a loop variable.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Doo.Block`
- **Declaring type:** `Sandbox.Doo`

## Constructors

- `ForBlock()`

## Properties

- `System.String VariableName`
  - The name of the loop counter variable.
- `Sandbox.Doo.Expression StartValue`
  - The initial value of the loop counter.
- `Sandbox.Doo.Expression EndValue`
  - The upper bound of the loop (exclusive).
- `Sandbox.Doo.Expression JumpValue`
  - The amount to increment the loop counter each iteration.

## Methods

### Instance methods

- `virtual System.Boolean HasBody()`
- `virtual System.String GetNodeString()`
- `virtual System.Void Reset()`
- `virtual System.Void CollectArguments(System.Collections.Generic.HashSet<System.String> arguments)`
