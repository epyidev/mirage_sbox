# Facepunch.ActionGraphs.NewInstanceNodeDefinition

- **Kind:** class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`
- **Base:** `Facepunch.ActionGraphs.NodeDefinition`

## Constructors

- `NewInstanceNodeDefinition(Facepunch.ActionGraphs.NodeLibrary nodeLibrary)`

## Properties

- `Facepunch.ActionGraphs.DisplayInfo DisplayInfo`
- `Facepunch.ActionGraphs.PropertyDefinition DeclaringType`
- `Facepunch.ActionGraphs.OutputDefinition Result`
- `Facepunch.ActionGraphs.NodeBinding DefaultBinding`

## Methods

### Instance methods

- `virtual System.Void OnClearReflectionCache()`
- `Facepunch.ActionGraphs.MethodBinder GetBinder(System.Type declaringType)`
- `virtual Facepunch.ActionGraphs.NodeBinding OnBind(Facepunch.ActionGraphs.BindingSurface surface)`
- `virtual System.Linq.Expressions.Expression OnBuildExpression(Facepunch.ActionGraphs.Compilation.INodeExpressionBuilder builder)`
