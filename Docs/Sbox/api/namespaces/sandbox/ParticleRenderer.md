# Sandbox.ParticleRenderer

Renders a set of particles. Should be attached to a `Sandbox.ParticleRenderer.ParticleEffect`.

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Renderer`

## Constructors

- `ParticleRenderer()`

## Properties

- `Sandbox.ParticleEffect ParticleEffect`

## Methods

### Instance methods

- `virtual System.Void OnEnabled()`
- `virtual System.Void OnDisabled()`
- `virtual System.Void OnParticleCreated(Sandbox.Particle p)`
- `virtual BBox GetLocalBounds()`
  - Return the bounds of this renderer in local space.
