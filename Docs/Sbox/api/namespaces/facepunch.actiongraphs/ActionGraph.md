# Facepunch.ActionGraphs.ActionGraph

Represents an async method as a directed graph. Control will enter through an "event" node, which
can route signals through a network of other nodes that perform actions.
Use `Facepunch.ActionGraphs.ActionGraph.CreateEmpty(Facepunch.ActionGraphs.NodeLibrary)` to create a completely blank graph, or `Facepunch.ActionGraphs.ActionGraph.CreateDelegate``1(Facepunch.ActionGraphs.NodeLibrary)`
to create a graph that handles an event matching the signature of a particular delegate.

- **Kind:** class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Properties

- `Facepunch.ActionGraphs.InputDefinition TargetDefinition`
  - The definition of the graph input that represents the target of the graph.
- `Facepunch.ActionGraphs.Node.Output TargetOutput`
  - The output of the graph's entry node that represents the target of the graph.
- `Facepunch.ActionGraphs.ISourceLocation SourceLocation`
  - Identifies where this instance was deserialized from.
- `System.String Title`
- `System.String Description`
- `System.String Category`
- `System.String Icon`
- `System.String[] Tags`
- `System.Guid Guid`
- `Facepunch.ActionGraphs.NodeLibrary NodeLibrary`
  - Library of node definitions available for use by this action graph.
- `System.Collections.Generic.IReadOnlyDictionary<System.Int32,Facepunch.ActionGraphs.Node> Nodes`
  - Set of nodes added to this action graph.
- `System.Collections.Generic.IReadOnlySet<Facepunch.ActionGraphs.Link> Links`
  - Set of links added between nodes in this action graph.
- `System.Collections.Generic.IReadOnlyDictionary<System.String,Facepunch.ActionGraphs.Variable> Variables`
  - Set of variables added to this action graph.
- `System.Text.Json.Nodes.JsonObject UserData`
  - Arbitrary named values stored in this action graph, which will be included during serialization.
Values must be serializable to JSON.
- `Facepunch.ActionGraphs.Node InputNode`
  - Entry point of the graph.
- `Facepunch.ActionGraphs.Node PrimaryOutputNode`
  - Primary output of the graph.
- `System.Collections.Generic.IEnumerable<Facepunch.ActionGraphs.Node> OutputNodes`
  - Nodes that emit return values or output signals from this graph to the caller.
- `System.Collections.Generic.IReadOnlyDictionary<System.String,Facepunch.ActionGraphs.InputDefinition> Inputs`
- `System.Collections.Generic.IReadOnlyDictionary<System.String,Facepunch.ActionGraphs.OutputDefinition> Outputs`
- `Facepunch.ActionGraphs.DisplayInfo DisplayInfo`
- `System.String StackTraceIdentifier`
- `Facepunch.ActionGraphs.NodeKind Kind`
- `static Facepunch.ActionGraphs.SerializationOptions SerializationOptions`
- `System.Int32 ChangeId`
  - Increments each time this graph re-validates after a change.
- `System.Collections.Generic.IReadOnlyCollection<Facepunch.ActionGraphs.ValidationMessage> Messages`

## Fields

- `static System.Int32 CurrentFormatVersion`

## Methods

### Static methods

- `static Facepunch.ActionGraphs.ActionGraph CreateEmpty(Facepunch.ActionGraphs.NodeLibrary nodeLibrary)`
  - Creates a completely blank action graph. This won't be invokable until an event node is added.
  - `nodeLibrary`: Source of node definitions for the new action graph.
- `static Facepunch.ActionGraphs.IActionGraphDelegate CreateDelegate(Facepunch.ActionGraphs.NodeLibrary nodeLibrary, System.Type delegateType)`
  - Creates an action graph with an event node matching the signature of `delegateType`.
  - `nodeLibrary`: Source of node definitions for the new action graph.
  - `delegateType`: Delegate type to match the signature of.
- `static Facepunch.ActionGraphs.ActionGraphDelegate<T> CreateDelegate(Facepunch.ActionGraphs.NodeLibrary nodeLibrary)`
  - Creates an action graph with an event node matching the signature of delegate type `T`.
  - `nodeLibrary`: Source of node definitions for the new action graph.
- `static Facepunch.ActionGraphs.ActionGraph.SerializationOptionsScope PushSerializationOptions(Facepunch.ActionGraphs.SerializationOptions options)`
- `static Facepunch.ActionGraphs.ActionGraph.SerializationOptionsScope PushTarget(Facepunch.ActionGraphs.InputDefinition value)`
- `static Facepunch.ActionGraphs.ActionGraph.SerializationOptionsScope PushCache(Facepunch.ActionGraphs.IActionGraphCache value, System.Boolean writeReferences)`
- `static Facepunch.ActionGraphs.ActionGraph.SerializationOptionsScope PushSourceLocation(Facepunch.ActionGraphs.ISourceLocation value)`
- `static Facepunch.ActionGraphs.ActionGraph.SerializationOptionsScope PushGuidMap(System.Collections.Generic.IReadOnlyDictionary<System.Guid,System.Guid> value)`
- `static Facepunch.ActionGraphs.ActionGraph.SerializationOptionsScope PushWriteCacheReferences(System.Boolean value)`
- `static Facepunch.ActionGraphs.ActionGraph.SerializationOptionsScope PushMakeGuidsUnique(System.Boolean value)`

