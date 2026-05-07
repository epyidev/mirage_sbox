# Sandbox.TextureCubeBuilder

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `TextureCubeBuilder()`

## Methods

### Instance methods

- `Sandbox.TextureCubeBuilder WithStaticUsage()`
- `Sandbox.TextureCubeBuilder WithSemiStaticUsage()`
- `Sandbox.TextureCubeBuilder WithDynamicUsage()`
- `Sandbox.TextureCubeBuilder WithGPUOnlyUsage()`
- `Sandbox.TextureCubeBuilder WithUAVBinding()`
- `Sandbox.TextureCubeBuilder WithMips(System.Int32 mips)`
- `Sandbox.TextureCubeBuilder WithFormat(Sandbox.ImageFormat format)`
- `Sandbox.TextureCubeBuilder WithScreenFormat()`
- `Sandbox.TextureCubeBuilder WithDepthFormat()`
- `Sandbox.TextureCubeBuilder WithMultiSample2X()`
- `Sandbox.TextureCubeBuilder WithMultiSample4X()`
- `Sandbox.TextureCubeBuilder WithMultiSample6X()`
- `Sandbox.TextureCubeBuilder WithMultiSample8X()`
- `Sandbox.TextureCubeBuilder WithMultiSample16X()`
- `Sandbox.TextureCubeBuilder WithScreenMultiSample()`
- `Sandbox.TextureCubeBuilder WithName(System.String name)`
  - Provide a name to identify the texture by
  - `name`: Desired texture name
- `Sandbox.TextureCubeBuilder WithData(System.Byte[] data)`
  - Initialize texture with pre-existing texture data
  - `data`: Texture data
- `Sandbox.TextureCubeBuilder WithData(System.Byte[] data, System.Int32 dataLength)`
  - Initialize texture with pre-existing texture data
  - `data`: Texture data
  - `dataLength`: How big our texture data is
- `Sandbox.TextureCubeBuilder WithMultisample(Sandbox.MultisampleAmount amount)`
  - Define which how much multisampling the current texture should use
  - `amount`: Multisampling amount
- `Sandbox.TextureCubeBuilder WithAnonymous(System.Boolean isAnonymous)`
  - Set whether the texture is an anonymous texture or not
  - `isAnonymous`: Set if it's anonymous or not
- `Sandbox.TextureCubeBuilder WithArrayCount(System.Int32 count)`
- `Sandbox.Texture Finish()`
  - Build and create the actual texture
- `Sandbox.TextureCubeBuilder WithSize(System.Int32 width, System.Int32 height)`
  - Create texture with a predefined size
  - `width`: Width in pixel
  - `height`: Height in pixels
- `Sandbox.TextureCubeBuilder WithSize(Vector2 size)`
  - Create texture with a predefined size
  - `size`: Width and Height in pixels
- `Sandbox.TextureCubeBuilder AsRenderTarget()`
