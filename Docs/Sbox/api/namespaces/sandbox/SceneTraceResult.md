# Sandbox.SceneTraceResult

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Single Distance`
  - The distance between start and end positions.

## Fields

- `Sandbox.Scene Scene`
- `System.Boolean Hit`
  - Whether the trace hit something or not
- `System.Boolean StartedSolid`
  - Whether the trace started in a solid
- `Vector3 StartPosition`
  - The start position of the trace
- `Vector3 EndPosition`
  - The end or hit position of the trace
- `Vector3 HitPosition`
  - The hit position of the trace. Requires `Sandbox.SceneTrace.UseHitPosition(System.Boolean)`.
- `Vector3 Normal`
  - The hit surface normal (direction vector)
- `System.Single Fraction`
  - A fraction [0..1] of where the trace hit between the start and the original end positions
- `Sandbox.GameObject GameObject`
  - The GameObject that was hit
- `Sandbox.Component Component`
  - The Component that was hit
- `Sandbox.Collider Collider`
  - The Collider that was hit
- `Sandbox.PhysicsBody Body`
  - The physics object that was hit, if any
- `Sandbox.PhysicsShape Shape`
  - The physics shape that was hit, if any
- `Sandbox.Surface Surface`
  - The physical properties of the hit surface
- `System.Int32 Bone`
  - The id of the hit bone (either from hitbox or physics shape)
- `Vector3 Direction`
  - The direction of the trace ray
- `System.Int32 Triangle`
  - The triangle index hit, if we hit a mesh <see cref="T:Sandbox.PhysicsShape">physics shape</see>
- `System.String[] Tags`
  - The tags that the hit shape had
- `Sandbox.Hitbox Hitbox`
  - The hitbox that we hit

## Methods

### Static methods

- `static Sandbox.SceneTraceResult From(Sandbox.Scene scene, Sandbox.PhysicsTraceResult r)`
- `static Sandbox.SceneTraceResult From(Sandbox.Scene scene, Sandbox.Engine.Utility.RayTrace.MeshTraceRequest.Result r)`