### Instance methods

- `virtual Facepunch.ActionGraphs.Node AddNode(Facepunch.ActionGraphs.NodeDefinition definition)`
  - Add a new node to this action graph, with the given `definition`.
  - `definition`: Definition describing the properties, inputs and outputs of a node.
- `Facepunch.ActionGraphs.Node AddNode(Facepunch.ActionGraphs.NodeDefinition definition, Facepunch.ActionGraphs.Node parent)`
  - Add a new node to this action graph, with the given `definition`.
  - `definition`: Definition describing the properties, inputs and outputs of a node.
  - `parent`: Optional parent node to create a child for.
- `System.Void RemoveNode(Facepunch.ActionGraphs.Node node)`
  - Remove a node from this action graph. Any links into or out of the node will also be removed.
  - `node`: Node to remove.
- `Facepunch.ActionGraphs.Variable AddVariable(System.String name, System.Type type, System.Object defaultValue)`
- `System.Void RemoveVariable(Facepunch.ActionGraphs.Variable variable)`
- `Facepunch.ActionGraphs.Link SetLink(Facepunch.ActionGraphs.Node.Input target, Facepunch.ActionGraphs.ILinkSource source)`
- `Facepunch.ActionGraphs.Link SetLink(Facepunch.ActionGraphs.Node.Input target, Facepunch.ActionGraphs.ILinkSource source, System.Int32 index)`
- `Facepunch.ActionGraphs.Link InsertLink(Facepunch.ActionGraphs.Node.Input target, Facepunch.ActionGraphs.ILinkSource source, System.Int32 index)`
- `System.Collections.Generic.IReadOnlyList<Facepunch.ActionGraphs.Link> SetLinks(Facepunch.ActionGraphs.Node.Input target, System.Collections.Generic.IEnumerable<Facepunch.ActionGraphs.ILinkSource> sources)`
- `System.Void RemoveLink(Facepunch.ActionGraphs.Link link)`
- `System.Void AddRequiredNodes()`
- `System.Void RemoveUnusedChildNodes()`
- `System.Linq.Expressions.LambdaExpression BuildExpression()`
  - Builds a `System.Linq.Expressions.LambdaExpression` that implements this graph.
- `System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object> Evaluate(System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object> inputs)`
- `System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object>> InvokeAsync(System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object> inputs, System.Collections.Generic.IReadOnlyDictionary<System.String,Facepunch.ActionGraphs.Compilation.OutputDelegate> outputs)`
- `Facepunch.ActionGraphs.ActionGraphDelegate<T> CreateDelegate(System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object> defaults)`
- `Facepunch.ActionGraphs.IActionGraphDelegate CreateDelegate(System.Type delegateType, System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object> defaults)`
- `System.Collections.Generic.IEnumerable<Facepunch.ActionGraphs.IActionGraphDelegate> GetDelegates()`
  - Gets all known `Facepunch.ActionGraphs.IActionGraphDelegate`s created from this graph.
- `System.Void SetParameters(System.Collections.Generic.IReadOnlyCollection<Facepunch.ActionGraphs.InputDefinition> inputs, System.Collections.Generic.IReadOnlyCollection<Facepunch.ActionGraphs.OutputDefinition> outputs)`
- `System.Void SetParameters(Facepunch.ActionGraphs.NodeBinding binding)`
- `System.String Serialize(System.Collections.Generic.IEnumerable<Facepunch.ActionGraphs.Node> nodes, System.Text.Json.JsonSerializerOptions options)`
- `System.Text.Json.Nodes.JsonNode SerializeToNode(System.Collections.Generic.IEnumerable<Facepunch.ActionGraphs.Node> nodes, System.Text.Json.JsonSerializerOptions options)`
- `Facepunch.ActionGraphs.InsertResult DeserializeInsert(System.String json, System.Text.Json.JsonSerializerOptions options)`
- `Facepunch.ActionGraphs.InsertResult DeserializeInsert(System.Text.Json.Nodes.JsonNode json, System.Text.Json.JsonSerializerOptions options)`
- `System.Void Deserialize(System.String json, System.Type delegateType, System.Text.Json.JsonSerializerOptions options)`
  - Restore a previously serialized graph from JSON in this instance.
  - `json`: Serialized action graph.
  - `delegateType`: Optional delegate type, must match the one used when serializing.
  - `options`: Optional serializer options.
- `System.Boolean CanCreateSubGraph(System.Collections.Generic.IEnumerable<Facepunch.ActionGraphs.Node> nodes)`
- `System.Threading.Tasks.Task<System.Nullable<Facepunch.ActionGraphs.CreateSubGraphResult>> CreateSubGraphAsync(System.Collections.Generic.IEnumerable<Facepunch.ActionGraphs.Node> nodes, System.Text.Json.JsonSerializerOptions jsonOptions, Facepunch.ActionGraphs.CreateSubGraphNodeDelegate createSubGraphNode)`
- `System.Void Validate(System.Boolean force)`
- `System.Void ClearChanges()`
  - Don't increment `Facepunch.ActionGraphs.ActionGraph.ChangeId` during next validation.
