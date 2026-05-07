# Sandbox.Resources.RandomTextureGenerator

- **Kind:** class
- **Namespace:** `Sandbox.Resources`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Resources.TextureGenerator`

## Constructors

- `RandomTextureGenerator()`

## Properties

- `Sandbox.Resources.RandomTextureGenerator.NoiseType Type`
- `System.Int32 Seed`
- `Vector2Int Size`
- `Vector3 Offset`
- `System.Single Scale`
- `System.Int32 Octaves`
- `Sandbox.Gradient Gradient`
- `System.Boolean ConvertHeightToNormals`
- `System.Single NormalScale`
- `System.Boolean CacheToDisk`

## Methods

### Static methods

- `static System.Single IntToRandomFloat(System.Int64 seed)`

### Instance methods

- `virtual System.Threading.Tasks.ValueTask<Sandbox.Texture> CreateTexture(Sandbox.Resources.ResourceGenerator.Options options, System.Threading.CancellationToken ct)`
