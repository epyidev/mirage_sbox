# Sandbox.ParticleSystem

A particle effect system that allows for complex visual effects, such as
explosions, muzzle flashes, impact effects, etc.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Resource`

## Constructors

- `ParticleSystem()`

## Properties

- `System.Boolean IsValid`
- `System.Boolean IsError`
  - Whether the particle system is invalid, or has not yet loaded.
- `System.String Name`
  - Particle system file name.
- `BBox Bounds`
  - Static bounding box of the resource.
- `System.Int32 ChildCount`
  - How many child particle systems do we have

## Methods

### Static methods

- `static Sandbox.ParticleSystem Load(System.String filename)`
  - Loads a particle system from given file.
- `static System.Threading.Tasks.Task<Sandbox.ParticleSystem> LoadAsync(System.String filename)`
  - Load a particle system by file path.
  - `filename`: The file path to load as a particle system.
  - returns: The loaded particle system, or null

### Instance methods

- `Sandbox.ParticleSystem GetChild(System.Int32 index)`
  - Returns child particle at given index.
  - `index`: Index of child particle system, starting at 0.
  - returns: Particle system
