# Sandbox.Graphics

Used to render to the screen using your Graphics Card, or whatever you
kids are using in your crazy future computers. Whatever it is I'm sure
it isn't fungible and everyone has free money and no-one has to ever work.

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static System.Boolean IsActive`
  - If true then we're currently rendering and
you are safe to use the contents of this class
- `static Sandbox.SceneLayerType LayerType`
  - The current layer type. This is useful to tell whether you're meant to be drawing opaque, transparent or shadow. You mainly
don't need to think about this, but when you do, it's here.
- `static Sandbox.Rect Viewport`
  - In pixel size, where are we rendering to?
- `static Sandbox.RenderAttributes Attributes`
  - Access to the current render context's attributes. These will be used
to set attributes in materials/shaders. This is cleared at the end of the render block.
- `static Transform CameraTransform`
  - The camera transform of the currently rendering view
- `static Vector3 CameraPosition`
  - The camera position of the currently rendering view
- `static Rotation CameraRotation`
  - The camera rotation of the currently rendering view
- `static System.Single FieldOfView`
  - The field of view of the currently rendering camera view, in degrees.
- `static Sandbox.Frustum Frustum`
  - The frustum of the currently rendering camera view.
- `static Sandbox.RenderTarget RenderTarget`
  - Get or set the current render target. Setting this will bind the render target and change the viewport to match it.

## Methods

### Static methods

- `static System.Void SetupLighting(Sandbox.SceneObject obj, Sandbox.RenderAttributes targetAttributes)`
  - Setup the lighting attributes for this current object. Place them in the targetAttributes
- `static Sandbox.RenderTarget GrabFrameTexture(System.String targetName, Sandbox.RenderAttributes renderAttributes, Sandbox.Graphics.DownsampleMethod downsampleMethod, System.Int32 maxMips)`
  - Grabs the current viewport's color texture and stores it in targetName on renderAttributes.
- `static System.Void GrabFrameTexture(System.String targetName, Sandbox.RenderAttributes renderAttributes, System.Boolean withMips)`
- `static Sandbox.RenderTarget GrabDepthTexture(System.String targetName, Sandbox.RenderAttributes renderAttributes)`
  - Grabs the current depth texture and stores it in targetName on renderAttributes.
- `static System.Void Clear(Color color, System.Boolean clearColor, System.Boolean clearDepth, System.Boolean clearStencil)`
  - Clear the current drawing context to given color.
  - `color`: Color to clear to.
  - `clearColor`: Whether to clear the color buffer at all.
  - `clearDepth`: Whether to clear the depth buffer.
  - `clearStencil`: Whether to clear the stencil buffer.
- `static System.Void Clear(System.Boolean clearColor, System.Boolean clearDepth)`
  - Clear the current drawing context to given color.
  - `clearColor`: Whether to clear the color buffer to transparent color.
  - `clearDepth`: Whether to clear the depth buffer.
- `static System.Boolean RenderToTexture(Sandbox.SceneCamera camera, Sandbox.Texture target)`
  - Render this camera to the specified texture target
- `static System.Void CopyTexture(Sandbox.Texture srcTexture, Sandbox.Texture dstTexture)`
  - Copies pixel data from one texture to another on the GPU.
This does not automatically resize or scale the texture, format and size should be equal.
- `static System.Void CopyTexture(Sandbox.Texture srcTexture, Sandbox.Texture dstTexture, System.Int32 srcMipSlice, System.Int32 srcArraySlice, System.Int32 srcMipLevels, System.Int32 dstMipSlice, System.Int32 dstArraySlice, System.Int32 dstMipLevels)`
- `static System.Void CopyTexture(Sandbox.Texture srcTexture, Sandbox.Texture dstTexture, System.Int32 srcMipSlice, System.Int32 srcArraySlice, System.Int32 dstMipSlice, System.Int32 dstArraySlice)`
  - Copies pixel data from one texture to another on the GPU.
This does not automatically resize or scale the texture, format and size should be equal.
This one lets you copy to/from arrays / specific mips.
- `static System.Void FlushGPU()`
  - Forces the GPU to flush all pending commands and wait for completion.
Useful when you need to ensure GPU work is finished before proceeding.
Can be called outside of a render block.
- `static System.Void Draw(Sandbox.GpuBuffer<T> vertexBuffer, Sandbox.Material material, System.Int32 startVertex, System.Int32 vertexCount, Sandbox.RenderAttributes attributes, Sandbox.Graphics.PrimitiveType primitiveType)`
- `static System.Void Draw(Sandbox.GpuBuffer<T> vertexBuffer, Sandbox.GpuBuffer indexBuffer, Sandbox.Material material, System.Int32 startIndex, System.Int32 indexCount, Sandbox.RenderAttributes attributes, Sandbox.Graphics.PrimitiveType primitiveType)`
- `static System.Void Draw(System.Span<Sandbox.Vertex> vertices, System.Int32 vertCount, Sandbox.Material material, Sandbox.RenderAttributes attributes, Sandbox.Graphics.PrimitiveType primitiveType)`
- `static System.Void Draw(System.Collections.Generic.List<Sandbox.Vertex> vertices, System.Int32 vertCount, Sandbox.Material material, Sandbox.RenderAttributes attributes, Sandbox.Graphics.PrimitiveType primitiveType)`
- `static System.Void Draw(System.Span<Sandbox.Vertex> vertices, System.Int32 vertCount, System.Span<System.UInt16> indices, System.Int32 indexCount, Sandbox.Material material, Sandbox.RenderAttributes attributes, Sandbox.Graphics.PrimitiveType primitiveType)`
- `static System.Void Blit(Sandbox.Material material, Sandbox.RenderAttributes attributes)`
  - Draw a screen space quad using the passed material. Your material should be using a
screenspace shader so it will actually render to the screen and not in worldspace at 0,0,0
- `static System.Void Render(Sandbox.SceneObject obj, System.Nullable<Transform> transform, System.Nullable<Color> color, Sandbox.Material material)`
- `static System.Void DrawQuad(Sandbox.Rect rect, Sandbox.Material material, Color color, Sandbox.RenderAttributes attributes)`
  - Draw a quad in screenspace
- `static Sandbox.Rect DrawText(Sandbox.Rect position, System.String text, Color color, System.String fontFamily, System.Single fontSize, System.Single fontWeight, Sandbox.TextFlag flags)`
  - Draws a text quad in screenspace using the Material.UI.Text material.
- `static Sandbox.Rect DrawText(Sandbox.Rect position, Sandbox.TextRendering.Scope scope, Sandbox.TextFlag flags)`
  - Draws a text quad in screenspace using the Material.UI.Text material.
- `static Sandbox.Rect DrawText(Vector2 position, System.String text, Color color, System.String fontFamily, System.Single fontSize, System.Single fontWeight)`
  - Draws a text quad in screenspace using the Material.UI.Text material.
- `static Sandbox.Rect MeasureText(Sandbox.Rect position, System.String text, System.String fontFamily, System.Single fontSize, System.Single fontWeight, Sandbox.TextFlag flags)`
  - Measure how big some text will be, without having to render it
- `static Sandbox.Rect MeasureText(Sandbox.Rect position, Sandbox.TextRendering.Scope scope, Sandbox.TextFlag flags)`
  - Measure how big some text will be, without having to render it
- `static Sandbox.Rect DrawIcon(Sandbox.Rect rect, System.String iconName, Color color, System.Single fontSize, Sandbox.TextFlag alignment)`
  - Calls DrawText with "Material Icons" font. You can get a list of icons here https://fonts.google.com/icons?selected=Material+Icons
- `static System.Void DrawRoundedRectangle(Sandbox.Rect rect, Color color, Vector4 cornerRadius, Vector4 borderWidth, Color borderColor)`
  - Draw a rounded rectangle, with optional border, in Material.UI.Box
- `static System.Void DrawModel(Sandbox.Model model, Transform transform, Sandbox.RenderAttributes attributes)`
  - Draws a single model at the given Transform immediately.
  - `model`: The model to draw
  - `transform`: Transform to draw the model at
  - `attributes`: Optional attributes to apply only for this draw call
- `static System.Void DrawModelInstanced(Sandbox.Model model, System.Span<Transform> transforms, Sandbox.RenderAttributes attributes)`
- `static System.Void DrawModelInstancedIndirect(Sandbox.Model model, Sandbox.GpuBuffer buffer, System.Int32 bufferOffset, Sandbox.RenderAttributes attributes)`
  - Draws multiple instances of a model using GPU instancing with the number of instances being provided by indirect draw arguments.
Use `SV_InstanceID` semantic in shaders to access the rendered instance.
  - `model`: The model to draw
  - `buffer`: The GPU buffer containing the DrawIndirectArguments
  - `bufferOffset`: Optional offset in the GPU buffer
  - `attributes`: Optional attributes to apply only for this draw call
- `static System.Void DrawModelInstanced(Sandbox.Model model, System.Int32 count, Sandbox.RenderAttributes attributes)`
  - Draws multiple instances of a model using GPU instancing.
This is similar to `Sandbox.Graphics.DrawModelInstancedIndirect(Sandbox.Model,Sandbox.GpuBuffer,System.Int32,Sandbox.RenderAttributes)`,
except the count is provided from the CPU rather than via a GPU buffer.

Use `SV_InstanceID` semantic in shaders to access the rendered instance.
  - `model`: The model to draw
  - `count`: The number of instances to draw
  - `attributes`: Optional attributes to apply only for this draw call
- `static System.Void GenerateMipMaps(Sandbox.Texture texture, Sandbox.Graphics.DownsampleMethod downsampleMethod, System.Int32 initialMip, System.Int32 numMips)`
  - Generate the mip maps for this texture. Obviously the texture needs to support mip maps.
- `static System.Void ResourceBarrierTransition(Sandbox.Texture texture, Sandbox.Rendering.ResourceState state, System.Int32 mip)`
  - Executes a barrier transition for the given GPU Texture Resource.
Transitions the texture resource to a new pipeline stage and access state.
  - `texture`: The texture to transition.
  - `state`: The new resource state for the texture.
  - `mip`: The mip level to transition (-1 for all mips).
- `static System.Void ResourceBarrierTransition(Sandbox.GpuBuffer<T> buffer, Sandbox.Rendering.ResourceState state)`
- `static System.Void ResourceBarrierTransition(Sandbox.GpuBuffer buffer, Sandbox.Rendering.ResourceState state)`
  - Executes a barrier transition for the given GPU Buffer Resource.
Transitions the buffer resource to a new pipeline stage and access state.
  - `buffer`: The GPU buffer to transition.
  - `state`: The new resource state for the buffer.
- `static System.Void ResourceBarrierTransition(Sandbox.GpuBuffer<T> buffer, Sandbox.Rendering.ResourceState before, Sandbox.Rendering.ResourceState after)`
- `static System.Void ResourceBarrierTransition(Sandbox.GpuBuffer buffer, Sandbox.Rendering.ResourceState before, Sandbox.Rendering.ResourceState after)`
  - Executes a barrier transition for the given GPU Buffer Resource.
Transitions the buffer resource from a known source state to a specified destination state.
  - `buffer`: The GPU buffer to transition.
  - `before`: The current resource state of the buffer.
  - `after`: The desired resource state of the buffer after the transition.
- `static System.Void UavBarrier(Sandbox.Texture texture)`
  - Issues a UAV barrier for the given texture, ensuring writes from prior shader invocations
are visible to subsequent ones without changing the resource layout.
  - `texture`: The texture to barrier.
- `static System.Void UavBarrier(Sandbox.GpuBuffer buffer)`
  - Issues a UAV barrier for the given GPU buffer, ensuring writes from prior shader invocations
are visible to subsequent ones.
  - `buffer`: The buffer to barrier.
