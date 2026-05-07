# Sandbox.Resources.TextureGenerator

- **Kind:** abstract class
- **Namespace:** `Sandbox.Resources`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Resources.ResourceGenerator<T>`

## Constructors

- `TextureGenerator()`

## Methods

### Instance methods

- `virtual System.Threading.Tasks.ValueTask<Sandbox.Texture> CreateTexture(Sandbox.Resources.ResourceGenerator.Options options, System.Threading.CancellationToken ct)`
  - Find an existing texture for this
- `virtual Sandbox.Texture Create(Sandbox.Resources.ResourceGenerator.Options options)`
  - Create a texture. Will replace a placeholder texture, which will turn into the generated texture later, if it's not immediately available.
- `virtual System.Threading.Tasks.ValueTask<Sandbox.Texture> CreateAsync(Sandbox.Resources.ResourceGenerator.Options options, System.Threading.CancellationToken token)`
  - Create a texture. Will wait until the texture is fully loaded and return when done.
- `virtual System.Nullable<Sandbox.Resources.EmbeddedResource> CreateEmbeddedResource()`
