# Sandbox.SceneParticles

A SceneObject used to render particles.
We need to be careful with what we do here, because this object is created for in-engine particles
as well as custom scene object particles.
With custom particles there's no automatic Simulate, or deletion.. You're completely on your own. This
is perhaps a good thing though, it's maybe what you want to happen. To be completely isolated and completely
in control. But at the same time maybe it's not and it's something we need to sort out.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.SceneObject`

## Constructors

- `SceneParticles(Sandbox.SceneWorld world, System.String particleSystem)`
  - Create scene particles.
  - `world`: The scene world to create the particles in.
  - `particleSystem`: Path to the particle system file.
- `SceneParticles(Sandbox.SceneWorld world, Sandbox.ParticleSystem particleSystem)`
  - Create scene particles.
  - `world`: The scene world to create the particles in.
  - `particleSystem`: Particle system resource.

## Properties

- `System.Boolean RenderParticles`
  - Whether to render the particles or not.
- `System.Boolean EmissionStopped`
  - Stop (or start) the particle system emission.
- `Sandbox.PhysicsWorld PhysicsWorld`
  - Particle collisions use this physics world to perform traces.
- `System.Int32 ActiveParticlesSelf`
  - The amount of particles
- `System.Int32 ActiveParticlesTotal`
  - The amount of particles including child systems
- `System.Int32 MaximumParticles`
  - The total allowed particle count
- `System.Boolean Finished`
  - True if particle system has reached the end
- `System.Single SimulationTime`
  - Get or set the simulation time

## Methods

### Instance methods

- `System.Boolean IsControlPointSet(System.Int32 index)`
  - Whether given control point has any data set.
  - `index`: The control point index. Range is 0-63.
- `Vector3 GetControlPointPosition(System.Int32 index)`
  - Returns the position set on a given control point.
  - `index`: The control point index. Range is 0-63.
- `System.Void SetControlPoint(System.Int32 i, Vector3 position)`
  - Set position on given control point.
  - `i`: The control point index. Range is 0-63.
  - `position`: The position to set.
- `System.Void SetControlPoint(System.Int32 i, Rotation rotation)`
  - Set rotation on given control point.
  - `i`: The control point index. Range is 0-63.
  - `rotation`: The rotation to set.
- `System.Void SetControlPoint(System.Int32 i, Transform transform)`
  - Set transform on given control point.
  - `i`: The control point index. Range is 0-63.
  - `transform`: The transform to set.
- `System.Void SetControlPoint(System.Int32 i, Sandbox.ParticleSnapshot snapshot)`
  - Set snapshot on given control point.
  - `i`: The control point index. Range is 0-63.
  - `snapshot`: The snapshot to set.
- `System.Void SetControlPoint(System.Int32 i, Sandbox.Model model)`
  - Set model on given control point.
  - `i`: The control point index. Range is 0-63.
  - `model`: The model to set.
- `System.Void SetNamedValue(System.String name, Vector3 value)`
  - Set vector on given named value.
  - `name`: The name of the key.
  - `value`: The value to set.
- `System.Void Simulate(System.Single f)`
  - Simulate the particles for given amount of time.
  - `f`: Amount of time has passed since last simulation.
- `System.Void Emit(System.Int32 count)`
  - Manually emit a bunch of particles
