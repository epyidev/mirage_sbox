# Sandbox.BeamEffect

The BeamEffect component creates a visual beam effect in the scene, simulating a continuous line or laser-like effect.
Unlike LineRenderer these beams can change over time, spawn multiple instances, and have various properties like color, texture, and lifetime.
This is a useful component for creating things like laser beams, energy effects and tracers.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `BeamEffect()`

## Properties

- `Sandbox.ParticleFloat Scale`
  - Thickness of the beam in world units. Controls how wide the beam appears.
- `Vector3 TargetPosition`
  - World position the beam targets if no target object is set. Used as the endpoint for the beam.
- `Sandbox.GameObject TargetGameObject`
  - GameObject to target with the beam. If assigned, overrides TargetPosition and uses the object's world position as the endpoint.
- `Vector3 TargetRandom`
  - Random offset applied to the target position for visual variation. Adds randomness to the endpoint.
- `System.Boolean FollowPoints`
  - If true, the beam endpoints follow their source and target positions each frame, updating dynamically.
- `System.Single BeamsPerSecond`
  - Number of beams spawned per second. Controls the spawn rate for continuous effects.
- `System.Int32 MaxBeams`
  - Maximum number of beams that can exist at once. Limits the total active beams.
- `System.Int32 InitialBurst`
  - Number of beams spawned immediately when the effect is enabled.
- `Sandbox.ParticleFloat BeamLifetime`
  - Lifetime of each beam in seconds. Determines how long a beam remains before being removed or respawned.
- `System.Boolean Looped`
  - If true, beams respawn automatically when they expire, creating a looping effect.
- `Sandbox.Texture Texture`
  - Texture applied to the beam. Defines the visual appearance along the beam's length.
- `Sandbox.Material Material`
  - Material applied to the beam. Defines the visual appearance along the beam's length.
The material should be based on the `line.shader`.
- `Sandbox.ParticleFloat TextureOffset`
  - Offset of the texture along the beam. Shifts the texture start position.
- `Sandbox.ParticleFloat TextureScale`
  - Scale of the texture along the beam. Controls how many world units each texture tile covers.
- `Sandbox.ParticleFloat TextureScrollSpeed`
  - Speed at which the texture scrolls along the beam. Positive values scroll in one direction, negative in the other.
- `Sandbox.ParticleFloat TextureScroll`
  - This is pretty much the same as TextureOffset - but it's seperate so you can use offset for offset, and scroll to scroll.
- `Sandbox.Rendering.FilterMode FilterMode`
  - Controls texture filtering on this beam effect.
- `Sandbox.ParticleGradient BeamColor`
  - Color gradient of the beam over its lifetime. Defines how the color changes from birth to death.
- `Sandbox.ParticleFloat Alpha`
  - Alpha multiplier for the beam's color. Controls transparency over the beam's lifetime.
- `Sandbox.ParticleFloat Brightness`
  - Brightness multiplier for the beam's color. Adjusts intensity over the beam's lifetime.
- `System.Boolean Additive`
  - If true, the beam is rendered additively, making it appear to glow.
- `System.Boolean Shadows`
  - If true, the beam casts shadows in the scene.
- `System.Boolean Lighting`
  - If true, the beam is affected by scene lighting.
- `System.Boolean Opaque`
  - If true, the beam is rendered as opaque rather than transparent.
- `System.Single DepthFeather`
  - Amount of feathering applied to the beam's depth, softening its intersection with geometry.
- `System.Boolean TravelBetweenPoints`
  - If true, the beam visually travels from start to end, useful for tracer effects.
- `Sandbox.ParticleFloat TravelLerp`
  - Controls the interpolation of the beam's travel effect over its lifetime.

## Methods

### Instance methods

- `Sandbox.BeamEffect.BeamInstance SpawnBeam()`
  - Spawns a new beam and adds it to the effect.
