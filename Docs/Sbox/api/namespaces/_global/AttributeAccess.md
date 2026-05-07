# Sandbox.Rendering.CommandList.AttributeAccess

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Rendering.CommandList`

## Methods

### Instance methods

- `System.Void Clear()`
- `System.Void Set(Sandbox.StringToken token, System.Single f)`
- `System.Void Set(Sandbox.StringToken token, System.Double f)`
- `System.Void Set(Sandbox.StringToken token, Vector2 vector2)`
- `System.Void Set(Sandbox.StringToken token, Vector3 vector3)`
- `System.Void Set(Sandbox.StringToken token, Vector4 vector4)`
- `System.Void Set(Sandbox.StringToken token, System.Int32 i)`
- `System.Void Set(Sandbox.StringToken token, System.Boolean b)`
- `System.Void Set(Sandbox.StringToken token, Matrix matrix)`
- `System.Void Set(Sandbox.StringToken token, Sandbox.GpuBuffer buffer)`
- `System.Void Set(Sandbox.StringToken token, Sandbox.Texture texture, System.Int32 mip)`
- `System.Void Set(Sandbox.StringToken token, Sandbox.Rendering.SamplerState samplerState)`
- `System.Void SetCombo(Sandbox.StringToken token, System.Int32 value)`
- `System.Void SetCombo(Sandbox.StringToken token, System.Boolean value)`
- `System.Void SetCombo(Sandbox.StringToken token, T t)`
- `System.Void SetData(Sandbox.StringToken token, T data)`
- `System.Void SetValue(Sandbox.StringToken token, Sandbox.Rendering.RenderValue value)`
  - Set a special value
- `System.Void Set(Sandbox.StringToken token, Sandbox.Rendering.RenderTargetHandle.ColorTextureRef buffer, System.Int32 mip)`
  - Set the color texture from this named render target to this attribute
- `System.Void Set(Sandbox.StringToken token, Sandbox.Rendering.RenderTargetHandle.DepthTextureRef buffer, System.Int32 mip)`
  - Set the depth texture from this named render target to this attribute
- `System.Void Set(Sandbox.StringToken token, Sandbox.Rendering.RenderTargetHandle.ColorIndexRef buffer)`
  - Set the color texture from this named render target to this attribute
- `System.Void Set(Sandbox.StringToken token, Sandbox.Rendering.RenderTargetHandle.SizeHandle size, System.Boolean inverse)`
  - Set the size of this named render target to this float2 attribute
- `Sandbox.Rendering.RenderTargetHandle GrabFrameTexture(System.String token, System.Boolean withMips)`
  - Takes a copy of the current viewport's color texture and stores it in targetName on renderAttributes.
- `Sandbox.Rendering.RenderTargetHandle GrabFrameTexture(System.String token, Sandbox.Graphics.DownsampleMethod downsampleMethod, System.Int32 maxMips)`
  - Takes a copy of the current viewport's color texture and stores it in targetName on renderAttributes.
- `Sandbox.Rendering.RenderTargetHandle GrabDepthTexture(System.String token)`
  - Takes a copy of the current viewport's depth texture and stores it in targetName on renderAttributes.
- `Sandbox.RenderTarget GetRenderTarget(System.String name)`
  - Get the actual render target by name. Useful for externals that need to access the render target directly.
