# Sandbox.EnvmapProbe

A cubemap probe that captures the environment around it.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `EnvmapProbe()`

## Properties

- `Sandbox.EnvmapProbe.EnvmapProbeMode Mode`
- `Sandbox.SceneCubemap.ProjectionMode Projection`
- `Color TintColor`
- `BBox Bounds`
- `System.Single Feathering`
- `System.Int32 Priority`
  - Gets or sets the priority level for the object.
- `Sandbox.Texture Texture`
  - If this is set, the EnvmapProbe will use a custom cubemap texture instead of rendering dynamically
- `Sandbox.Texture BakedTexture`
  - The texture that was baked for this envmap probe
- `System.Boolean RenderDynamically`
- `Sandbox.EnvmapProbe.CubemapResolution Resolution`
  - Resolution of the cubemap texture
- `System.Single ZNear`
- `System.Single ZFar`
- `Sandbox.EnvmapProbe.CubemapDynamicUpdate UpdateStrategy`
- `System.Single MaxDistance`
  - Only update dynamically if we're this close to it
- `System.Single DelayBetweenUpdates`
- `System.Int32 FrameInterval`
- `System.Boolean MultiBounce`
  - Minimum amount of reflection bounces to render when first enabled before settling, at cost of extra performance on load
Often times you don't need this
- `System.Int32 ComponentVersion`

## Fields

- `System.Boolean Dirty`

## Methods

### Static methods

- `static System.Threading.Tasks.Task BakeAll()`

### Instance methods

- `System.Threading.Tasks.Task Bake(System.Threading.CancellationToken ct)`
  - Bake this envmap now. This will stop it being dynamic if it was.
