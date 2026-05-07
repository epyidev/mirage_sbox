# Sandbox.Collider

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `Collider()`

## Properties

- `System.Boolean Static`
- `System.Boolean IsConcave`
- `System.Boolean IsDynamic`
  - Return true if this collider is using dynamic physics.
Returns false if this is a keyframe body, or a static physics body.
- `System.Nullable<System.Single> Friction`
  - Allows overriding the friction for this collider. This value 
can exceed 1 to to give crazy grippy friction if you want it to, 
but the normal value is between 0 and 1.
- `System.Nullable<System.Single> Elasticity`
  - Allows overriding the elasticity for this collider.
Controls how bouncy this collider is.
- `System.Nullable<System.Single> RollingResistance`
  - Allows overriding the rolling resistance for this collider.
Controls how easily rolling shapes (sphere, capsule) roll on surfaces.
- `Sandbox.Surface Surface`
- `Vector3 SurfaceVelocity`
  - Set the local velocity of the surface so things can slide along it, like a conveyor belt
- `System.Boolean IsTrigger`
- `BBox LocalBounds`
  - Calculated local bounds of all physics shapes in this collider.
- `System.Action<Sandbox.Collider> OnTriggerEnter`
  - Called when a collider enters this trigger
- `System.Action<Sandbox.Collider> OnTriggerExit`
  - Called when a collider exits this trigger
- `System.Action<Sandbox.GameObject> OnObjectTriggerEnter`
  - Called when a gameobject enters this trigger
- `System.Action<Sandbox.GameObject> OnObjectTriggerExit`
  - Called when a gameobject exits this trigger
- `System.Collections.Generic.IEnumerable<Sandbox.Collider> Touching`
  - If we're a trigger, this will list all of the colliders that are touching us.
If we're not a trigger, this will list all of the triggers that we are touching.
- `Sandbox.ColliderFlags ColliderFlags`
  - Flags that modify the behavior of this collider
- `Sandbox.PhysicsBody KeyframeBody`
- `System.Collections.Generic.IReadOnlySet<Sandbox.Joint> Joints`
  - If we're a keyframe collider, this is the set of joints attached to us. If we're not then this won't ever
return anything.
- `Sandbox.Rigidbody Rigidbody`
  - If this collider is part of a Rigidbody then this will return the component
that it's attached to. If this is null it's usually a good indication that this
collider is either static, world geometry, or a keyframe.

## Fields

- `Sandbox.PhysicsBody _keyframeBody`

## Methods

### Instance methods

- `virtual System.Collections.Generic.IEnumerable<Sandbox.PhysicsShape> CreatePhysicsShapes(Sandbox.PhysicsBody targetBody)`
- `virtual System.Collections.Generic.IEnumerable<Sandbox.PhysicsShape> CreatePhysicsShapes(Sandbox.PhysicsBody targetBody, Transform local)`
  - Overridable in derived component to create shapes
- `virtual System.Void RebuildImmediately()`
- `System.Void ConfigureShapes()`
  - Apply any things that we an apply after they're created
- `System.Void OnPhysicsChanged()`
- `System.Void Rebuild()`
- `System.Void CalculateLocalBounds()`
- `Vector3 GetVelocityAtPoint(Vector3 worldPoint)`
  - Get the velocity of this collider at the specific point in world coordinates.
- `Vector3 FindClosestPoint(Vector3 worldPoint)`
  - Returns the closest point to the given one between all convex shapes of this body.
- `BBox GetWorldBounds()`
  - Get the world bounds of this object
