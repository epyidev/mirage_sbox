# Sandbox.ActionGraphs.GameResourceSourceLocation

Source location for action graphs that belong to a `Sandbox.GameResource`.
These can include scenes and prefabs, or custom resources. This is used for stack
traces, and for knowing which asset to save when editing a graph.

- **Kind:** class
- **Namespace:** `Sandbox.ActionGraphs`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `GameResourceSourceLocation(Sandbox.GameResource Resource)`
  - Source location for action graphs that belong to a `Sandbox.GameResource`.
These can include scenes and prefabs, or custom resources. This is used for stack
traces, and for knowing which asset to save when editing a graph.
  - `Resource`: Resource that contains action graphs.
- `GameResourceSourceLocation(Sandbox.ActionGraphs.GameResourceSourceLocation original)`

## Properties

- `System.Type EqualityContract`
- `Sandbox.GameResource Resource`
  - Resource that contains action graphs.

## Methods

### Instance methods

- `virtual System.Boolean PrintMembers(System.Text.StringBuilder builder)`
- `virtual Sandbox.ActionGraphs.GameResourceSourceLocation <Clone>$()`
- `System.Void Deconstruct(Sandbox.GameResource Resource)`
