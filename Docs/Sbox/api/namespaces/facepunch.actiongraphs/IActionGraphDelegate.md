# Facepunch.ActionGraphs.IActionGraphDelegate

Wrapper for an `Facepunch.ActionGraphs.ActionGraph` invokable as a delegate, with optional overridden input values.

- **Kind:** interface
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Properties

- `Facepunch.ActionGraphs.ActionGraph Graph`
  - Wrapped action graph.
- `System.Delegate Delegate`
  - Delegate that is implemented by `Facepunch.ActionGraphs.IActionGraphDelegate.Graph`, with default arguments supplied by `Facepunch.ActionGraphs.IActionGraphDelegate.Defaults`.
This delegate will remain up-to-date even if the wrapped graph is modified, or default argument dictionary changes.
- `System.Type DelegateType`
  - The type that `Facepunch.ActionGraphs.IActionGraphDelegate.Delegate` will contain when compiled.
- `System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object> Defaults`
  - Dictionary of default arguments for any graph input parameters that aren't supplied by delegate parameters.
