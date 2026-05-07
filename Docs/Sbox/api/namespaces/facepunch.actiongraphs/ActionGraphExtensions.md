# Facepunch.ActionGraphs.ActionGraphExtensions

Extension methods for action graphs.

- **Kind:** static class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Methods

### Static methods

- `static Facepunch.ActionGraphs.Node AddNode(Facepunch.ActionGraphs.INodeContainer graph, System.String id)`
  - Add a new node to this action graph with the given definition ID.
- `static Facepunch.ActionGraphs.Node AddNode(Facepunch.ActionGraphs.INodeContainer graph, T func)`
  - Add a new node to this action graph, defined by the given method. The method must be already included in `Facepunch.ActionGraphs.NodeLibrary`.
  - `graph`: Action graph to add a node to.
  - `func`: Method defining a node.
- `static Facepunch.ActionGraphs.Node AddNode(Facepunch.ActionGraphs.INodeContainer graph, System.Type declaringType, System.String methodName)`
  - Add a new node to this action graph, defined by the given method. The method must be already included in `Facepunch.ActionGraphs.NodeLibrary`.
- `static Facepunch.ActionGraphs.Node AddNode(Facepunch.ActionGraphs.INodeContainer graph, System.Linq.Expressions.ExpressionType expressionType)`
  - Adds a new node to this action graph, defined by the given expression type.
- `static Facepunch.ActionGraphs.Node AddVariableNode(Facepunch.ActionGraphs.INodeContainer graph, Facepunch.ActionGraphs.Variable variable, System.Nullable<Facepunch.ActionGraphs.AssignmentKind> kind)`
- `static Facepunch.ActionGraphs.Node AddConstantNode(Facepunch.ActionGraphs.INodeContainer graph, System.Object value)`
  - Add a new constant accessor node to this action graph.
- `static System.Collections.Generic.IReadOnlyList<Facepunch.ActionGraphs.Link> SetLinks(Facepunch.ActionGraphs.ActionGraph graph, Facepunch.ActionGraphs.Node.Input target, Facepunch.ActionGraphs.ILinkSource[] sources)`
- `static System.Threading.Tasks.Task<System.Nullable<Facepunch.ActionGraphs.CreateSubGraphResult>> CreateSubGraphAsync(Facepunch.ActionGraphs.ActionGraph graph, System.Collections.Generic.IEnumerable<Facepunch.ActionGraphs.Node> nodes, System.Text.Json.JsonSerializerOptions jsonOptions, Facepunch.ActionGraphs.ActionGraphExtensions.WriteSubGraphDelegate writeSubGraph)`
