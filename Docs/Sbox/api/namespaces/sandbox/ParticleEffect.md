# Sandbox.ParticleEffect

Defines and holds particles. This is the core of the particle system.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `ParticleEffect()`

## Properties

- `System.Int32 MaxParticles`
  - The maximum number of particles that can exist in this effect at once.
- `Sandbox.ParticleFloat Lifetime`
  - The lifetime of each particle, in seconds.
- `System.Single TimeScale`
  - Scales the simulation time for this effect.
- `System.Single PreWarm`
  - How many seconds to pre-warm this effect by when creating.
- `Sandbox.ParticleFloat StartDelay`
  - The delay before a particle starts after being emitted, in seconds.
- `Sandbox.ParticleFloat PerParticleTimeScale`
  - Per-particle time scale multiplier. Allows each particle to have a unique simulation speed.
- `Sandbox.ParticleEffect.TimingMode Timing`
  - How time is updated for this effect.
- `Sandbox.ParticleVector3 InitialVelocity`
  - The initial velocity of the particle when it is created. This is applied before any forces are applied.
- `Sandbox.ParticleFloat StartVelocity`
  - Apply an element of random velocity to the particle when it is created, in a random direction.
- `Sandbox.ParticleFloat Damping`
  - The damping factor applied to particle velocity over time.
This reduces the velocity of particles, simulating resistance or drag.
- `Sandbox.ParticleVector3 ConstantMovement`
  - Move this delta constantly. Ignores velocity, collisions and drag.
- `Sandbox.ParticleEffect.SimulationSpace Space`
- `Sandbox.ParticleFloat LocalSpace`
  - When 1 particles will be moved in local space relative to the emitter GameObject's transform. 
This allows particles to be emitted in a local space, like a fire effect that moves with the player, but the particles can slowly move to world space.
- `System.Boolean ApplyRotation`
  - Enables or disables rotation for particles.
- `Sandbox.ParticleFloat Pitch`
  - The pitch rotation of the particles.
- `Sandbox.ParticleFloat Yaw`
  - The yaw rotation of the particles.
- `Sandbox.ParticleFloat Roll`
  - The roll rotation of the particles.
- `System.Boolean ApplyColor`
  - Enables or disables color application for particles.
- `System.Boolean ApplyAlpha`
  - Enables or disables alpha application for particles.
- `Color Tint`
  - The tint color applied to particles.
- `Sandbox.ParticleGradient Gradient`
  - The gradient used to color particles over their lifetime.
- `Sandbox.ParticleFloat Brightness`
  - The brightness multiplier applied to particles.
- `Sandbox.ParticleFloat Alpha`
  - The alpha transparency of particles.
- `System.Boolean ApplyShape`
  - Enables or disables shape application for particles.
- `Sandbox.ParticleFloat Scale`
  - The scale of particles.
- `Sandbox.ParticleFloat Stretch`
  - The stretch factor of particles, affecting their aspect ratio.
- `System.Boolean Force`
  - Enables or disables the application of forces to particles.
- `Vector3 ForceDirection`
  - The direction of the force applied to particles.
- `Sandbox.ParticleFloat ForceScale`
  - The scale of the force applied to each particle.
This multiplier determines the intensity of the force applied to particles.
- `Sandbox.ParticleVector3 OrbitalForce`
  - The orbital force applied to particles, causing them to rotate around a point.
- `Sandbox.ParticleFloat OrbitalPull`
  - The pull strength of the orbital force, drawing particles closer to the center.
- `Sandbox.ParticleEffect.SimulationSpace ForceSpace`
  - The simulation space in which forces are applied.
Forces can be applied in either local space (relative to the emitter) or world space.
- `System.Boolean Collision`
  - Enables or disables collision behavior for particles.
- `Sandbox.ParticleFloat DieOnCollisionChance`
  - The chance that a particle will die upon collision.
- `System.Single CollisionRadius`
  - The radius used for collision detection.
- `Sandbox.TagSet CollisionIgnore`
  - The set of tags to ignore during collision detection.
- `Sandbox.ParticleFloat Bounce`
  - The bounce factor applied to particles upon collision.
- `Sandbox.ParticleFloat Friction`
  - The friction factor applied to particles upon collision.
