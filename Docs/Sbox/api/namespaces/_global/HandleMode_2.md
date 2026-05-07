# Sandbox.Spline.HandleMode

Describes how the spline should behave when entering/leaving a point.

- **Kind:** enum
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Enum`
- **Declaring type:** `Sandbox.Spline`

## Values

- `Auto` - Handle positions are calculated automatically
based on the location of adjacent points.
- `Linear` - Handle positions are set to zero, leading to a sharp corner.
- `Mirrored` - The In and Out handles are user set, but are linked (mirrored).
- `Split` - The In and Out handle are user set and operate independently.
