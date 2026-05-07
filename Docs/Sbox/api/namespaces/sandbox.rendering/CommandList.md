# Sandbox.Rendering.CommandList

- **Kind:** sealed class
- **Namespace:** `Sandbox.Rendering`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `CommandList()`
- `CommandList(System.String debugName)`

## Properties

- `Sandbox.Rendering.CommandList.AttributeAccess GlobalAttributes`
  - These are the attributes for the current view. Setting a variable here will let you pass it down to
other places in the render pipeline.
- `Sandbox.Rendering.CommandList.AttributeAccess Attributes`
  - Access to the local attributes. What these are depends on where the command list is being called.
If we're calling from a renderable, these are the attributes for that renderable.
- `System.String DebugName`
- `System.Boolean Enabled`
- `Sandbox.Rendering.CommandList.Flag Flags`
- `Sandbox.Rendering.HudPainter Paint`
  - Access to simple 2D painting functions to draw shapes and text.
- `Sandbox.Rendering.RenderTargetHandle.SizeHandle ViewportSize`
  - A handle to the viewport size

## Methods

### Instance methods

- `System.Void Reset()`
- `System.Void Blit(Sandbox.Material material, Sandbox.RenderAttributes attributes)`
- `System.Void DrawQuad(Sandbox.Rect rect, Sandbox.Material material, Color color)`
- `System.Void DrawScreenQuad(Sandbox.Material material, Color color)`
- `System.Void Set(Sandbox.StringToken token, System.Single f)`
- `System.Void Set(Sandbox.StringToken token, System.Double f)`
- `System.Void Set(Sandbox.StringToken token, Vector2 vector2)`
- `System.Void Set(Sandbox.StringToken token, Vector3 vector3)`
- `System.Void Set(Sandbox.StringToken token, Vector4 vector4)`
- `System.Void Set(Sandbox.StringToken token, System.Int32 i)`
- `System.Void Set(Sandbox.StringToken token, System.Boolean b)`
- `System.Void Set(Sandbox.StringToken token, Matrix matrix)`
- `System.Void Set(Sandbox.StringToken token, Sandbox.GpuBuffer buffer)`
- `System.Void Set(Sandbox.StringToken token, Sandbox.Texture texture)`
- `System.Void SetCombo(Sandbox.StringToken token, System.Int32 value)`
- `System.Void SetCombo(Sandbox.StringToken token, System.Boolean value)`
- `System.Void SetCombo(Sandbox.StringToken token, T t)`
- `System.Void SetConstantBuffer(Sandbox.StringToken token, T data)`
- `System.Void SetGlobal(Sandbox.StringToken token, Sandbox.GpuBuffer buffer)`
- `System.Void SetGlobal(Sandbox.StringToken token, System.Int32 i)`
- `System.Void SetGlobal(Sandbox.StringToken token, System.Boolean b)`
- `System.Void SetGlobal(Sandbox.StringToken token, System.Single f)`
- `System.Void SetGlobal(Sandbox.StringToken token, System.Double f)`
- `System.Void SetGlobal(Sandbox.StringToken token, Vector2 vector2)`
- `System.Void SetGlobal(Sandbox.StringToken token, Vector3 vector3)`
- `System.Void SetGlobal(Sandbox.StringToken token, Vector4 vector4)`
- `System.Void SetGlobal(Sandbox.StringToken token, Matrix matrix)`
- `System.Void SetGlobal(Sandbox.StringToken token, Sandbox.Texture texture)`
- `Sandbox.Rendering.RenderTargetHandle GrabFrameTexture(System.String token, System.Boolean withMips)`
  - Takes a copy of the framebuffer and returns a handle to it
  - `withMips`: Generates mipmaps on the grabbed texture filtered with gaussian blur for each mip
- `Sandbox.Rendering.RenderTargetHandle GrabDepthTexture(System.String token)`
  - Takes a copy of the depthbuffer and returns a handle to it
