# Sandbox.Doo.Expression

Base class for all value expressions used as arguments and assignments within blocks.

- **Kind:** abstract class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Doo`

## Constructors

- `Expression()`

## Methods

### Instance methods

- `virtual Sandbox.Variant Evaluate()`
  - Evaluates this expression and returns its value.
- `virtual System.String GetDebugText()`
  - Returns a human-readable string representation of this expression for the editor.
- `virtual System.Void CollectArguments(System.Collections.Generic.HashSet<System.String> arguments)`
