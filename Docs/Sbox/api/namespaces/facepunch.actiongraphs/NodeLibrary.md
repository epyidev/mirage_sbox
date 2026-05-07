# Facepunch.ActionGraphs.NodeLibrary

Contains a library of `Facepunch.ActionGraphs.NodeDefinition`s, each with a unique identifier.
Custom node definitions can be added with `Facepunch.ActionGraphs.NodeLibrary.Add(Facepunch.ActionGraphs.NodeDefinition)`, or from methods marked with
either `!:ActionNodeAttribute` or `!:ExpressionNodeAttribute` when
using `Facepunch.ActionGraphs.NodeLibrary.AddAssembly(System.Reflection.Assembly)`.

- **Kind:** sealed class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Constructors

- `NodeLibrary(Facepunch.ActionGraphs.ITypeLoader typeLoader, Facepunch.ActionGraphs.IGraphLoader graphLoader)`
  - Contains a library of `Facepunch.ActionGraphs.NodeDefinition`s, each with a unique identifier.
An `Facepunch.ActionGraphs.ITypeLoader` is required to wrap reflection methods. Use an `Facepunch.ActionGraphs.DefaultTypeLoader`
if no access control is needed.

## Properties

- `System.Collections.Generic.IReadOnlyDictionary<System.String,Facepunch.ActionGraphs.NodeDefinition> All`
  - Dictionary of all added definitions, indexed by their `Facepunch.ActionGraphs.NodeDefinition.Identifier`s.
- `Facepunch.ActionGraphs.NodeDefinition Input`
  - Node definition for the entry point of the graph. Each graph can only have one such entry point.
- `Facepunch.ActionGraphs.NodeDefinition InputValue`
  - Helper node for accessing a graph input parameter.
- `Facepunch.ActionGraphs.NodeDefinition Output`
  - Node definition for output signals of the graph. Each graph can have at most one primary output.
- `Facepunch.ActionGraphs.NodeDefinition Graph`
  - A node implemented by an action graph.
- `Facepunch.ActionGraphs.NodeDefinition Variable`
  - Node definition for getting or setting `Facepunch.ActionGraphs.NodeLibrary.Variable` values.
- `Facepunch.ActionGraphs.NodeDefinition Constant`
  - Node definition for providing constant values.
- `Facepunch.ActionGraphs.NodeDefinition Property`
  - Node definition for getting or setting static or instance properties.
- `Facepunch.ActionGraphs.NodeDefinition CallMethod`
  - Node definition for calling a named method.
- `Facepunch.ActionGraphs.NodeDefinition NewInstance`
  - Node definition for calling a constructor to create an instance.
- `Facepunch.ActionGraphs.NodeDefinition NoOperation`
  - A node that does nothing, just forwards an input to its output.
- `Facepunch.ActionGraphs.NodeDefinition Comment`
  - A node with no inputs or outputs, only metadata. Useful for holding documentation.
- `Facepunch.ActionGraphs.ITypeLoader TypeLoader`
- `Facepunch.ActionGraphs.IGraphLoader GraphLoader`

## Methods

### Instance methods

- `System.Void Add(Facepunch.ActionGraphs.NodeDefinition definition)`
  - Add a custom node definition. The `Facepunch.ActionGraphs.NodeDefinition.Identifier` must be unique
in this library. See also `Facepunch.ActionGraphs.NodeLibrary.AddAssembly(System.Reflection.Assembly)` for an easier way to implement custom nodes.
  - `definition`: Custom node definition to add.
- `System.Void ClearReflectionCache()`
- `Facepunch.ActionGraphs.AddAssemblyResult AddAssembly(System.Reflection.Assembly asm)`
  - Adds a node definition for each method annotated with either `!:ActionNodeAttribute` or
`Facepunch.ActionGraphs.ExpressionNodeDefinition` in the given assembly.
- `System.Boolean RemoveAssembly(System.Reflection.Assembly assembly)`
- `Facepunch.ActionGraphs.NodeDefinition Get(System.String identifier)`
  - Gets a node definition by identifier. Returns null if not found.
  - `identifier`: Unique identifier of the node definition to find.
- `Facepunch.ActionGraphs.NodeDefinition Get(T func)`
  - Gets a node definition by the method that implements it. Method must already
be added with `Facepunch.ActionGraphs.NodeLibrary.AddAssembly(System.Reflection.Assembly)`.
- `Facepunch.ActionGraphs.NodeDefinition Get(System.Type declaringType, System.String methodName)`
- `Facepunch.ActionGraphs.NodeDefinition Get(System.Reflection.MethodInfo method)`
- `Facepunch.ActionGraphs.NodeDefinition Get(System.Linq.Expressions.ExpressionType expressionType)`
  - Gets a node definition by the operator it implements.
  - `expressionType`: Operator of the node definition to find.
- `System.Void InvalidateDefaultBindings()`
- `System.Void Reset()`
  - Removes all custom node definitions from this library.
- `System.Boolean IsPure(System.Reflection.MethodBase method)`
  - Returns true if the given method has been marked as pure. Pure methods
have no (visible) side effects, and so can be turned into expression nodes.
  - `method`: Method to test.
- `System.Boolean IsProperty(System.Reflection.ParameterInfo parameter)`
  - Returns true if the given parameter should be a property on a node, rather than
an input or output.
  - `parameter`: Parameter to test.
- `System.Boolean IsTarget(System.Reflection.ParameterInfo parameter)`
- `System.Boolean CanCacheType(System.Type type)`
- `System.Collections.Generic.IEnumerable<Facepunch.ActionGraphs.ActionGraph> GetGraphs()`
  - Gets all existing graphs created with this `Facepunch.ActionGraphs.NodeLibrary`.
- `System.Collections.Generic.IEnumerable<Facepunch.ActionGraphs.ActionGraph> GetGraphs(System.Guid guid)`
  - Gets all existing graphs created with this `Facepunch.ActionGraphs.NodeLibrary` with the given `guid`.
