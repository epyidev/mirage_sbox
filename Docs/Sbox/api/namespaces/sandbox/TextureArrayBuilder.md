# Sandbox.TextureArrayBuilder

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `TextureArrayBuilder()`

## Methods

### Instance methods

- `Sandbox.TextureArrayBuilder WithStaticUsage()`
- `Sandbox.TextureArrayBuilder WithSemiStaticUsage()`
- `Sandbox.TextureArrayBuilder WithDynamicUsage()`
- `Sandbox.TextureArrayBuilder WithGPUOnlyUsage()`
- `Sandbox.TextureArrayBuilder WithUAVBinding()`
- `Sandbox.TextureArrayBuilder WithMips(System.Int32 mips)`
- `Sandbox.TextureArrayBuilder WithFormat(Sandbox.ImageFormat format)`
- `Sandbox.TextureArrayBuilder WithScreenFormat()`
- `Sandbox.TextureArrayBuilder WithDepthFormat()`
- `Sandbox.TextureArrayBuilder WithMultiSample2X()`
- `Sandbox.TextureArrayBuilder WithMultiSample4X()`
- `Sandbox.TextureArrayBuilder WithMultiSample6X()`
- `Sandbox.TextureArrayBuilder WithMultiSample8X()`
- `Sandbox.TextureArrayBuilder WithMultiSample16X()`
- `Sandbox.TextureArrayBuilder WithScreenMultiSample()`
- `Sandbox.TextureArrayBuilder WithName(System.String name)`
  - Provide a name to identify the texture by
  - `name`: Desired texture name
- `Sandbox.TextureArrayBuilder WithData(System.Byte[] data)`
  - Initialize texture with pre-existing texture data
  - `data`: Texture data
- `Sandbox.TextureArrayBuilder WithData(System.Byte[] data, System.Int32 dataLength)`
  - Initialize texture with pre-existing texture data
  - `data`: Texture data
  - `dataLength`: How big our texture data is
- `Sandbox.TextureArrayBuilder WithMultisample(Sandbox.MultisampleAmount amount)`
  - Define which how much multisampling the current texture should use
  - `amount`: Multisampling amount
- `Sandbox.TextureArrayBuilder WithAnonymous(System.Boolean isAnonymous)`
  - Set whether the texture is an anonymous texture or not
  - `isAnonymous`: Set if it's anonymous or not
- `Sandbox.Texture Finish()`
  - Build and create the actual texture
- `Sandbox.TextureArrayBuilder WithSize(System.Int32 width, System.Int32 height)`
  - Create texture with a predefined size
  - `width`: Width in pixel
  - `height`: Height in pixels
- `Sandbox.TextureArrayBuilder WithCount(System.Int32 count)`
  - Create texture array with this many textures
