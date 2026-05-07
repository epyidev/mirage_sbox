# Facepunch.ActionGraphs.MethodCallNodeDefinition

- **Kind:** class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`
- **Base:** `Facepunch.ActionGraphs.NodeDefinition`

## Constructors

- `MethodCallNodeDefinition(Facepunch.ActionGraphs.NodeLibrary nodeLibrary)`

## Properties

- `Facepunch.ActionGraphs.DisplayInfo DisplayInfo`
- `Facepunch.ActionGraphs.InputDefinition InputSignal`
- `Facepunch.ActionGraphs.OutputDefinition OutputSignal`
- `Facepunch.ActionGraphs.PropertyDefinition DeclaringType`
- `Facepunch.ActionGraphs.PropertyDefinition MemberName`
- `Facepunch.ActionGraphs.PropertyDefinition IsStatic`
- `Facepunch.ActionGraphs.InputDefinition Target`
- `Facepunch.ActionGraphs.NodeBinding DefaultBinding`

## Methods

### Instance methods

- `virtual System.Void OnClearReflectionCache()`
- `Facepunch.ActionGraphs.MethodBinder GetBinder(System.Reflection.MethodInfo method)`
- `virtual Facepunch.ActionGraphs.NodeBinding OnBind(Facepunch.ActionGraphs.BindingSurface surface)`
- `virtual System.Linq.Expressions.Expression OnBuildExpression(Facepunch.ActionGraphs.Compilation.INodeExpressionBuilder builder)`
