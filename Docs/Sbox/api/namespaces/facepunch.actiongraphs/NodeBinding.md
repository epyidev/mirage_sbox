# Facepunch.ActionGraphs.NodeBinding

A collection of named node properties, inputs, and outputs with specific types, as
provided by a `Facepunch.ActionGraphs.NodeDefinition`. Bindings may depend on the property values
or currently linked input types of a node.

- **Kind:** class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Constructors

- `NodeBinding(Facepunch.ActionGraphs.DisplayInfo DisplayInfo, System.Collections.Generic.IReadOnlyCollection<Facepunch.ActionGraphs.PropertyDefinition> Properties, System.Collections.Generic.IReadOnlyCollection<Facepunch.ActionGraphs.InputDefinition> Inputs, System.Collections.Generic.IReadOnlyCollection<Facepunch.ActionGraphs.OutputDefinition> Outputs, System.Collections.Generic.IReadOnlyCollection<Facepunch.ActionGraphs.NodeBinding.ValidationMessage> Messages, System.Collections.Generic.IReadOnlyCollection<System.Attribute> Attributes, System.Boolean IsAsync, System.Object Target)`
- `NodeBinding(Facepunch.ActionGraphs.NodeBinding original)`

## Properties

- `System.Type EqualityContract`
- `Facepunch.ActionGraphs.DisplayInfo DisplayInfo`
  - Display information for the bound node.
- `System.Collections.Generic.IReadOnlyCollection<Facepunch.ActionGraphs.PropertyDefinition> Properties`
  - Named constant values stored in a node.
- `System.Collections.Generic.IReadOnlyCollection<Facepunch.ActionGraphs.InputDefinition> Inputs`
  - Named inputs that can be provided either from the outputs of other nodes, or with constant values.
- `System.Collections.Generic.IReadOnlyCollection<Facepunch.ActionGraphs.OutputDefinition> Outputs`
  - Named outputs that can be connected to the inputs of other nodes.
- `System.Collections.Generic.IReadOnlyCollection<Facepunch.ActionGraphs.NodeBinding.ValidationMessage> Messages`
  - Can contain warnings or errors if this binding isn't fully valid.
- `System.Collections.Generic.IReadOnlyCollection<System.Attribute> Attributes`
- `System.Boolean IsAsync`
- `System.Object Target`
  - Optional binding target data used by `Facepunch.ActionGraphs.NodeDefinition.BuildExpression(Facepunch.ActionGraphs.Compilation.INodeExpressionBuilder)`.
- `Facepunch.ActionGraphs.NodeKind Kind`
  - Is this node an action or an expression?

## Methods

### Static methods

- `static Facepunch.ActionGraphs.NodeBinding Create(Facepunch.ActionGraphs.DisplayInfo displayInfo, System.Collections.Generic.IEnumerable<Facepunch.ActionGraphs.PropertyDefinition> properties, System.Collections.Generic.IEnumerable<Facepunch.ActionGraphs.InputDefinition> inputs, System.Collections.Generic.IEnumerable<Facepunch.ActionGraphs.OutputDefinition> outputs, System.Collections.Generic.IEnumerable<Facepunch.ActionGraphs.NodeBinding.ValidationMessage> messages, System.Collections.Generic.IEnumerable<System.Attribute> attributes, System.Boolean isAsync, System.Object target)`
- `static Facepunch.ActionGraphs.NodeBinding CreateActionNode(Facepunch.ActionGraphs.DisplayInfo displayInfo)`
- `static Facepunch.ActionGraphs.NodeBinding FromDelegateType(System.Type delegateType, Facepunch.ActionGraphs.NodeLibrary nodeLibrary)`
- `static Facepunch.ActionGraphs.NodeBinding FromMethodBase(System.Reflection.MethodBase method, Facepunch.ActionGraphs.NodeLibrary nodeLibrary)`
- `static Facepunch.ActionGraphs.NodeBinding FromSerializedActionGraph(System.Text.Json.Nodes.JsonNode node, Facepunch.ActionGraphs.NodeLibrary nodeLibrary, System.Text.Json.JsonSerializerOptions options)`

### Instance methods

- `Facepunch.ActionGraphs.NodeBinding With(Facepunch.ActionGraphs.DisplayInfo display)`
- `Facepunch.ActionGraphs.NodeBinding Replace(Facepunch.ActionGraphs.IParameterDefinition[] parameters)`
- `Facepunch.ActionGraphs.NodeBinding With(Facepunch.ActionGraphs.NodeBinding.ValidationMessage[] messages)`
- `Facepunch.ActionGraphs.NodeBinding With(System.Collections.Generic.IReadOnlyCollection<Facepunch.ActionGraphs.NodeBinding.ValidationMessage> messages)`
- `Facepunch.ActionGraphs.NodeBinding With(Facepunch.ActionGraphs.IParameterDefinition[] parameters)`
- `Facepunch.ActionGraphs.NodeBinding Without(Facepunch.ActionGraphs.IParameterDefinition[] parameters)`
- `Facepunch.ActionGraphs.NodeBinding WithCompletesAfter(Facepunch.ActionGraphs.OutputDefinition[] outputs)`
- `Facepunch.ActionGraphs.NodeBinding WithTarget(System.Object target)`
- `virtual System.Boolean PrintMembers(System.Text.StringBuilder builder)`
- `virtual Facepunch.ActionGraphs.NodeBinding <Clone>$()`
- `System.Void Deconstruct(Facepunch.ActionGraphs.DisplayInfo DisplayInfo, System.Collections.Generic.IReadOnlyCollection<Facepunch.ActionGraphs.PropertyDefinition> Properties, System.Collections.Generic.IReadOnlyCollection<Facepunch.ActionGraphs.InputDefinition> Inputs, System.Collections.Generic.IReadOnlyCollection<Facepunch.ActionGraphs.OutputDefinition> Outputs, System.Collections.Generic.IReadOnlyCollection<Facepunch.ActionGraphs.NodeBinding.ValidationMessage> Messages, System.Collections.Generic.IReadOnlyCollection<System.Attribute> Attributes, System.Boolean IsAsync, System.Object Target)`
