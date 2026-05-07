# Facepunch.ActionGraphs.Node

The main building block of an action graph. Represents either an action or expression.
An action node has input and output signals, and will act only when receiving a signal.
Expression nodes have only input and output values, and will be evaluated lazily when
one of its outputs is requested.

- **Kind:** class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Properties

- `System.Int32 Id`
  - Unique id of this node in the containing `Facepunch.ActionGraphs.Node.ActionGraph`.
- `Facepunch.ActionGraphs.Node Parent`
  - Parent of a nested node.
- `System.Collections.Generic.IReadOnlyCollection<Facepunch.ActionGraphs.Node> Children`
  - Nodes that were created as children of this node.
- `Facepunch.ActionGraphs.NodeDefinition Definition`
  - Definition describing the behaviour and property / input / output bindings of this node.
- `Facepunch.ActionGraphs.DisplayInfo DisplayInfo`
  - Display information for this node.
- `System.Collections.Generic.IReadOnlyCollection<System.Attribute> Attributes`
  - Attributes provided by this node's current binding.
- `System.Text.Json.Nodes.JsonObject UserData`
  - Arbitrary named values stored in this node, which will be included during serialization.
Values must be serializable to JSON.
- `Facepunch.ActionGraphs.NodeProperties Properties`
  - Constant named values stored in this node.
- `Facepunch.ActionGraphs.NodeInputs Inputs`
  - Named inputs of this node, that may either link to the outputs of other nodes,
or be assigned a constant value.
- `Facepunch.ActionGraphs.NodeOutputs Outputs`
  - Named outputs of this node, that may link to the inputs of other nodes.
- `System.Collections.Generic.IEnumerable<Facepunch.ActionGraphs.Node.Property> VariableReferences`
  - All properties or links that reference a variable.
- `System.Collections.Generic.IEnumerable<Facepunch.ActionGraphs.Link> Links`
  - All current input and output links attached to this node.
- `Facepunch.ActionGraphs.ActionGraph ActionGraph`
  - Parent `Facepunch.ActionGraphs.Node.ActionGraph` of this node.
- `System.String StackTraceIdentifier`
- `System.Boolean IsValid`
  - Will become false if this node was removed from its action graph.
- `Facepunch.ActionGraphs.NodeLibrary NodeLibrary`
- `Facepunch.ActionGraphs.NodeBinding Binding`
- `Facepunch.ActionGraphs.NodeKind Kind`
  - Is this node an action or an expression?

## Methods

### Instance methods

- `virtual Facepunch.ActionGraphs.Node AddNode(Facepunch.ActionGraphs.NodeDefinition definition)`
- `System.Void MarkDirty()`
  - Notify the containing graph that this node needs updating.
- `System.Void Remove()`
  - Remove this node from the containing graph. Any links into or out of the
node will also be removed.
- `System.Void SetParameters(System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object> properties, System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object> inputs)`
- `System.Void UpdateParameters()`
  - Immediately update this node's binding based on its input types and property values.
