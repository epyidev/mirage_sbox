# Sandbox.Rendering.TextureAddressMode

Specifies how texture coordinates outside the [0.0, 1.0] range are handled.

- **Kind:** enum
- **Namespace:** `Sandbox.Rendering`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Enum`

## Values

- `Wrap` - Wraps the texture coordinates. Values beyond 1.0 wrap around to the beginning.
Produces a repeating tiling pattern.
- `Mirror` - Mirrors the texture coordinates when sampling outside the [0.0, 1.0] range.
Creates a mirrored tiling effect.
- `Clamp` - Clamps the texture coordinates to the [0.0, 1.0] range.
Texture edges are stretched when sampling outside the range.
- `Border` - Uses a constant border color when sampling outside the [0.0, 1.0] range.
Requires a border color to be defined.
- `MirrorOnce` - Mirrors the texture once, then clamps to the edge.
Coordinates in [0.0, 1.0] sample normally, [-1.0, 0.0] mirror once, and everything else clamps.
