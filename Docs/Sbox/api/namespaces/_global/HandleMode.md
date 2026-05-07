# Sandbox.Curve.HandleMode

Describes how the line should behave when entering/leaving a frame

- **Kind:** enum
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Enum`
- **Declaring type:** `Sandbox.Curve`

## Values

- `Mirrored` - The In and Out are user set, but are joined (mirrored)
- `Split` - The In and Out are user set and operate independently
- `Flat` - Curves are generated automatically
- `Linear` - No curves, linear interpolation from this handle to the next
- `Stepped` - No interpolation use raw values
