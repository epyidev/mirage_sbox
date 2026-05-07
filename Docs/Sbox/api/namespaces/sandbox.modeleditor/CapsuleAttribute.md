# Sandbox.ModelEditor.CapsuleAttribute

Draws a capsule, which can be manipulated via gizmos. You can have multiple of these.

- **Kind:** attribute
- **Namespace:** `Sandbox.ModelEditor`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.ModelEditor.Internal.BaseTransformAttribute`

## Constructors

- `CapsuleAttribute(System.String point1Key, System.String point2key, System.String radiusKey)`
  - This variation has 1 radius for both points.
- `CapsuleAttribute(System.String point1Key, System.String point2key, System.String radius1Key, System.String radius2Key)`
  - This variation has independent radius for each point.

## Methods

### Instance methods

- `virtual System.Void AddKeys(System.Collections.Generic.Dictionary<System.String,System.Object> dict)`
