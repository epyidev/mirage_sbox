# Sandbox.ParticleController

Particles can have extra controllers that can modify the particles every frame.

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `ParticleController()`

## Properties

- `Sandbox.ParticleEffect ParticleEffect`
  - The particle we're controlling

## Methods

### Instance methods

- `virtual System.Void OnEnabled()`
- `virtual System.Void OnDisabled()`
- `virtual System.Void OnBeforeStep(System.Single delta)`
  - Called before the particle step
- `virtual System.Void OnAfterStep(System.Single delta)`
  - Called after the particle step
- `virtual System.Void OnParticleStep(Sandbox.Particle particle, System.Single delta)`
  - Called for each particle during the particle step. This is super threaded
so you better watch out.
- `virtual System.Void OnParticleCreated(Sandbox.Particle p)`
- `virtual System.Void OnParticleDestroyed(Sandbox.Particle p)`
