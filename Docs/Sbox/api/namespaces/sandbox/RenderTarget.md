# Sandbox.RenderTarget

Essentially wraps a couple of textures that we're going to render to. The color texture and the depth texture.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Int32 Width`
  - Width of the render target
- `System.Int32 Height`
  - Height of the render target
- `Sandbox.Texture ColorTarget`
  - The target colour texture
- `Sandbox.Texture DepthTarget`
  - The target depth texture

## Methods

### Static methods

- `static Sandbox.RenderTarget GetTemporary(System.Int32 width, System.Int32 height, Sandbox.ImageFormat colorFormat, Sandbox.ImageFormat depthFormat, Sandbox.MultisampleAmount msaa, System.Int32 numMips, System.String targetName)`
  - Get a temporary render target. You should dispose the returned handle when you're done to return the textures to the pool.
  - `width`: Width of the render target you want.
  - `height`: Height of the render target you want.
  - `colorFormat`: The format for the color buffer. If set to default we'll use whatever the current pipeline is using.
  - `depthFormat`: The format for the depth buffer.
  - `msaa`: The number of msaa samples you'd like. Msaa render textures are a pain in the ass so you're probably gonna regret trying to use this.
  - `numMips`: Number of mips you want in this texture. You probably don't want this unless you want to generate mips in a second pass.
  - `targetName`: The optional name of the render target
  - returns: A RenderTarget that is ready to render to.
- `static Sandbox.RenderTarget GetTemporary(System.Int32 sizeFactor, Sandbox.ImageFormat colorFormat, Sandbox.ImageFormat depthFormat, Sandbox.MultisampleAmount msaa, System.Int32 numMips, System.String targetName)`
  - Get a temporary render target. You should dispose the returned handle when you're done to return the textures to the pool.
  - `sizeFactor`: Divide the screen size by this factor. 2 would be half screen sized. 1 for full screen sized.
  - `colorFormat`: The format for the color buffer. If null we'll choose the most appropriate for where you are in the pipeline.
  - `depthFormat`: The format for the depth buffer.
  - `msaa`: The number of msaa samples you'd like. Msaa render textures are a pain in the ass so you're probably gonna regret trying to use this.
  - `numMips`: Number of mips you want in this texture. You probably don't want this unless you want to generate mips in a second pass.
  - `targetName`: The optional name of the render target
  - returns: A RenderTarget that is ready to render to.
- `static Sandbox.RenderTarget From(Sandbox.Texture color, Sandbox.Texture depth)`
  - Create a render target from these textures

### Instance methods

- `virtual System.Void Dispose()`
  - Stop using this texture, return it to the pool
