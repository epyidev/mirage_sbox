# Facepunch.ActionGraphs.DelegateExtensions

- **Kind:** static class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Methods

### Static methods

- `static Facepunch.ActionGraphs.IActionGraphDelegate GetActionGraphInstance(System.Delegate func)`
  - If the given delegate is implemented as exactly one `Facepunch.ActionGraphs.ActionGraph`,
get that graph and any input value overrides.
- `static Facepunch.ActionGraphs.ActionGraphDelegate<T> GetActionGraphInstance(T func)`
  - If the given delegate is implemented as exactly one `Facepunch.ActionGraphs.ActionGraph`,
get that graph and any input value overrides.
- `static System.Collections.Generic.IReadOnlyList<Facepunch.ActionGraphs.IActionGraphDelegate> GetActionGraphInstances(System.Delegate func)`
  - If the given delegate is implemented as one or more `Facepunch.ActionGraphs.ActionGraph`s,
get those graphs and their input value overrides.
- `static System.Collections.Generic.IReadOnlyList<Facepunch.ActionGraphs.ActionGraphDelegate<T>> GetActionGraphInstances(T func)`
  - If the given delegate is implemented as one or more `Facepunch.ActionGraphs.ActionGraph`s,
get those graphs and their input value overrides.