- `System.Void InsertList(Sandbox.Rendering.CommandList otherBuffer)`
  - Run this CommandList here
- `System.Void DrawModel(Sandbox.Model model, Transform transform, Sandbox.RenderAttributes attributes)`
  - Draws a single model at the given Transform immediately.
  - `model`: The model to draw
  - `transform`: Transform to draw the model at
  - `attributes`: Optional attributes to apply only for this draw call
- `System.Void DrawModelInstanced(Sandbox.Model model, System.Span<Transform> transforms, Sandbox.RenderAttributes attributes)`
- `System.Void DrawModelInstancedIndirect(Sandbox.Model model, Sandbox.GpuBuffer buffer, System.Int32 bufferOffset, Sandbox.RenderAttributes attributes)`
  - Draws multiple instances of a model using GPU instancing with the number of instances being provided by indirect draw arguments.
Use `SV_InstanceID` semantic in shaders to access the rendered instance.
  - `model`: The model to draw
  - `buffer`: The GPU buffer containing the DrawIndirectArguments
  - `bufferOffset`: Optional offset in the GPU buffer
  - `attributes`: Optional attributes to apply only for this draw call
- `System.Void DrawModelInstanced(Sandbox.Model model, System.Int32 count, Sandbox.RenderAttributes attributes)`
  - Draws multiple instances of a model using GPU instancing.
This is similar to `Sandbox.Rendering.CommandList.DrawModelInstancedIndirect(Sandbox.Model,Sandbox.GpuBuffer,System.Int32,Sandbox.RenderAttributes)`,
except the count is provided from the CPU rather than via a GPU buffer.
            
Use `SV_InstanceID` semantic in shaders to access the rendered instance.
  - `model`: The model to draw
  - `count`: The number of instances to draw
  - `attributes`: Optional attributes to apply only for this draw call
- `System.Void Draw(Sandbox.GpuBuffer<T> vertexBuffer, Sandbox.Material material, System.Int32 startVertex, System.Int32 vertexCount, Sandbox.RenderAttributes attributes, Sandbox.Graphics.PrimitiveType primitiveType)`
- `System.Void DrawIndexed(Sandbox.GpuBuffer<T> vertexBuffer, Sandbox.GpuBuffer indexBuffer, Sandbox.Material material, System.Int32 startIndex, System.Int32 indexCount, Sandbox.RenderAttributes attributes, Sandbox.Graphics.PrimitiveType primitiveType)`
- `System.Void DrawInstancedIndirect(Sandbox.GpuBuffer<T> vertexBuffer, Sandbox.Material material, Sandbox.GpuBuffer indirectBuffer, System.UInt32 bufferOffset, Sandbox.RenderAttributes attributes, Sandbox.Graphics.PrimitiveType primitiveType)`
- `System.Void DrawInstancedIndirect(Sandbox.Material material, Sandbox.GpuBuffer indirectBuffer, System.UInt32 bufferOffset, Sandbox.RenderAttributes attributes, Sandbox.Graphics.PrimitiveType primitiveType)`
  - Draws instanced geometry using a vertex buffer and indirect draw arguments stored in a GPU buffer.
  - `material`: The material to use for rendering.
  - `indirectBuffer`: The GPU buffer containing indirect draw arguments.
  - `bufferOffset`: Optional byte offset into the indirect buffer.
  - `attributes`: Optional render attributes to apply only for this draw call.
  - `primitiveType`: The type of primitives to render. Defaults to triangles.
