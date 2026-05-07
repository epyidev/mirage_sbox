# Sandbox.TextureBuilder

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Methods

### Instance methods

- `Sandbox.TextureBuilder WithInitialColor(Color color)`
  - Once the texture is created it will be cleared to this color
- `Sandbox.TextureBuilder WithStaticUsage()`
  - Provides a hint to the GPU that this texture will not be modified.
- `Sandbox.TextureBuilder WithSemiStaticUsage()`
  - Provides a hint to the GPU that this texture will only be updated sometimes.
- `Sandbox.TextureBuilder WithDynamicUsage()`
  - Provides a hint to the GPU that this texture will be updated regularly. (almost every frame)
- `Sandbox.TextureBuilder WithGPUOnlyUsage()`
  - Specify the texture to ONLY be used on the GPU on not allow CPU access.
- `Sandbox.TextureBuilder WithSize(System.Int32 width, System.Int32 height)`
- `Sandbox.TextureBuilder WithSize(Vector2 size)`
- `Sandbox.TextureBuilder WithWidth(System.Int32 width)`
- `Sandbox.TextureBuilder WithHeight(System.Int32 height)`
- `Sandbox.TextureBuilder WithDepth(System.Int32 depth)`
- `Sandbox.TextureBuilder WithMSAA(Sandbox.MultisampleAmount amount)`
- `Sandbox.TextureBuilder WithMultiSample2X()`
  - Sets the texture to use 2x multisampling.
- `Sandbox.TextureBuilder WithMultiSample4X()`
  - Sets the texture to use 4x multisampling.
- `Sandbox.TextureBuilder WithMultiSample6X()`
  - Sets the texture to use 6x multisampling.
- `Sandbox.TextureBuilder WithMultiSample8X()`
  - Sets the texture to use 8x multisampling.
- `Sandbox.TextureBuilder WithMultiSample16X()`
  - Sets the texture to use 16x multisampling.
- `Sandbox.TextureBuilder WithScreenMultiSample()`
  - Sets the texture to use the same multisampling as whatever the screen/framebuffer uses
- `Sandbox.TextureBuilder WithFormat(Sandbox.ImageFormat format)`
  - The internal texture format to use.
  - `format`: Texture format
- `Sandbox.TextureBuilder WithScreenFormat()`
  - Sets the internal texture format to use the same format as the screen/frame buffer.
- `Sandbox.TextureBuilder WithDepthFormat()`
  - Uses the same depth format as what the screen/framebuffer uses.
- `Sandbox.TextureBuilder WithMips(System.Nullable<System.Int32> mips)`
- `Sandbox.TextureBuilder WithUAVBinding(System.Boolean uav)`
  - Support binding the texture as a Unordered Access View in a compute or pixel shader.
This is required for binding a texture within a compute shader.
- `Sandbox.Texture Create(System.String name, System.Boolean anonymous, System.ReadOnlySpan<System.Byte> data, System.Int32 dataLength)`
