# Sandbox.Particle

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `Particle()`

## Properties

- `System.Single LifeTimeRemaining`

## Fields

- `Vector3 Position`
- `Vector3 Size`
- `Vector3 Velocity`
- `Color Color`
- `Color OverlayColor`
- `System.Single Alpha`
- `System.Single BornTime`
- `System.Single Age`
- `System.Single Radius`
- `Angles Angles`
- `System.Int32 Sequence`
- `Vector3 SequenceTime`
- `System.Int32 Frame`
- `System.Single Random01`
- `System.Single Random02`
- `System.Single Random03`
- `System.Single Random04`
- `System.Single Random05`
- `System.Single Random06`
- `System.Single Random07`
- `Vector3 HitPos`
- `Vector3 HitNormal`
- `System.Single HitTime`
- `System.Single LastHitTime`
- `Vector3 StartPosition`
- `System.Single LifeDelta`
  - A range from 0 to 1 descriving how long this particle has been alive
- `System.Single DeathTime`
  - The time that this particle is scheduled to die
- `System.Single TimeScale`
- `static System.Collections.Generic.Queue<Sandbox.Particle> Pool`

## Methods

### Static methods

- `static Sandbox.Particle Create()`

### Instance methods

- `T Get(System.String key)`
  - Get an arbituary data value
- `System.Void Set(System.String key, T tvalue)`
  - Set an arbituary data value
- `System.Void ApplyDamping(System.Single amount)`
- `System.Single Rand(System.Int32 seed, System.Int32 line)`
- `System.Void AddListener(Sandbox.Particle.BaseListener i, Sandbox.Component sourceComponent)`
  - Add a listener.
- `System.Void RemoveListener(Sandbox.Particle.BaseListener i)`
  - Remove a listener