- `System.Void DrawIndexedInstancedIndirect(Sandbox.GpuBuffer<T> vertexBuffer, Sandbox.GpuBuffer indexBuffer, Sandbox.Material material, Sandbox.GpuBuffer indirectBuffer, System.UInt32 bufferOffset, Sandbox.RenderAttributes attributes, Sandbox.Graphics.PrimitiveType primitiveType)`
- `System.Void DrawIndexedInstancedIndirect(Sandbox.GpuBuffer indexBuffer, Sandbox.Material material, Sandbox.GpuBuffer indirectBuffer, System.UInt32 bufferOffset, Sandbox.RenderAttributes attributes, Sandbox.Graphics.PrimitiveType primitiveType)`
  - Draws instanced indexed geometry using indirect draw arguments stored in a GPU buffer.
  - `indexBuffer`: The GPU buffer containing index data.
  - `material`: The material to use for rendering.
  - `indirectBuffer`: The GPU buffer containing indirect draw arguments.
  - `bufferOffset`: Optional byte offset into the indirect buffer.
  - `attributes`: Optional render attributes to apply only for this draw call.
  - `primitiveType`: The type of primitives to render. Defaults to triangles.
- `System.Void DrawIndexedInstanced(Sandbox.GpuBuffer indexBuffer, Sandbox.Material material, System.Int32 instanceCount, Sandbox.RenderAttributes attributes, Sandbox.Graphics.PrimitiveType primitiveType)`
  - Draws indexed geometry with instancing. Each instance shares the same index buffer.
- `Sandbox.Rendering.RenderTargetHandle GetRenderTarget(System.String name, Sandbox.ImageFormat format, System.Int32 numMips, System.Int32 sizeFactor)`
  - Get a screen sized temporary render target. You should release the returned handle when you're done to return the textures to the pool.
  - `name`: The name of the render target handle.
  - `sizeFactor`: Divide the screen size by this factor. 2 would be half screen sized. 1 for full screen sized.
  - `format`: The format for the color buffer. If set to default we'll use whatever the current pipeline is using.
  - `numMips`: Number of mips you want in this texture. You probably don't want this unless you want to generate mips in a second pass.
  - returns: A RenderTarget that is ready to render to.
- `Sandbox.Rendering.RenderTargetHandle GetRenderTarget(System.String name, System.Int32 sizeFactor, Sandbox.ImageFormat colorFormat, Sandbox.ImageFormat depthFormat, Sandbox.MultisampleAmount msaa, System.Int32 numMips)`
  - Get a screen sized temporary render target. You should release the returned handle when you're done to return the textures to the pool.
  - `name`: The name of the render target handle.
  - `sizeFactor`: Divide the screen size by this factor. 2 would be half screen sized. 1 for full screen sized.
  - `colorFormat`: The format for the color buffer. If set to default we'll use whatever the current pipeline is using.
  - `depthFormat`: The format for the depth buffer.
  - `msaa`: The number of msaa samples you'd like. Msaa render textures are a pain in the ass so you're probably gonna regret trying to use this.
  - `numMips`: Number of mips you want in this texture. You probably don't want this unless you want to generate mips in a second pass.
  - returns: A RenderTarget that is ready to render to.
- `Sandbox.Rendering.RenderTargetHandle GetRenderTarget(System.String name, System.Int32 width, System.Int32 height, Sandbox.ImageFormat colorFormat, Sandbox.ImageFormat depthFormat, Sandbox.MultisampleAmount msaa, System.Int32 numMips)`
  - Get a temporary render target. You should release the returned handle when you're done to return the textures to the pool.
  - `name`: The name of the render target handle.
  - `width`: Width of the render target you want.
  - `height`: Height of the render target you want.
  - `colorFormat`: The format for the color buffer. If set to default we'll use whatever the current pipeline is using.
  - `depthFormat`: The format for the depth buffer.
  - `msaa`: The number of msaa samples you'd like. Msaa render textures are a pain in the ass so you're probably gonna regret trying to use this.
  - `numMips`: Number of mips you want in this texture. You probably don't want this unless you want to generate mips in a second pass.
  - returns: A RenderTarget that is ready to render to.
- `System.Void ReleaseRenderTarget(Sandbox.Rendering.RenderTargetHandle handle)`
  - We're no longer using this RT, return it to the pool
- `System.Void SetRenderTarget(Sandbox.Rendering.RenderTargetHandle handle)`
  - Set the current render target. Setting this will bind the render target and change the viewport to match it.
