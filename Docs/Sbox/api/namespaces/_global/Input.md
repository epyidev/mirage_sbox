# Facepunch.ActionGraphs.Node.Input

A named input of a node. Inputs can connect to outputs of other nodes,
or have a constant value. Use `!:SetLink(LinkSource)` to set which output
this input links to, or `!:SetLinks(LinkSource[])` if this input
can accept an array of values.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Facepunch.ActionGraphs`
- **Base:** `Facepunch.ActionGraphs.Node.Parameter<T>`
- **Declaring type:** `Facepunch.ActionGraphs.Node`

## Constructors

- `Input()`

## Properties

- `System.Boolean IsArray`
  - If true, this input accepts an array of values. Each element
can be connected to a different output with `Facepunch.ActionGraphs.Node.Input.InsertLink(Facepunch.ActionGraphs.ILinkSource,System.Int32)`
or `!:SetLinks(Output[])`.
- `System.Boolean IsSignal`
  - If true, this input receives a signal that will cause the parent node
to act.
- `System.Boolean IsPrimarySignal`
- `System.Boolean IsTarget`
- `System.Boolean IsLinked`
  - If true, this input is linked to an output.
- `System.Type SourceType`
  - Gets the type arriving in this input. Returns null if unlinked.
- `Facepunch.ActionGraphs.Link Link`
  - If this is linked to a single output, gets that link.
- `System.Collections.Generic.IReadOnlyList<Facepunch.ActionGraphs.Link> LinkArray`
  - If this is linked to an array of outputs, gets the connecting links.
- `System.Collections.Generic.IEnumerable<Facepunch.ActionGraphs.Link> Links`
  - Gets any links connected to this input.
- `System.Type ElementType`
  - For array input types, the type of an element of the array.
- `System.Object Value`
  - Constant source value for this input.

## Methods

### Instance methods

- `System.Int32 IndexOfLink(Facepunch.ActionGraphs.Link link)`
  - If this input is connected to an array of outputs, gets the index
of the given link in that array. Returns -1 if not found.
  - `link`: Link to get the index of.
- `System.Void ClearLinks()`
  - Removes all links from this input.
- `Facepunch.ActionGraphs.Link SetLink(Facepunch.ActionGraphs.ILinkSource source)`
  - Clears any existing links or constant value, and sets this input to be linked to the given output.
  - `source`: Output to link to.
- `Facepunch.ActionGraphs.Link SetLink(Facepunch.ActionGraphs.ILinkSource source, System.Int32 index)`
  - If this input accepts an array of links, replaces a link in that array to the given output.
  - `source`: Output to link to.
  - `index`: Index into the link array to set the link.
- `Facepunch.ActionGraphs.Link InsertLink(Facepunch.ActionGraphs.ILinkSource source, System.Int32 index)`
  - If this input accepts an array of links, inserts a link in that array to the given output.
  - `source`: Output to link to.
  - `index`: Index into the link array to insert the link.
- `System.Collections.Generic.IReadOnlyList<Facepunch.ActionGraphs.Link> SetLinks(Facepunch.ActionGraphs.ILinkSource[] sources)`
  - If this input accepts an array of links, clears any existing links or constant value and sets
this input to be linked to the given array of outputs.
  - `sources`: Array of outputs to link to.
- `System.Collections.Generic.IReadOnlyList<Facepunch.ActionGraphs.Link> SetLinks(System.Collections.Generic.IReadOnlyList<Facepunch.ActionGraphs.ILinkSource> sources)`