- `Sandbox.ParticleFloat Bumpiness`
  - The bumpiness factor applied to particles upon collision.
- `Sandbox.ParticleFloat PushStrength`
  - The strength of the push force applied to particles upon collision.
- `System.Boolean SheetSequence`
  - Enables or disables the use of a sheet sequence for particles.
- `Sandbox.ParticleFloat SequenceId`
  - Which sequence to use.
- `Sandbox.ParticleFloat SequenceTime`
  - Allows control of the sequence time, which spans from 0 to 1 for one loop.
- `Sandbox.ParticleFloat SequenceSpeed`
  - Increment the sequence time by this much.
- `System.Boolean SnapToFrame`
  - When enabled, snap to the nearest whole frame instead of blending between frames.
- `System.Boolean UsePrefabFeature`
  - Enables or disables the use of prefabs for particles.
- `System.Collections.Generic.List<Sandbox.GameObject> FollowerPrefab`
  - Will choose a random prefab to spawn from this list.
- `Sandbox.ParticleFloat FollowerPrefabChance`
  - If 1 then we'll always spawn a prefab. If 0.5 then we'll spawn a prefab 50% of the time.
- `System.Boolean FollowerPrefabKill`
  - When true the prefab will be destroyed at the end of the particle's life.
- `System.Collections.Generic.List<Sandbox.GameObject> CollisionPrefab`
  - Will choose a random prefab to spawn from this list.
- `System.Boolean CollisionPrefabAlign`
  - When true the collision prefab will be aligned with the surface it collides with.
- `Sandbox.ParticleFloat CollisionPrefabRotation`
  - We will by default align to the particle's angle, but we can also randomize that.
- `Sandbox.ParticleFloat CollisionPrefabChance`
  - If 1 then we'll always spawn a prefab. If 0.5 then we'll spawn a prefab 50% of the time.
- `System.Action<Sandbox.Particle> OnParticleDestroyed`
  - Called any time a particle is destroyed.
- `System.Action<Sandbox.Particle> OnParticleCreated`
  - Called any time a particle is created.
- `System.Collections.Generic.List<Sandbox.Particle> Particles`
  - Active particles in the effect.
Active particles are those currently being simulated and rendered.
- `System.Collections.Generic.List<Sandbox.Particle> DelayedParticles`
  - Delayed particles in the effect.
Delayed particles are those that have been emitted but are waiting to be activated based on their start delay.
- `System.Int32 ParticleCount`
  - The total number of particles in the effect, including both active and delayed particles.
- `System.Boolean IsFull`
  - Whether the particle effect has reached its maximum capacity.
This is determined by comparing the total particle count to the `Sandbox.ParticleEffect.MaxParticles` property.
- `System.Boolean Paused`
  - Whether the particle simulation is currently paused.
When paused, particles will not update their positions, velocities, or other properties.
- `System.Action<System.Single> OnPreStep`
  - Called before the particles are stepped.
This allows custom logic to be executed before the simulation advances.
- `System.Action<System.Single> OnPostStep`
  - Called after the particles are stepped.
This allows custom logic to be executed after the simulation advances.
- `System.Action<Sandbox.Particle,System.Single> OnStep`
  - Called after each particle is stepped.
This provides an opportunity to modify individual particles during the simulation.
- `BBox ParticleBounds`
  - The bounding box that encompasses all active particles.
This is useful for determining the spatial extent of the particle effect.
- `System.Single MaxParticleSize`
  - The size of the largest particle in the effect.
This is determined by the maximum scale of any particle along its x, y, or z axis.
- `System.Int32 ComponentVersion`

## Methods

### Instance methods

- `System.Void Clear()`
- `System.Void ResetEmitters()`
- `System.Void Step(System.Single timeDelta)`
- `Sandbox.Particle Emit(Vector3 position)`
- `Sandbox.Particle Emit(Vector3 position, System.Single delta)`
  - Emit a particle at the given position.
  - `position`: The position in which to spawn the particle
  - `delta`: The time delta of the spawn. The first spawned particle is 0, the last spawned particle is 1. This is used to evaluate the spawn particles like lifetime and delay.
  - returns: A particle, will never be null. It's up to you to obey max particles.
- `System.Void Terminate(Sandbox.Particle p)`
