# Facepunch.ActionGraphs.NodeInputs

Named inputs of a node, that may either link to the outputs of other nodes,
or be assigned a constant value.

- **Kind:** sealed class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`
- **Base:** `Facepunch.ActionGraphs.NodeParameters<T>`

## Properties

- `Facepunch.ActionGraphs.Node.Input Signal`
  - Used by `Facepunch.ActionGraphs.NodeKind.Action` nodes.
- `Facepunch.ActionGraphs.Node.Input Target`
  - Used by:
- `Facepunch.ActionGraphs.NodeLibrary.Property`- `Facepunch.ActionGraphs.NodeLibrary.CallMethod`
- `Facepunch.ActionGraphs.Node.Input Result`
  - Used by:
- `Facepunch.ActionGraphs.NodeLibrary.Output`
- `Facepunch.ActionGraphs.Node.Input Value`
  - Used by:
- `Facepunch.ActionGraphs.NodeLibrary.Property`- `!:NodeLibrary.SetVar`
- `System.Collections.Generic.IEnumerable<Facepunch.ActionGraphs.Link> Links`
  - All current links into inputs of this node.
