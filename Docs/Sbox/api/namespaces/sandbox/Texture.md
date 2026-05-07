# Sandbox.Texture

A texture is an image used in rendering. Can be a static texture loaded from disk, or a dynamic texture rendered to by code.
Can also be 2D, 3D (multiple slices), or a cube texture (6 slices).

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Resource`

## Properties

- `System.Boolean IsError`
  - Whether this texture is an error or invalid or not.
- `System.Boolean IsValid`
- `Sandbox.TextureFlags Flags`
  - Flags providing hints about this texture
- `System.Int32 Index`
  - Texture index. Bit raw dog and needs a higher level abstraction.
- `System.Int32 Width`
  - Width of the texture in pixels.
- `System.Int32 Height`
  - Height of the texture in pixels.
- `System.Int32 Depth`
  - Depth of a 3D texture in pixels, or slice count for 2D texture arrays, or 6 for slices of cubemap.
- `System.Int32 Mips`
  - Number of <a href="https://en.wikipedia.org/wiki/Mipmap">mip maps</a> this texture has.
- `Vector2 Size`
  - Returns a Vector2 representing the size of the texture (width, height)
- `System.Boolean IsLoaded`
  - Whether this texture has finished loading or not.
- `Sandbox.ImageFormat ImageFormat`
  - Image format of this texture.
- `System.Int32 LastUsed`
  - Returns how many frames ago this texture was last used by the renderer
- `System.Boolean UAVAccess`
  - Gets if the texture has UAV access
- `Vector4 SequenceData`
  - If this texture is a sprite sheet, will return information about the sheet, which
is generally used in the shader. You don't really need to think about the contents.
- `System.Int32 SequenceCount`
  - The count of sequences in this texture, if any. The rest of the sequence data is encoded into the texture itself.
- `System.Boolean HasAnimatedSequences`
- `static Sandbox.Texture Invalid`
  - 1x1 solid magenta colored texture.
- `static Sandbox.Texture White`
  - 1x1 solid white opaque texture.
- `static Sandbox.Texture Black`
  - 1x1 solid black opaque texture.
- `static Sandbox.Texture Transparent`
  - 1x1 fully transparent texture.

## Methods

### Static methods

- `static Sandbox.TextureBuilder CreateCustom()`
  - Begins creation of a custom texture. Finish by calling `Sandbox.TextureBuilder.Create(System.String,System.Boolean,System.ReadOnlySpan{System.Byte},System.Int32)`.
- `static Sandbox.Texture2DBuilder Create(System.Int32 width, System.Int32 height, Sandbox.ImageFormat format)`
  - Begins creation of a custom texture. Finish by calling `Sandbox.Texture2DBuilder.Finish`.
- `static Sandbox.Texture3DBuilder CreateVolume(System.Int32 width, System.Int32 height, System.Int32 depth, Sandbox.ImageFormat format)`
  - Begins creation of a custom 3D texture. Finish by calling `Sandbox.Texture3DBuilder.Finish`.
- `static Sandbox.TextureCubeBuilder CreateCube(System.Int32 width, System.Int32 height, Sandbox.ImageFormat format)`
  - Begins creation of a custom cube texture. (A texture with 6 sides) Finish by calling `Sandbox.TextureCubeBuilder.Finish`.
- `static Sandbox.TextureArrayBuilder CreateArray(System.Int32 width, System.Int32 height, System.Int32 count, Sandbox.ImageFormat format)`
  - Begins creation of a custom texture array. Finish by calling `Sandbox.TextureArrayBuilder.Finish`.
- `static Sandbox.TextureBuilder CreateRenderTarget()`
  - Begins creation of a <a href="https://en.wikipedia.org/wiki/Render_Target">render target</a>. Finish by calling `Sandbox.TextureBuilder.Create(System.String,System.Boolean,System.ReadOnlySpan{System.Byte},System.Int32)`.
  - returns: The texture builder to help build the render target.
- `static Sandbox.Texture CreateRenderTarget(System.String name, Sandbox.ImageFormat format, Vector2 size)`
  - A convenience function to quickly create a <a href="https://en.wikipedia.org/wiki/Render_Target">render target</a>.
  - `name`: A meaningless debug name for your texture.
  - `format`: The image format.
  - `size`: The size of the texture.
  - returns: The newly created render target texture.
- `static Sandbox.Texture CreateRenderTarget(System.String name, Sandbox.ImageFormat format, Vector2 size, Sandbox.Texture oldTexture)`
  - This will create a <a href="https://en.wikipedia.org/wiki/Render_Target">render target</a> texture if `oldTexture` is null or doesn't match what you've passed in. This is designed
to be called regularly to resize your texture in response to other things changing (like the screen size, panel size etc).
  - `name`: A meaningless debug name for your texture.
  - `format`: The image format.
  - `size`: The size of the texture.
  - `oldTexture`: A previously created texture.
  - returns: Will return a new texture, or the `oldTexture`.
- `static Sandbox.Texture CreateFromSvgSource(System.String svgContents, System.Nullable<System.Int32> width, System.Nullable<System.Int32> height, System.Nullable<Color> color)`
- `static Sandbox.Texture Load(Sandbox.BaseFileSystem filesystem, System.String filepath, System.Boolean warnOnMissing)`
  - Try to load a texture from given filesystem, by filename.
- `static Sandbox.Texture LoadFromFileSystem(System.String filepath, Sandbox.BaseFileSystem filesystem, System.Boolean warnOnMissing)`
  - Try to load a texture from given filesystem, by filename.
- `static Sandbox.Texture Load(System.String path_or_url, System.Boolean warnOnMissing)`
  - Try to load a texture.
- `static Sandbox.Texture LoadAvatar(System.Int64 steamid, System.Int32 size)`
  - Load avatar image of a Steam user (with a certain size if supplied).
  - `steamid`: The SteamID of the user to load the avatar of.
  - `size`: The size of the avatar (Can be 32, 64, or 128. Defaults to 64 and rounds input to nearest of the three).
  - returns: The avatar texture
- `static Sandbox.Texture LoadAvatar(System.String steamid, System.Int32 size)`
- `static System.Threading.Tasks.Task<Sandbox.Texture> LoadAsync(Sandbox.BaseFileSystem filesystem, System.String filepath, System.Boolean warnOnMissing)`
  - Load a texture asynchronously. Will return when the texture is loaded and valid.
This is useful when loading textures from the web.
- `static System.Threading.Tasks.Task<Sandbox.Texture> LoadAsync(System.String filepath, System.Boolean warnOnMissing)`
  - Load a texture asynchronously. Will return when the texture is loaded and valid.
This is useful when loading textures from the web, or without any big loading hitches.
- `static System.Threading.Tasks.Task<Sandbox.Texture> LoadFromFileSystemAsync(System.String filepath, Sandbox.BaseFileSystem filesystem, System.Boolean warnOnMissing)`
  - Load a texture asynchronously. Will return when the texture is loaded and valid.
This is useful when loading textures from the web, or without any big loading hitches.
- `static Sandbox.Texture Find(System.String filepath)`
  - Try to get an already loaded texture.
  - `filepath`: The filename of the texture.
  - returns: The already loaded texture, or null if it was not yet loaded.

### Instance methods

- `virtual System.Void Finalize()`
- `virtual System.Void Dispose()`
  - Will release the handle for this texture. If the texture isn't referenced by anything
else it'll be released properly. This will happen anyway because it's called in the destructor.
By calling it manually you're just telling the engine you're done with this texture right now
instead of waiting for the garbage collector.
- `System.Int32 GetSequenceFrameCount(System.Int32 sequenceId)`
  - Get the frame count for this sequence
- `System.Void MarkUsed(System.Int32 requiredMipSize)`
  - Tells texture streaming this texture is being used.
This is usually automatic, but useful for bindless pipelines.
- `Color32[] GetPixels(System.Int32 mip)`
  - Reads pixel colors from the texture at the specified mip level
- `Sandbox.Bitmap GetBitmap(System.Int32 mip)`
- `System.Void GetPixels(System.ValueTuple<System.Int32,System.Int32,System.Int32,System.Int32> srcRect, System.Int32 slice, System.Int32 mip, System.Span<T> dstData, Sandbox.ImageFormat dstFormat, System.ValueTuple<System.Int32,System.Int32> dstSize)`
- `System.Void GetPixels(System.ValueTuple<System.Int32,System.Int32,System.Int32,System.Int32> srcRect, System.Int32 slice, System.Int32 mip, System.Span<T> dstData, Sandbox.ImageFormat dstFormat, System.ValueTuple<System.Int32,System.Int32,System.Int32,System.Int32> dstRect, System.Int32 dstStride)`
- `System.Void GetPixels3D(System.ValueTuple<System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32> srcBox, System.Int32 mip, System.Span<T> dstData, Sandbox.ImageFormat dstFormat, System.ValueTuple<System.Int32,System.Int32,System.Int32> dstSize)`
- `Color32 GetPixel(System.Single x, System.Single y, System.Int32 mip)`
  - Reads a single pixel color.
- `Color32 GetPixel3D(System.Single x, System.Single y, System.Single z, System.Int32 mip)`
  - Reads a single pixel color from a volume or array texture.
- `System.Void GetPixelsAsync(System.Action<System.ReadOnlySpan<Color32>> callback, System.Int32 mip)`
- `System.Void GetPixelsAsync(System.Action<System.ReadOnlySpan<T>> callback, Sandbox.ImageFormat dstFormat, System.ValueTuple<System.Int32,System.Int32,System.Int32,System.Int32> srcRect, System.Int32 slice, System.Int32 mip)`
- `System.Void GetPixelsAsync3D(System.Action<System.ReadOnlySpan<T>> callback, Sandbox.ImageFormat dstFormat, System.ValueTuple<System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32> srcBox, System.Int32 mip)`
- `System.Void GetBitmapAsync(System.Action<Sandbox.Bitmap> callback, System.Int32 mip)`
- `System.Byte[] SaveToVtex(System.Nullable<Sandbox.ImageFormat> formatOverride)`
- `System.Threading.Tasks.Task<System.Byte[]> SaveToVtexAsync(System.Nullable<Sandbox.ImageFormat> format)`
- `System.Void Clear(Color color)`
  - Clear this texture with a solid color
- `System.Void Update(System.ReadOnlySpan<System.Byte> data, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height)`
- `System.Void Update(System.ReadOnlySpan<T> data, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height)`
- `System.Void Update(System.ReadOnlySpan<Color32> data, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height)`
- `System.Void Update(Sandbox.Bitmap source)`
  - Update this texture from the bitmap
- `System.Void Update3D(System.ReadOnlySpan<System.Byte> data, System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 width, System.Int32 height, System.Int32 depth)`
- `System.Void Update(Color32 color, Sandbox.Rect rect)`
  - Write a coloured rectangle to the texture
- `System.Void Update(Color32 color, System.Single x, System.Single y)`
  - Write a coloured pixel to the texture
