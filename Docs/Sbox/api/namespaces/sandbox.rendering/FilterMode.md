# Sandbox.Rendering.FilterMode

Represents filtering modes for texture sampling in the rendering pipeline.

- **Kind:** enum
- **Namespace:** `Sandbox.Rendering`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Enum`

## Values

- `Point` - Uses the nearest texel without interpolation.
Fastest but lowest visual quality.
- `Bilinear` - Interpolates between the four nearest texels in the same mip level.
Smoother than point sampling but does not blend between mip levels.
- `Trilinear` - Bilinear sampling with smooth transitions between mipmap levels.
Provides better visual quality across distances.
- `Anisotropic` - Enhances texture detail on steep viewing angles.
Best visual quality, higher performance cost.
