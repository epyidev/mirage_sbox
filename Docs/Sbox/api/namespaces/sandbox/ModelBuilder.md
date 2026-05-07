# Sandbox.ModelBuilder

Provides ability to generate `Sandbox.Model`s at runtime.
A static instance of this class is available at `Sandbox.Model.Builder`

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `ModelBuilder()`

## Methods

### Instance methods

- `Sandbox.AnimationBuilder AddAnimation(System.String name, System.Single frameRate)`
  - Adds an animation to this model and returns a builder to construct the animation.
  - `name`: The name of the animation.
  - `frameRate`: The frames per second of the animation.
  - returns: An `Sandbox.AnimationBuilder` instance to construct the animation.
- `Sandbox.ModelBuilder WithMass(System.Single mass)`
  - Total mass of the physics body (Default is 1000)
- `Sandbox.ModelBuilder WithSurface(System.String name)`
  - Surface property to use for collision
- `Sandbox.ModelBuilder WithLodDistance(System.Int32 lod, System.Single distance)`
  - LOD switch distance increment for each Level of Detail (LOD) level. (Default is 50)
- `Sandbox.ModelBuilder AddCollisionBox(Vector3 extents, System.Nullable<Vector3> center, System.Nullable<Rotation> rotation)`
- `Sandbox.ModelBuilder AddCollisionSphere(System.Single radius, Vector3 center)`
  - Add sphere collision shape.
- `Sandbox.ModelBuilder AddCollisionCapsule(Vector3 center0, Vector3 center1, System.Single radius)`
  - Add capsule collision shape.
- `Sandbox.ModelBuilder AddCollisionHull(System.Collections.Generic.List<Vector3> vertices, System.Nullable<Vector3> center, System.Nullable<Rotation> rotation)`
- `Sandbox.ModelBuilder AddCollisionHull(System.Span<Vector3> vertices, System.Nullable<Vector3> center, System.Nullable<Rotation> rotation)`
- `Sandbox.ModelBuilder AddCollisionMesh(System.Collections.Generic.List<Vector3> vertices, System.Collections.Generic.List<System.Int32> indices)`
- `Sandbox.ModelBuilder AddCollisionMesh(System.Collections.Generic.List<Vector3> vertices, System.Collections.Generic.List<System.Int32> indices, System.Collections.Generic.List<System.Byte> materials)`
- `Sandbox.ModelBuilder AddCollisionMesh(System.Span<Vector3> vertices, System.Span<System.Int32> indices)`
- `Sandbox.ModelBuilder AddCollisionMesh(System.Span<Vector3> vertices, System.Span<System.Int32> indices, System.Span<System.Byte> materials)`
- `Sandbox.ModelBuilder AddTraceMesh(System.Collections.Generic.List<Vector3> vertices, System.Collections.Generic.List<System.Int32> indices)`
- `Sandbox.ModelBuilder AddTraceMesh(System.Span<Vector3> vertices, System.Span<System.Int32> indices)`
- `Sandbox.ModelBuilder AddMesh(Sandbox.Mesh mesh)`
  - Add a mesh.
- `Sandbox.ModelBuilder AddMeshes(Sandbox.Mesh[] meshes)`
  - Add a bunch of meshes.
- `Sandbox.ModelBuilder AddMesh(Sandbox.Mesh mesh, System.Int32 lod)`
  - Add a mesh to a Level of Detail (LOD) group.
- `Sandbox.ModelBuilder AddMeshes(Sandbox.Mesh[] meshes, System.Int32 lod)`
  - Add a bunch of meshes to a Level of Detail (LOD) group.
- `Sandbox.ModelBuilder AddMesh(Sandbox.Mesh mesh, System.String groupName, System.Int32 choiceIndex)`
  - Add a mesh to a body group choice.
- `Sandbox.ModelBuilder AddMesh(Sandbox.Mesh mesh, System.Int32 lod, System.String groupName, System.Int32 choiceIndex)`
  - Add a mesh to a Level of Detail (LOD) and a body group choice.
- `System.Void AddBone(Sandbox.ModelBuilder.Bone bone)`
  - Add a bone to the skeleton via a `Sandbox.ModelBuilder.Bone` struct.
- `System.Void AddBones(Sandbox.ModelBuilder.Bone[] bones)`
  - Add multiple bones to the skeleton.
- `Sandbox.ModelBuilder AddBone(System.String name, Vector3 position, Rotation rotation, System.String parentName)`
  - Add a bone to the skeleton.
- `Sandbox.ModelBuilder AddAttachment(System.String name, Vector3 position, Rotation rotation, System.String parentName)`
  - Add an attachment to the skeleton.
- `Sandbox.ModelBuilder WithName(System.String name)`
  - Provide a name to identify the model by
  - `name`: Desired model name
- `Sandbox.ModelBuilder AddSurface(Sandbox.Surface surface)`
- `Sandbox.Model Create()`
  - Finish creation of the model.
- `Sandbox.MaterialGroupBuilder AddMaterialGroup(System.String name)`
  - Add a named material group builder.
- `Sandbox.PhysicsBodyBuilder AddBody(System.Single mass, Sandbox.Surface surface, System.String boneName)`
  - Adds a new physics body to this object.
  - `mass`: The mass of the body. Default is `0`.
  - `surface`: The surface properties to apply. Default is `default`.
  - `boneName`: Optional name of the bone this body is attached to.  
Leave empty for non-skeletal bodies.
  - returns: A new `Sandbox.PhysicsBodyBuilder` for configuring the body.
- `Sandbox.HingeJointBuilder AddHingeJoint(System.Int32 body1, System.Int32 body2, System.Nullable<Transform> frame1, System.Nullable<Transform> frame2, System.Boolean collision)`
- `Sandbox.BallJointBuilder AddBallJoint(System.Int32 body1, System.Int32 body2, System.Nullable<Transform> frame1, System.Nullable<Transform> frame2, System.Boolean collision)`
- `Sandbox.FixedJointBuilder AddFixedJoint(System.Int32 body1, System.Int32 body2, System.Nullable<Transform> frame1, System.Nullable<Transform> frame2, System.Boolean collision)`
- `Sandbox.SliderJointBuilder AddSliderJoint(System.Int32 body1, System.Int32 body2, System.Nullable<Transform> frame1, System.Nullable<Transform> frame2, System.Boolean collision)`
