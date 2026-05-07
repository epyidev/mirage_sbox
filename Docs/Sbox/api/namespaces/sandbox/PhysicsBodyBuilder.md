# Sandbox.PhysicsBodyBuilder

Provides ability to generate a physics body for a `Sandbox.Model` at runtime.
See `Sandbox.ModelBuilder.AddBody(System.Single,Sandbox.Surface,System.String)`

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Single Mass`
  - The mass of the body in kilograms.  
Set to `0` to calculate automatically from its shapes and density.
- `Sandbox.Surface Surface`
  - The surface properties applied to this body.
- `Transform BindPose`
  - The bind pose transform used when attaching this body to a bone.
- `System.String BoneName`
  - The name of the bone this body is attached to, or `null` if not attached.

## Methods

### Instance methods

- `Sandbox.PhysicsBodyBuilder SetMass(System.Single mass)`
- `Sandbox.PhysicsBodyBuilder SetSurface(Sandbox.Surface surface)`
- `Sandbox.PhysicsBodyBuilder SetBindPose(Transform bindPose)`
- `Sandbox.PhysicsBodyBuilder SetBoneName(System.String boneName)`
- `Sandbox.PhysicsBodyBuilder AddSphere(Sandbox.Sphere sphere, System.Nullable<Transform> transform)`
- `Sandbox.PhysicsBodyBuilder AddCapsule(Capsule capsule, System.Nullable<Transform> transform)`
- `Sandbox.PhysicsBodyBuilder AddHull(System.Span<Vector3> points, System.Nullable<Transform> transform, System.Nullable<Sandbox.PhysicsBodyBuilder.HullSimplify> simplify)`
- `Sandbox.PhysicsBodyBuilder AddMesh(System.Span<Vector3> vertices, System.Span<System.UInt32> indices, System.Span<System.Byte> materials)`
