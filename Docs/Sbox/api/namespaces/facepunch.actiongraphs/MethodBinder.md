# Facepunch.ActionGraphs.MethodBinder

- **Kind:** class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Constructors

- `MethodBinder(Facepunch.ActionGraphs.NodeLibrary library)`

## Properties

- `Facepunch.ActionGraphs.NodeLibrary Library`
- `System.Int32 OverloadCount`

## Methods

### Instance methods

- `System.Void AddOverload(System.Reflection.MethodBase method)`
- `System.Boolean RemoveOverloads(System.Reflection.Assembly assembly)`
- `Facepunch.ActionGraphs.NodeBinding Bind(System.Reflection.MethodBase method)`
  - Given a method, returns a node binding specifying
which properties, inputs and outputs the method has.
- `Facepunch.ActionGraphs.NodeBinding Bind(Facepunch.ActionGraphs.BindingSurface surface)`
- `System.Linq.Expressions.Expression BuildExpression(Facepunch.ActionGraphs.Compilation.INodeExpressionBuilder builder)`
