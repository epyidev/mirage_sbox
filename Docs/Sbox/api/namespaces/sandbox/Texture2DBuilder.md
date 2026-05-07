# Sandbox.Texture2DBuilder

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `Texture2DBuilder()`

## Methods

### Instance methods

- `Sandbox.Texture2DBuilder WithStaticUsage()`
- `Sandbox.Texture2DBuilder WithSemiStaticUsage()`
- `Sandbox.Texture2DBuilder WithDynamicUsage()`
- `Sandbox.Texture2DBuilder WithGPUOnlyUsage()`
- `Sandbox.Texture2DBuilder WithUAVBinding()`
- `Sandbox.Texture2DBuilder WithMips()`
- `Sandbox.Texture2DBuilder WithMips(System.Int32 mips)`
- `Sandbox.Texture2DBuilder WithFormat(Sandbox.ImageFormat format)`
- `Sandbox.Texture2DBuilder WithScreenFormat()`
- `Sandbox.Texture2DBuilder WithDepthFormat()`
- `Sandbox.Texture2DBuilder WithMultiSample2X()`
- `Sandbox.Texture2DBuilder WithMultiSample4X()`
- `Sandbox.Texture2DBuilder WithMultiSample6X()`
- `Sandbox.Texture2DBuilder WithMultiSample8X()`
- `Sandbox.Texture2DBuilder WithMultiSample16X()`
- `Sandbox.Texture2DBuilder WithScreenMultiSample()`
- `Sandbox.Texture2DBuilder WithName(System.String name)`
  - Provide a name to identify the texture by
  - `name`: Desired texture name
- `Sandbox.Texture2DBuilder WithData(System.Byte[] data)`
- `Sandbox.Texture2DBuilder WithData(System.Byte[] data, System.Int32 dataLength)`
  - Initialize texture with pre-existing texture data.
  - `data`: Texture data.
  - `dataLength`: How big our texture data is.
- `Sandbox.Texture2DBuilder WithData(System.ReadOnlySpan<T> data)`
- `Sandbox.Texture2DBuilder WithMultisample(Sandbox.MultisampleAmount amount)`
  - Use Multi-Sample Anti Aliasing (MSAA) of given sample count.
- `Sandbox.Texture2DBuilder WithAnonymous(System.Boolean isAnonymous)`
  - Set whether the texture is an anonymous texture or not
  - `isAnonymous`: Set if it's anonymous or not
- `Sandbox.Texture Finish()`
  - Build and create the actual texture
- `Sandbox.Texture2DBuilder WithSize(System.Int32 width, System.Int32 height)`
  - Create texture with a predefined size.
  - `width`: Width in pixel.
  - `height`: Height in pixels.
- `Sandbox.Texture2DBuilder WithSize(Vector2 size)`
  - Create texture with a predefined size
  - `size`: Width and Height in pixels
