# Sandbox.AnimationGraph

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Resource`

## Properties

- `System.Boolean IsValid`
- `System.Boolean IsError`
  - Whether the animation graph is invalid, or has not yet loaded.
- `System.String Name`
  - Animation graph file name.
- `System.Int32 ParamCount`
  - Number of parameters in this animgraph

## Methods

### Static methods

- `static Sandbox.AnimationGraph Load(System.String filename)`
  - Load an animation graph from given file.

### Instance methods

- `System.Type GetParameterType(System.Int32 index)`
  - Get value type of parameter at given index
- `System.Type GetParameterType(System.String name)`
  - Get value type of parameter with the given `name`, or `null` if not found.
- `System.String GetParameterName(System.Int32 index)`
  - Get name of parameter at given index
- `System.Boolean TryGetParameterIndex(System.String name, System.Int32 index)`
  - Try to get parameter index at given name
- `Sandbox.AnimParam<T> GetParameter(System.String name)`
  - Get parameter at given name
- `Sandbox.AnimParam<T> GetParameter(System.Int32 index)`
  - Get parameter at given index
