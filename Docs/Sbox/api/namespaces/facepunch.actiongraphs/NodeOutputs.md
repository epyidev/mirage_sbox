# Facepunch.ActionGraphs.NodeOutputs

Named outputs of a node, that may link to the inputs of other nodes.

- **Kind:** sealed class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`
- **Base:** `Facepunch.ActionGraphs.NodeParameters<T>`

## Properties

- `Facepunch.ActionGraphs.Node.Output Signal`
  - Used by `Facepunch.ActionGraphs.NodeKind.Action` nodes.
- `Facepunch.ActionGraphs.Node.Output Result`
  - Default output of most nodes that produce a single value.
- `System.Collections.Generic.IEnumerable<Facepunch.ActionGraphs.Link> Links`
  - All current links from outputs of this node.
