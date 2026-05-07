# Sandbox.SceneCubemap

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.SceneLight`

## Constructors

- `SceneCubemap(Sandbox.SceneWorld sceneWorld)`
- `SceneCubemap(Sandbox.SceneWorld sceneWorld, Sandbox.Texture texture, BBox bounds)`

## Properties

- `System.Int32 Priority`
- `Sandbox.SceneCubemap.ProjectionMode Projection`
- `Color TintColor`
- `System.Single Feathering`
- `BBox ProjectionBounds`
- `Sandbox.Texture Texture`

## Methods

### Instance methods

- `System.Void RenderDirty()`
  - Marks the cubemap as dirty, to be re-rendered on the next render.
