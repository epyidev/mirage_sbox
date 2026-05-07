# Sandbox.Diagnostics.FrameStats

Stats returned from the engine each frame describing what was rendered, and how much of it.

- **Kind:** struct
- **Namespace:** `Sandbox.Diagnostics`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static Sandbox.Diagnostics.FrameStats Current`
- `System.Double ObjectsRendered`
  - Number of objects that passed all cull checks and were rendered.
- `System.Double ObjectsPreCull`
  - Number of objects considered before culling.
- `System.Double ObjectsTested`
  - Number of objects that were tested against cull checks.
- `System.Double BaseObjectDraws`
  - Primitive draws for base (static) scene objects.
- `System.Double AnimatableObjectDraws`
  - Primitive draws for animatable scene objects.
- `System.Double RenderBatchDraws`
  - Number of render batch draw lists submitted.
- `System.Double TrianglesRendered`
  - Total number of triangles rendered.
- `System.Double DrawCalls`
  - Number of draw calls.
- `System.Double MaterialChanges`
  - Number of non-shadow (colour pass) material changes.
- `System.Double ShadowMaterialChanges`
  - Number of depth-only (shadow pass) material changes.
- `System.Double InitialMaterialChanges`
  - Number of initial material changes (first bind of a material this frame).
- `System.Double UniqueMaterials`
  - Number of unique materials seen this frame.
- `System.Double DisplayLists`
  - Number of display lists submitted to the GPU.
- `System.Double SceneViewsRendered`
  - Number of scene views rendered.
- `System.Double RenderTargetResolves`
  - Number of render target resolves.
- `System.Double PrimaryContexts`
  - Number of primary render contexts created.
- `System.Double SecondaryContexts`
  - Number of secondary render contexts created.
- `System.Double ObjectsCulledByVis`
  - Number of objects culled by static visibility.
- `System.Double ObjectsCulledByScreenSize`
  - Number of objects culled by screen size.
- `System.Double ObjectsCulledByFade`
  - Number of objects culled by distance fading.
- `System.Double ObjectsFading`
  - Number of objects currently being distance-faded.
- `System.Double ShadowedLightsInView`
  - Number of lights in view that cast shadows.
- `System.Double UnshadowedLightsInView`
  - Number of lights in view that don't cast shadows.
- `System.Double ShadowMaps`
  - Number of shadow maps rendered this frame.
