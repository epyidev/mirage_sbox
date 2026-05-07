# Facepunch.ActionGraphs.IMessageContext

Interface for action graph elements that can be the context of a `Facepunch.ActionGraphs.ValidationMessage`.

- **Kind:** interface
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Properties

- `Facepunch.ActionGraphs.ActionGraph ActionGraph`
  - Action graph this element belongs to.
- `Facepunch.ActionGraphs.IMessageContext Parent`
  - Parent element in the graph. Parents will list all validation messages of
their children.
- `System.String StackTraceIdentifier`
  - Unique identifier for this graph element in a stack trace.
