# Sandbox.BeamEffect.BeamInstance

Represents an individual beam instance within the effect.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.BeamEffect`

## Constructors

- `BeamInstance()`

## Properties

- `System.Single Delta`
  - Returns the normalized lifetime of the beam, ranging from 0 (just born) to 1 (expired).

## Fields

- `Vector3 StartPosition`
  - Start position of the beam in world space.
- `Vector3 EndPosition`
  - End position of the beam in world space.
- `Sandbox.LineRenderer Renderer`
  - LineRenderer component used to render the beam visually.
- `System.Single TimeBorn`
  - Time when the beam was created (born).
- `System.Single TimeDie`
  - Time when the beam will expire (die).
- `System.Int32 RandomSeed`
  - Random seed used to generate consistent random values for this beam instance.

## Methods

### Instance methods

- `System.Void Destroy()`
  - Destroys the beam instance, cleaning up its resources.
