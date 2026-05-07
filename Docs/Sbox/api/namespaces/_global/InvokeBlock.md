# Sandbox.Doo.InvokeBlock

Call a global method or a method on a component.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Doo.Block`
- **Declaring type:** `Sandbox.Doo`

## Constructors

- `InvokeBlock()`

## Properties

- `Sandbox.Doo.InvokeType InvokeType`
  - Whether this invokes a static global method or a component member.
- `Sandbox.Doo.TargetComponent TargetComponent`
  - The component instance to invoke the method on when using `Sandbox.Doo.InvokeType.Member`.
- `System.String Member`
  - The fully qualified method path to invoke (e.g. "Log.Info").
- `System.Collections.Generic.List<Sandbox.Doo.Expression> Arguments`
  - The list of argument expressions to pass to the method.
- `System.String ReturnVariable`
  - Variable name to set to the returned value. Leave empty to ignore the return value.

## Methods

### Instance methods

- `virtual System.String GetNodeString()`
- `virtual System.Void CollectArguments(System.Collections.Generic.HashSet<System.String> arguments)`
