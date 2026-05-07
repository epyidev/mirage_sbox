# Sandbox.Resources.ImageFileGenerator

Load images from disk and convert them to textures

- **Kind:** class
- **Namespace:** `Sandbox.Resources`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Resources.TextureGenerator`

## Constructors

- `ImageFileGenerator()`

## Properties

- `System.String FilePath`
  - The path to the image file, relative to any other assets in the project.
- `System.Int32 MaxSize`
  - The maximum size of the image in pixels. If the imported image is larger than this (after cropping), it will be downscaled to fit.
- `System.Boolean ConvertHeightToNormals`
  - When enabled, the output texture will be a normal map generated from the heightmap of the image.
- `System.Single NormalScale`
  - The scale of the normal map when using `Sandbox.Resources.ImageFileGenerator.ConvertHeightToNormals`. If negative, the normal map will be inverted.
- `System.Single Rotate`
  - How much to rotate the image by, in degrees. This is applied after cropping and padding.
- `System.Boolean FlipVertical`
  - Whether or not to flip the image vertically. This is done after everything else has been applied.
- `System.Boolean FlipHorizontal`
  - Whether or not to flip the image horizontally. This is done after everything else has been applied.
- `Sandbox.UI.Margin Cropping`
  - How many pixels from each edge to crop from the image. If negative values are used, the image will be expanded instead of cropped.
- `Sandbox.UI.Margin Padding`
  - How many pixels of padding from each edge. After the image has been cropped,
padding is added without affecting the size of the image (scaling the original image down to fit padded margins).
- `System.Boolean InvertColor`
  - Whether or not to invert the colors of the image.
- `Color Tint`
  - The color the image should be tinted. This effectively multiplies the color of each pixel by this color (including alpha).
- `System.Single Blur`
  - The intensity of the blur effect. If 0, no blur is applied.
- `System.Single Sharpen`
  - The intensity of the sharpen effect. If 0, no sharpening is applied.
- `System.Single Brightness`
  - The brightness of the image.
- `System.Single Contrast`
  - The contrast of the image.
- `System.Single Saturation`
  - The saturation of the image.
- `System.Single Hue`
  - How much to adjust the hue of the image, in degrees. If 0, no hue adjustment is applied.
- `System.Boolean Colorize`
  - When enabled, every pixel in the image will be re-colored to the `Sandbox.Resources.ImageFileGenerator.TargetColor` (interpolated by the alpha).
- `Color TargetColor`
  - When `Sandbox.Resources.ImageFileGenerator.Colorize` is enabled, this is the target color that every pixel in the image will be re-colored to.
- `System.Boolean CacheToDisk`

## Methods

### Instance methods

- `virtual System.Threading.Tasks.ValueTask<Sandbox.Texture> CreateTexture(Sandbox.Resources.ResourceGenerator.Options options, System.Threading.CancellationToken ct)`
- `virtual System.Nullable<Sandbox.Resources.EmbeddedResource> CreateEmbeddedResource()`
