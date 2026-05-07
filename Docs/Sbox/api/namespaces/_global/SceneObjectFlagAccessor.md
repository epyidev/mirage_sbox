# Sandbox.SceneObject.SceneObjectFlagAccessor

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.SceneObject`

## Properties

- `System.Boolean CastShadows`
  - Whether this scene object should cast shadows.
- `System.Boolean IsOpaque`
- `System.Boolean IsTranslucent`
- `System.Boolean IsDecal`
- `System.Boolean OverlayLayer`
- `System.Boolean ExcludeGameLayer`
  - Don't render in the opaque/translucent game passes. This is useful when you
want to only render in the Bloom layer, rather than additionally to it.
- `System.Boolean ViewModelLayer`
- `System.Boolean SkyBoxLayer`
- `System.Boolean NeedsLightProbe`
- `System.Boolean NeedsEnvironmentMap`
  - True if this object needs cubemap information
- `System.Boolean WantsFrameBufferCopy`
  - Automatically sets the "FrameBufferCopyTexture" attribute within the material.
This does the same thing as Render.CopyFrameBuffer(); except automatically if
the pass allows for it.
- `System.Boolean IncludeInCubemap`
  - Draw this in cubemaps
- `System.Boolean WantsPrePass`
