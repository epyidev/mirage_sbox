# Facepunch.ActionGraphs.Compilation.IOutputValue

Describes a node output in this scope. It can either have a local variable that gets
set during the body of its node, or a constant expression that gets defined during the body.

- **Kind:** interface
- **Namespace:** `Facepunch.ActionGraphs.Compilation`
- **Assembly:** `Facepunch.ActionGraphs`

## Methods

### Instance methods

- `virtual System.Linq.Expressions.ParameterExpression GetLocalVariable()`
- `virtual System.Void Define(System.Linq.Expressions.Expression expression)`
- `virtual System.Linq.Expressions.Expression Assign(System.Linq.Expressions.Expression expression)`