- `System.Void SetRenderTarget(Sandbox.RenderTarget target)`
  - Set the current render target. Setting this will bind the render target and change the viewport to match it.
- `System.Void ClearRenderTarget()`
  - Set the current render target. Setting this will bind the render target and change the viewport to match it.
- `System.Void Set(Sandbox.StringToken token, Sandbox.Rendering.RenderTargetHandle.ColorTextureRef buffer, System.Int32 mip)`
  - Set the color texture from this named render target to this attribute
- `System.Void SetGlobal(Sandbox.StringToken token, Sandbox.Rendering.RenderTargetHandle.ColorIndexRef buffer)`
  - Set the color texture from this named render target to this attribute
- `System.Void DispatchCompute(Sandbox.ComputeShader compute, System.Int32 threadsX, System.Int32 threadsY, System.Int32 threadsZ)`
- `System.Void DispatchComputeIndirect(Sandbox.ComputeShader compute, Sandbox.GpuBuffer indirectBuffer, System.UInt32 indirectElementOffset)`
- `Sandbox.Rendering.RenderTargetHandle.SizeHandle ViewportSizeScaled(System.Int32 divisor)`
  - A handle to the viewport size divided by a factor. Useful for dispatching at half or quarter resolution.
- `System.Void DispatchCompute(Sandbox.ComputeShader compute, Sandbox.Rendering.RenderTargetHandle.SizeHandle dimension)`
  - Dispatch a compute shader
- `System.Void Clear(Color color, System.Boolean clearColor, System.Boolean clearDepth, System.Boolean clearStencil)`
  - Clear the current drawing context to given color.
  - `color`: Color to clear to.
  - `clearColor`: Whether to clear the color buffer at all.
  - `clearDepth`: Whether to clear the depth buffer.
  - `clearStencil`: Whether to clear the stencil buffer.
- `System.Void Clear(Sandbox.Texture texture, Color color)`
  - Clears the given texture to a solid color.
  - `texture`: The texture to clear.
  - `color`: The color to clear to. Defaults to transparent black.
- `System.Void Clear(Sandbox.Rendering.RenderTargetHandle handle, Color color)`
  - Clears the color texture of the given render target handle to a solid color.
  - `handle`: The render target handle whose color texture to clear.
  - `color`: The color to clear to. Defaults to transparent black.
- `System.Void Clear(Sandbox.GpuBuffer buffer, System.UInt32 value)`
  - Fills the given GPU buffer with a repeated uint32 value.
  - `buffer`: The buffer to clear.
  - `value`: The uint32 value to fill with. Defaults to zero.
- `System.Void ResourceBarrierTransition(Sandbox.Texture texture, Sandbox.Rendering.ResourceState state, System.Int32 mip)`
  - Executes a barrier transition for the given GPU Texture Resource.
Transitions the texture resource to a new pipeline stage and access state.
  - `texture`: The texture to transition.
  - `state`: The new resource state for the texture.
  - `mip`: The mip level to transition (-1 for all mips).
- `System.Void ResourceBarrierTransition(Sandbox.Rendering.RenderTargetHandle.ColorTextureRef texture, Sandbox.Rendering.ResourceState state, System.Int32 mip)`
  - Executes a barrier transition for the color texture of the given render target handle.
  - `texture`: The render target color handle.
  - `state`: The new resource state for the texture.
  - `mip`: The mip level to transition (-1 for all mips).
- `System.Void ResourceBarrierTransition(Sandbox.Rendering.RenderTargetHandle.DepthTextureRef texture, Sandbox.Rendering.ResourceState state, System.Int32 mip)`
  - Executes a barrier transition for the depth texture of the given render target handle.
  - `texture`: The render target depth handle.
  - `state`: The new resource state for the texture.
  - `mip`: The mip level to transition (-1 for all mips).
