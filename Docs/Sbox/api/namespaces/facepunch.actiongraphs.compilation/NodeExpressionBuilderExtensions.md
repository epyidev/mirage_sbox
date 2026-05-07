# Facepunch.ActionGraphs.Compilation.NodeExpressionBuilderExtensions

- **Kind:** static class
- **Namespace:** `Facepunch.ActionGraphs.Compilation`
- **Assembly:** `Facepunch.ActionGraphs`

## Methods

### Static methods

- `static T GetBindingTarget(Facepunch.ActionGraphs.Compilation.INodeExpressionBuilder builder)`
- `static System.Linq.Expressions.Expression GetPropertyValue(Facepunch.ActionGraphs.Compilation.INodeExpressionBuilder builder, System.String name)`
- `static System.Linq.Expressions.Expression GetPropertyValue(Facepunch.ActionGraphs.Compilation.INodeExpressionBuilder builder, Facepunch.ActionGraphs.PropertyDefinition def)`
- `static System.Linq.Expressions.Expression GetInputValue(Facepunch.ActionGraphs.Compilation.INodeExpressionBuilder builder, System.String name)`
- `static System.Linq.Expressions.Expression GetInputValue(Facepunch.ActionGraphs.Compilation.INodeExpressionBuilder builder, Facepunch.ActionGraphs.InputDefinition def)`
- `static System.Linq.Expressions.LambdaExpression GetInputValueFunc(Facepunch.ActionGraphs.Compilation.INodeExpressionBuilder builder, System.String name)`
- `static System.Linq.Expressions.LambdaExpression GetInputValueFunc(Facepunch.ActionGraphs.Compilation.INodeExpressionBuilder builder, Facepunch.ActionGraphs.InputDefinition def)`
- `static Facepunch.ActionGraphs.Compilation.IOutputValue GetOutputValue(Facepunch.ActionGraphs.Compilation.INodeExpressionBuilder builder)`
- `static Facepunch.ActionGraphs.Compilation.IOutputValue GetOutputValue(Facepunch.ActionGraphs.Compilation.INodeExpressionBuilder builder, System.String name)`
- `static Facepunch.ActionGraphs.Compilation.IOutputValue GetOutputValue(Facepunch.ActionGraphs.Compilation.INodeExpressionBuilder builder, Facepunch.ActionGraphs.OutputDefinition def)`
- `static Facepunch.ActionGraphs.Compilation.IOutputValue GetOutputValue(Facepunch.ActionGraphs.Compilation.INodeExpressionBuilder builder, System.String signalName, System.String valueName)`
- `static Facepunch.ActionGraphs.Compilation.IOutputValue GetOutputValue(Facepunch.ActionGraphs.Compilation.INodeExpressionBuilder builder, Facepunch.ActionGraphs.OutputDefinition signalDef, Facepunch.ActionGraphs.OutputDefinition valueDef)`
- `static System.Linq.Expressions.Expression RunOutputSignal(Facepunch.ActionGraphs.Compilation.INodeExpressionBuilder builder, System.String name)`
- `static System.Linq.Expressions.Expression RunOutputSignal(Facepunch.ActionGraphs.Compilation.INodeExpressionBuilder builder, Facepunch.ActionGraphs.OutputDefinition def)`
