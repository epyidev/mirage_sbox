# Sandbox.Graphics.DownsampleMethod

Which method to use when downsampling a texture

- **Kind:** enum
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Enum`
- **Declaring type:** `Sandbox.Graphics`

## Values

- `Box` - Uses a box filter to downsample the texture
- `GaussianBlur` - Uses a gaussian filter to downsample the texture
- `GaussianBorder` - Uses a gaussian filter to downsample the texture, applies border to not oversample edges
- `Max` - Downsamples the texture using a max operator filter ( brightest pixel )
- `Min` - Downsamples the texture using a min operator filter ( darkest pixel )
- `MinMax` - Downsamples the texture in red and green channels using a Min/Max filter ( darkest and brightest pixel )
- `Default`
- `None`
