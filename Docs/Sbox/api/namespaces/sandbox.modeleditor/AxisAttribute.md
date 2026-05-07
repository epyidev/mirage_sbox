# Sandbox.ModelEditor.AxisAttribute

Draws 3 line axis visualization, which can set up to be manipulated via gizmos. You can have multiple of these.

- **Kind:** attribute
- **Namespace:** `Sandbox.ModelEditor`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.ModelEditor.Internal.BaseTransformAttribute`

## Constructors

- `AxisAttribute()`

## Properties

- `System.String Enabled`
  - Internal name of a boolean key that dictates whether this helper should draw or not. If unset, will draw always.
- `System.Boolean ParentLine`
  - If set to true, when the node is selected a line will be drawn from the helper to the parent attachment/bone.

## Methods

### Instance methods

- `virtual System.Void AddKeys(System.Collections.Generic.Dictionary<System.String,System.Object> dict)`
