# Facepunch.ActionGraphs.Variable

Variables have a name and type, and are local to each invocation of an `Facepunch.ActionGraphs.Variable.ActionGraph`.
They are assigned with a `!:NodeLibrary.SetVar` node, and read with `!:NodeLibrary.GetVar`.

- **Kind:** class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Properties

- `System.String Name`
  - The name of this variable, unique in its action graph.
- `System.Type Type`
  - Value type stored in this variable.
- `System.Object DefaultValue`
  - Initial value of the variable before being assigned.
- `System.Text.Json.Nodes.JsonObject UserData`
  - Arbitrary named values stored in this variable, which will be included during
serialization. Values must be serializable to JSON.
- `System.Collections.Generic.IEnumerable<Facepunch.ActionGraphs.Node.Property> References`
  - All node properties that currently reference this variable.
- `Facepunch.ActionGraphs.ActionGraph ActionGraph`
  - The action graph this variable belongs to.
- `System.String StackTraceIdentifier`
- `System.Boolean IsValid`
  - Becomes false when this variable is removed.

## Methods

### Instance methods

- `System.Void Remove()`
  - Remove this variable from its action graph.
This will clear any references to it.
