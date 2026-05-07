# Sandbox.ParticleConeEmitter

Emits particles within/along a cone shape.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.ParticleEmitter`

## Constructors

- `ParticleConeEmitter()`

## Properties

- `System.Boolean OnEdge`
- `System.Boolean InVolume`
- `Sandbox.ParticleFloat ConeAngle`
- `Sandbox.ParticleFloat ConeNear`
- `Sandbox.ParticleFloat ConeFar`
- `Sandbox.ParticleFloat VelocityRandom`
  - Randomize the direction of the initial velocity. 0 = no randomization, 1 = full randomization.
- `Sandbox.ParticleFloat CenterBias`
  - When distributing should we bias the center of the cone
- `Sandbox.ParticleFloat CenterBiasVelocity`
  - Should particles near the center have more velocity
- `Sandbox.ParticleFloat VelocityMultiplier`
  - Multiply velocity by this

## Methods

### Instance methods

- `virtual System.Boolean Emit(Sandbox.ParticleEffect target)`
