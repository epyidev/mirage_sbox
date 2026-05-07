# Facepunch.ActionGraphs.AccessorNodeDefinition<T>

Base class for nodes that get / set values.

- **Kind:** abstract class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`
- **Base:** `Facepunch.ActionGraphs.NodeDefinition`

## Constructors

- `AccessorNodeDefinition<T>(Facepunch.ActionGraphs.NodeLibrary nodeLibrary, System.String identifier)`

## Properties

- `Facepunch.ActionGraphs.InputDefinition InputSignal`
- `Facepunch.ActionGraphs.OutputDefinition OutputSignal`
- `Facepunch.ActionGraphs.InputDefinition Value`
- `Facepunch.ActionGraphs.OutputDefinition GetResult`
- `Facepunch.ActionGraphs.PropertyDefinition Kind`
- `Facepunch.ActionGraphs.NodeBinding DefaultBinding`
- `Facepunch.ActionGraphs.DisplayInfo DisplayInfo`
- `System.Boolean IsTrivial`
  - If true, don't bother storing the result in a local variable when accessing.

## Methods

### Instance methods

- `virtual System.Boolean HasSetConnections(Facepunch.ActionGraphs.BindingSurface surface, System.Nullable<Facepunch.ActionGraphs.AssignmentKind> kind, System.Type valueType)`
- `virtual System.Boolean HasGetConnections(Facepunch.ActionGraphs.BindingSurface surface)`
- `virtual System.Boolean TryResolveMember(Facepunch.ActionGraphs.BindingSurface surface, System.Nullable<Facepunch.ActionGraphs.AssignmentKind> kind, T member, System.Collections.Generic.List<Facepunch.ActionGraphs.NodeBinding.ValidationMessage> outMessages)`
- `virtual System.Type GetMemberType(T member)`
- `virtual System.Boolean CanRead(T member)`
- `virtual System.Boolean CanWrite(T member)`
- `virtual Facepunch.ActionGraphs.DisplayInfo GetDisplayInfo(T member)`
- `virtual System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(T member)`
- `virtual Facepunch.ActionGraphs.NodeBinding CreateAmbiguousBinding(T member)`
- `virtual Facepunch.ActionGraphs.NodeBinding CreateGetBinding(T member)`
- `virtual Facepunch.ActionGraphs.NodeBinding CreateSetBinding(T member, Facepunch.ActionGraphs.AssignmentKind kind, System.Type valueType)`
- `virtual Facepunch.ActionGraphs.NodeBinding OnBind(Facepunch.ActionGraphs.BindingSurface surface)`
- `virtual System.Linq.Expressions.Expression BuildAccessExpression(Facepunch.ActionGraphs.Compilation.INodeExpressionBuilder builder, T member)`
- `virtual System.Linq.Expressions.Expression OnBuildSetExpression(Facepunch.ActionGraphs.Compilation.INodeExpressionBuilder builder, System.Linq.Expressions.Expression access, System.Linq.Expressions.Expression value)`
- `virtual System.Linq.Expressions.Expression OnBuildExpression(Facepunch.ActionGraphs.Compilation.INodeExpressionBuilder builder)`
