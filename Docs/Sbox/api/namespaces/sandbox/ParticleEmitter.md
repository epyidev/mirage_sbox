# Sandbox.ParticleEmitter

Creates particles. Should be attached to a `Sandbox.ParticleEffect`.

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `ParticleEmitter()`

## Properties

- `System.Boolean Loop`
  - Whether the emitter should restart after finishing
- `System.Boolean DestroyOnEnd`
  - Whether to destroy the GameObject when the emitter finishes (only applies when Loop is false)
- `Sandbox.ParticleFloat Duration`
  - How long the emitter should run for, after the Delay
- `Sandbox.ParticleFloat Delay`
  - How many seconds to wait before the emitter starts
- `Sandbox.ParticleFloat Burst`
  - How many particles to emit, in a burst
- `Sandbox.ParticleFloat Rate`
  - How many particles to emit over time
- `Sandbox.ParticleFloat RateOverDistance`
  - How many particles to emit per 100 units moved
- `System.Single Delta`
  - 0-1, the life time of the emitter
- `System.Boolean IsBursting`
  - True if we're doing a burst
- `System.Single EmitRandom`
  - 0-1, a random number to be used for this loop of the emitter

## Fields

- `System.Single time`
- `System.Single evaluatedRateOverDistance`

## Methods

### Instance methods

- `virtual System.Void OnEnabled()`
- `virtual System.Void OnDisabled()`
- `System.Void ResetEmitter()`
- `virtual System.Boolean Emit(Sandbox.ParticleEffect target)`
- `virtual System.Int32 GetBurstCount()`
  - Allows child emitters to override how many particles are in a burst
- `virtual System.Int32 GetRateCount()`
  - Allows child emitters to override how many particles are in a rate
- `virtual System.Void OnBurst()`
- `virtual System.Void EmitOverDistance()`
