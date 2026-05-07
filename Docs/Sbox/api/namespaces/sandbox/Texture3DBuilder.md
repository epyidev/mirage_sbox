# Sandbox.Texture3DBuilder

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `Texture3DBuilder()`

## Methods

### Instance methods

- `Sandbox.Texture3DBuilder WithStaticUsage()`
- `Sandbox.Texture3DBuilder WithSemiStaticUsage()`
- `Sandbox.Texture3DBuilder WithDynamicUsage()`
- `Sandbox.Texture3DBuilder WithGPUOnlyUsage()`
- `Sandbox.Texture3DBuilder WithUAVBinding()`
- `Sandbox.Texture3DBuilder WithMips(System.Int32 mips)`
- `Sandbox.Texture3DBuilder WithFormat(Sandbox.ImageFormat format)`
- `Sandbox.Texture3DBuilder WithScreenFormat()`
- `Sandbox.Texture3DBuilder WithDepthFormat()`
- `Sandbox.Texture3DBuilder WithMultiSample2X()`
- `Sandbox.Texture3DBuilder WithMultiSample4X()`
- `Sandbox.Texture3DBuilder WithMultiSample6X()`
- `Sandbox.Texture3DBuilder WithMultiSample8X()`
- `Sandbox.Texture3DBuilder WithMultiSample16X()`
- `Sandbox.Texture3DBuilder WithScreenMultiSample()`
- `Sandbox.Texture3DBuilder WithName(System.String name)`
  - Provide a name to identify the texture by
  - `name`: Desired texture name
- `Sandbox.Texture3DBuilder WithData(System.Byte[] data)`
  - Initialize texture with pre-existing texture data
  - `data`: Texture data
- `Sandbox.Texture3DBuilder WithData(System.Byte[] data, System.Int32 dataLength)`
  - Initialize texture with pre-existing texture data
  - `data`: Texture data
  - `dataLength`: How big our texture data is
- `Sandbox.Texture3DBuilder WithMultisample(Sandbox.MultisampleAmount amount)`
  - Define which how much multisampling the current texture should use
  - `amount`: Multisampling amount
- `Sandbox.Texture3DBuilder WithAnonymous(System.Boolean isAnonymous)`
  - Set whether the texture is an anonymous texture or not
  - `isAnonymous`: Set if it's anonymous or not
- `Sandbox.Texture Finish()`
  - Build and create the actual texture
- `Sandbox.Texture3DBuilder WithSize(System.Int32 width, System.Int32 height, System.Int32 depth)`
  - Create texture with a predefined size
  - `width`: Width in pixel
  - `height`: Height in pixels
  - `depth`: Depth in pixels
- `Sandbox.Texture3DBuilder WithSize(Vector3 size)`
  - Create texture with a predefined size
  - `size`: Width, Height and Depth in pixels
