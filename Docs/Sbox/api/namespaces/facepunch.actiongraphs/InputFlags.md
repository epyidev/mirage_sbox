# Facepunch.ActionGraphs.InputFlags

- **Kind:** enum
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`
- **Base:** `System.Enum`

## Values

- `Missing`
- `Required`
- `Primary`
- `Target` - This input represents the `this` parameter of a method.
- `NotAlwaysAccessed` - This input is conditionally accessed, so its source should be lazily evaluated.
- `NoCaching` - This input should be evaluated each time it is accessed, instead of being cached.
