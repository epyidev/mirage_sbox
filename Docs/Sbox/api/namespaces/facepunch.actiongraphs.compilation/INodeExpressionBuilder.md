# Facepunch.ActionGraphs.Compilation.INodeExpressionBuilder

- **Kind:** interface
- **Namespace:** `Facepunch.ActionGraphs.Compilation`
- **Assembly:** `Facepunch.ActionGraphs`

## Properties

- `Facepunch.ActionGraphs.Node Node`
- `Facepunch.ActionGraphs.NodeBinding Binding`
- `Facepunch.ActionGraphs.ActionGraph ActionGraph`

## Methods

### Instance methods

- `virtual System.Linq.Expressions.ParameterExpression CreateLocal(System.Type type, System.String name)`
- `virtual System.Linq.Expressions.Expression GetVariableValue(Facepunch.ActionGraphs.Variable variable)`
- `virtual System.Linq.Expressions.Expression GetPropertyValue(Facepunch.ActionGraphs.Node.Property property)`
- `virtual System.Linq.Expressions.Expression GetInputValue(Facepunch.ActionGraphs.Node.Input input)`
- `virtual System.Linq.Expressions.LambdaExpression GetInputValueFunc(Facepunch.ActionGraphs.Node.Input input)`
- `virtual Facepunch.ActionGraphs.Compilation.IOutputValue GetOutputValue(Facepunch.ActionGraphs.Node.Output valueOutput)`
- `virtual Facepunch.ActionGraphs.Compilation.IOutputValue GetOutputValue(Facepunch.ActionGraphs.Node.Output signalOutput, Facepunch.ActionGraphs.Node.Output valueOutput)`
- `virtual System.Linq.Expressions.Expression RunOutputSignal(Facepunch.ActionGraphs.Node.Output signalOutput)`
