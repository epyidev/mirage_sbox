# Facepunch.ActionGraphs.Node.Property

A named constant value stored inside a node.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Facepunch.ActionGraphs`
- **Base:** `Facepunch.ActionGraphs.Node.Parameter<T>`
- **Declaring type:** `Facepunch.ActionGraphs.Node`

## Constructors

- `Property()`

## Properties

- `System.Boolean IsVariable`
  - If true, this property references a `Facepunch.ActionGraphs.Variable`.
- `System.Object Value`
  - Constant value assigned to this parameter.

## Methods

### Instance methods

- `System.Boolean TryGetValue(System.Object value)`
  - Attempts to get either the current assigned value, or default value
for optional properties. Returns false if this property is required
and has no assigned value.
  - `value`: Current assigned or default value.
  - returns: True if this node has an assigned or default value.
- `System.Object GetValueOrDefault()`
  - Attempts to get either the current assigned value, or default value
for optional properties. Throws an exception if this property is
required and has no assigned value.
- `T GetValueOrDefault()`
  - Attempts to get either the current assigned value, or default value
for optional properties. Throws an exception if this property is
required and has no assigned value, or the assigned value is the
wrong type.
