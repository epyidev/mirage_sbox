# Sandbox.UI.Shadow

Shadow style settings

- **Kind:** struct
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.System`

## Fields

- `System.Single OffsetX`
  - Shadow offset on the X axis.
- `System.Single OffsetY`
  - Shadow offset on the Y axis.
- `System.Single Blur`
  - Amount of blurring for the shadow.
- `System.Single Spread`
  - Increases the box size by this much before starting shadow blur.
Box shadows only.
- `System.Boolean Inset`
  - Whether or not this shadow is inset.
Box shadows only.
- `Color Color`
  - Color of the shadow.

## Methods

### Instance methods

- `Sandbox.UI.Shadow Scale(System.Single f)`
  - Scale all variables by given scalar.
  - `f`: How much to scale the shadow parameters by. 1 is no change, 2 is double the sizes, etc.
  - returns: The scaled shadow.
- `Sandbox.UI.Shadow LerpTo(Sandbox.UI.Shadow shadow, System.Single delta)`
  - Perform linear interpolation between 2 shadows.
  - `shadow`: The target shadow to morph into.
  - `delta`: Progress of the transformation. 0 = original shadow, 1 = fully target shadow.
  - returns: The interpolated shadow.
