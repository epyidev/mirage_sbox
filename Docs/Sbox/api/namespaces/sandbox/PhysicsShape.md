# Sandbox.PhysicsShape

Represents a basic, convex shape. A <see cref="T:Sandbox.PhysicsBody">PhysicsBody</see> consists of one or more of these.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `Sandbox.PhysicsBody Body`
  - The physics body we belong to.
- `Vector3 Scale`
- `Sandbox.Collider Collider`
  - The collider object that created / owns this shape
- `System.Boolean IsTrigger`
  - This is a trigger (!)
- `Vector3 SurfaceVelocity`
  - Set the local velocity of the surface so things can slide along it, like a conveyor belt
- `System.Boolean EnableSolidCollisions`
  - Controls whether this shape has solid collisions.
- `System.Boolean EnableTouch`
  - Controls whether this shape can fire touch events for its owning entity. (Entity.StartTouch, Touch and EndTouch)
- `System.Boolean EnableTouchPersists`
  - Controls whether this shape can fire continuous touch events for its owning entity (i.e. calling Entity.Touch every frame)
- `System.Boolean IsMeshShape`
  - Is this a MeshShape
- `System.Boolean IsHullShape`
  - Is this a HullShape
- `System.Boolean IsSphereShape`
  - Is this a SphereShape
- `System.Boolean IsCapsuleShape`
  - Is this a CapsuleShape
- `System.Boolean IsHeightfieldShape`
  - Is this a HeightfieldShape
- `Sandbox.Sphere Sphere`
  - Get sphere properties if we're a sphere type
- `Capsule Capsule`
  - Get capsule properties if we're a capsule type
- `System.String SurfaceMaterial`
  - Controls physical properties of this shape.
- `Sandbox.Surface Surface`
- `Sandbox.Surface[] Surfaces`
  - Multiple surfaces referenced by mesh or heightfield collision.
- `System.Single Friction`
  - The friction value
- `Sandbox.ITagSet Tags`

## Methods

### Instance methods

- `System.Void EnableAllCollision()`
  - Enable contact, trace and touch
- `System.Void DisableAllCollision()`
  - Disable contact, trace and touch
- `System.Void UpdateMesh(System.Collections.Generic.List<Vector3> vertices, System.Collections.Generic.List<System.Int32> indices)`
- `System.Void UpdateMesh(System.Span<Vector3> vertices, System.Span<System.Int32> indices)`
- `System.Void UpdateHull(Vector3 position, Rotation rotation, System.Span<Vector3> points)`
- `System.Void Remove()`
  - Remove this shape. After calling this the shape should be considered released and not used again.
- `System.Void Triangulate(Vector3[] positions, System.UInt32[] indices)`
  - Triangulate this shape.
- `System.Boolean HasTag(System.String tag)`
  - Does this shape have a specific tag?
- `System.Boolean AddTag(System.String tag)`
  - Add a tag to this shape.
- `System.Boolean RemoveTag(System.String tag)`
  - Remove a tag from this shape.
- `System.Boolean ClearTags()`
  - Clear all tags from this shape.
