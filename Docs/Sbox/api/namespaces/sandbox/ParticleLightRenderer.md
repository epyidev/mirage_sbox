# Sandbox.ParticleLightRenderer

Adds lighting to particles in your effect.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.ParticleController`

## Constructors

- `ParticleLightRenderer()`

## Properties

- `System.Single Ratio`
  - If 1, then every particle will get a light. If 0, no particles will get a light. If 0.5, half will get a particle.
- `System.Int32 MaximumLights`
- `System.Boolean CastShadows`
- `Sandbox.ParticleFloat Scale`
- `Sandbox.ParticleFloat Attenuation`
- `Sandbox.ParticleFloat Brightness`
- `Sandbox.ParticleGradient LightColor`
- `System.Boolean UseParticleColor`
