# Facepunch.ActionGraphs.NodeDefinition

Describes the behaviour and bindings of a node for use in an action graph.

- **Kind:** abstract class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Constructors

- `NodeDefinition(Facepunch.ActionGraphs.NodeLibrary nodeLibrary, System.String identifier)`
  - Describes the behaviour and bindings of a node for use in an action graph.
  - `nodeLibrary`: Node library that will contain this node definition.
  - `identifier`: Unique identifier of this node definition.

## Properties

- `Facepunch.ActionGraphs.NodeLibrary NodeLibrary`
  - Node library containing this node definition.
- `System.String Identifier`
  - Unique identifier of this node definition.
- `Facepunch.ActionGraphs.DisplayInfo DisplayInfo`
  - Title, description, and categorizing information about the node definition.
- `System.Collections.Generic.IReadOnlyCollection<System.Attribute> Attributes`
  - Attributes attached to this node definition.
- `System.Boolean IsObsolete`
  - True if this definition has an `System.ObsoleteAttribute`.

## Methods

### Instance methods

- `Facepunch.ActionGraphs.NodeBinding Bind(Facepunch.ActionGraphs.BindingSurface surface)`
  - Attempts to get a binding based on property values and input types. Bindings are
typed sets of named properties, inputs, and outputs. If a valid binding wasn't found,
the result will contain messages explaining why.
- `virtual Facepunch.ActionGraphs.NodeBinding OnBind(Facepunch.ActionGraphs.BindingSurface surface)`
- `virtual System.Linq.Expressions.Expression OnBuildExpression(Facepunch.ActionGraphs.Compilation.INodeExpressionBuilder builder)`
- `virtual System.Void OnDefaultBindingsInvalidated()`
- `virtual System.Void OnClearReflectionCache()`
