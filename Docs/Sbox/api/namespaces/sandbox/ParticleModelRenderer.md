# Sandbox.ParticleModelRenderer

Renders particles as models, using the particle's position, rotation, and size.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.ParticleController`

## Constructors

- `ParticleModelRenderer()`

## Properties

- `Sandbox.RenderOptions RenderOptions`
  - Render options for advanced rendering.
- `System.Collections.Generic.List<Sandbox.Model> Models`
  - List of models for rendering. This property is obsolete; use `Sandbox.ParticleModelRenderer.Choices` instead.
- `System.Collections.Generic.List<Sandbox.ParticleModelRenderer.ModelEntry> Choices`
  - List of model entries available for rendering.
- `Sandbox.Material MaterialOverride`
  - Material override for rendering.
- `System.Boolean RotateWithGameObject`
  - If true, the models will rotate relative to the this GameObject
- `Sandbox.ParticleFloat Scale`
  - Scale factor for particle rendering.
- `System.Boolean CastShadows`
  - Indicates whether particles cast shadows.
- `System.Int32 ComponentVersion`
  - Version of the component.
