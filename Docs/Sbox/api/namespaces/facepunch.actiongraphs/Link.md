# Facepunch.ActionGraphs.Link

A link connects one `Facepunch.ActionGraphs.Node.Input` to a `Facepunch.ActionGraphs.Node.Output`.
They can either transmit values or signals. A signal will trigger the receiving
node to act when the sending node fires its output.

- **Kind:** sealed class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Properties

- `Facepunch.ActionGraphs.Node.Input Target`
  - The receiving node's input.
- `Facepunch.ActionGraphs.Node.Output Source`
  - Where this link retrieves its value from.
- `Facepunch.ActionGraphs.ActionGraph ActionGraph`
  - The action graph containing this link.
- `System.Boolean IsSignal`
  - If true, this link will transmit a signal from an action
node to another.
- `System.Type Type`
  - The value type being transmitted by the link.
- `System.Type TargetType`
  - The value type the target requires from this link.
- `System.Boolean IsArrayElement`
  - If true, this link is supplying one element of an input that
accepts an array.
- `System.Int32 ArrayIndex`
  - If `Facepunch.ActionGraphs.Link.IsArrayElement` is true, this is the index
of the element in the receiving array.
- `System.Text.Json.Nodes.JsonObject UserData`
  - Arbitrary named values stored in this link, which will be included during
serialization. Values must be serializable to JSON.
- `System.Boolean IsNestedInput`
- `System.Boolean IsValid`
  - Becomes false when this link is removed.
- `System.String StackTraceIdentifier`

## Methods

### Instance methods

- `System.Void Remove()`
  - Remove this link from the action graph, disconnecting it from
the source and target.
- `System.Boolean TryGetConstant(System.Object value)`
  - If this link is from a `Facepunch.ActionGraphs.Constant` source, return true
and output the constant value.
- `System.Boolean TryGetVariable(Facepunch.ActionGraphs.Variable variable)`
  - If this link is from a `Facepunch.ActionGraphs.Variable` source, return true
and output the referenced variable.
