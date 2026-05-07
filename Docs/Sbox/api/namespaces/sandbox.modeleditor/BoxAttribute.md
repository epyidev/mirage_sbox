# Sandbox.ModelEditor.BoxAttribute

Draws a box, which can be manipulated via gizmos. You can have multiple of these.

- **Kind:** attribute
- **Namespace:** `Sandbox.ModelEditor`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.ModelEditor.Internal.BaseTransformAttribute`

## Constructors

- `BoxAttribute(System.String dimensionsKey)`
  - Store the box's dimensions in a single key, acting as (maxs-mins) which assumes the box's center is at the models origin.
The box's center can be set up to be movable via "Origin" property and rotatable via "Angles" property.
  - `dimensionsKey`: Internal name of a key on the node that will store the dimensions of the box.
- `BoxAttribute(System.String minsKey, System.String maxsKey)`
  - Store the box's dimensions in 2 keys as Mins and Maxs. This type cannot be rotated.
  - `minsKey`: Internal name of a key on the node that will store the mins of the box.
  - `maxsKey`: Internal name of a key on the node that will store the maxs of the box.

## Properties

- `System.Boolean HideSurface`
  - If set, the semi-transparent box "walls" will not be drawn.
- `System.Boolean ShowGizmos`
  - If set, gizmos will be shown in transform mode to quickly move/scale the box.
For "dimensions" box Origin/Angles must be set.

## Methods

### Instance methods

- `virtual System.Void AddKeys(System.Collections.Generic.Dictionary<System.String,System.Object> dict)`