- `System.Void ResourceBarrierTransition(Sandbox.Rendering.RenderTargetHandle handle, Sandbox.Rendering.ResourceState state, System.Int32 mip)`
  - Executes a barrier transition for the color texture of the given render target handle.
  - `handle`: The render target handle.
  - `state`: The new resource state for the texture.
  - `mip`: The mip level to transition (-1 for all mips).
- `System.Void ResourceBarrierTransition(Sandbox.GpuBuffer buffer, Sandbox.Rendering.ResourceState state)`
  - Executes a barrier transition for the given GPU Buffer Resource.
Transitions the buffer resource to a new pipeline stage and access state.
  - `buffer`: The GPU buffer to transition.
  - `state`: The new resource state for the buffer.
- `System.Void ResourceBarrierTransition(Sandbox.GpuBuffer buffer, Sandbox.Rendering.ResourceState before, Sandbox.Rendering.ResourceState after)`
  - Executes a barrier transition for the given GPU Buffer Resource.
Transitions the buffer resource from a known source state to a specified destination state.
  - `buffer`: The GPU buffer to transition.
  - `before`: The current resource state of the buffer.
  - `after`: The desired resource state of the buffer after the transition.
- `System.Void UavBarrier(Sandbox.Texture texture)`
  - Issues a UAV barrier for the given texture, ensuring writes from prior shader invocations
are visible to subsequent ones without changing the resource layout.
  - `texture`: The texture to barrier.
- `System.Void UavBarrier(Sandbox.GpuBuffer buffer)`
  - Issues a UAV barrier for the given GPU buffer, ensuring writes from prior shader invocations
are visible to subsequent ones.
  - `buffer`: The buffer to barrier.
- `System.Void GenerateMipMaps(Sandbox.Rendering.RenderTargetHandle handle, Sandbox.Graphics.DownsampleMethod method)`
  - Generates a mip-map chain for the specified render target.
This will generate mipmaps for the color texture of the render target.
- `System.Void GenerateMipMaps(Sandbox.RenderTarget target, Sandbox.Graphics.DownsampleMethod method)`
  - Generates a mip-map chain for the specified render target.
This will generate mipmaps for the color texture of the render target.
- `System.Void GenerateMipMaps(Sandbox.Texture texture, Sandbox.Graphics.DownsampleMethod method)`
  - Generates a mip-map chain for the specified texture.
This will generate mipmaps for the color texture of the texture.
- `System.Void DrawText(Sandbox.TextRendering.Scope scope, Sandbox.Rect rect, Sandbox.TextFlag flags, System.Single angleDegrees)`
  - Draws text within a rectangle using a prepared `Sandbox.TextRendering.Scope`.
  - `scope`: The text rendering scope.
  - `rect`: The rectangle to draw the text in.
  - `flags`: Text alignment flags (optional).
  - `angleDegrees`: Rotation angle in degrees (optional).
- `System.Void DrawRenderer(Sandbox.Renderer renderer, Sandbox.Rendering.RendererSetup rendererSetup)`
  - Render a `Sandbox.Renderer` with the specified overrides.
- `System.Void DrawView(Sandbox.CameraComponent camera, Sandbox.Rendering.RenderTargetHandle target, Sandbox.Rendering.ViewSetup viewSetup)`
  - Renders the view from a camera to the specified render target.
- `System.Void DrawReflection(Sandbox.CameraComponent camera, Sandbox.Plane plane, Sandbox.Rendering.RenderTargetHandle target, Sandbox.Rendering.ReflectionSetup reflectionSetup)`
  - Render a planar reflection using the specified camera and the specified plane.
- `System.Void DrawRefraction(Sandbox.CameraComponent camera, Sandbox.Plane plane, Sandbox.Rendering.RenderTargetHandle target, Sandbox.Rendering.RefractionSetup refractionSetup)`
  - Render a planar refraction using the specified camera and the specified plane. This is for all intents and purposes a
regular view with a plane clipping it. Usually used for rendering under water.
