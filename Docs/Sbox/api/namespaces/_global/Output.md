# Facepunch.ActionGraphs.Node.Output

A named output of a node. Use `!:Input.SetLink(LinkSource)`,
or `!:Input.SetLinks(LinkSource[])` to connect this
output to an input.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Facepunch.ActionGraphs`
- **Base:** `Facepunch.ActionGraphs.Node.Parameter<T>`
- **Declaring type:** `Facepunch.ActionGraphs.Node`

## Constructors

- `Output()`

## Properties

- `System.Boolean IsSignal`
  - If true, this output emits signals that can trigger other nodes
to act.
- `System.Boolean IsPrimarySignal`
- `System.Collections.Generic.IReadOnlySet<Facepunch.ActionGraphs.Link> Links`
  - All links currently connected to this output.
- `System.Boolean IsLinked`
  - If true, this output has at least one connected input.

## Methods

### Instance methods

- `System.Boolean IsProvidedBy(Facepunch.ActionGraphs.Node.Output output)`
