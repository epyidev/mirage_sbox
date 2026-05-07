# Sandbox.Rigidbody

Adds physics properties to an object. Requires a collider to be attached to the same object.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `Rigidbody()`

## Properties

- `System.Boolean Gravity`
  - Is gravity enabled or not.
- `System.Single GravityScale`
  - Scale the gravity relative to `Sandbox.PhysicsWorld.Gravity`. 2 is double the gravity, etc.
- `System.Single LinearDamping`
- `System.Single AngularDamping`
- `System.Single MassOverride`
  - Override mass for this body, only when value is more than zero
- `System.Single Mass`
- `System.Boolean OverrideMassCenter`
- `Vector3 MassCenterOverride`
- `Vector3 MassCenter`
  - Center of mass for this rigidbody in local space coordinates.
- `Sandbox.PhysicsLock Locking`
- `System.Boolean StartAsleep`
- `Sandbox.RigidbodyFlags RigidbodyFlags`
- `System.Boolean EnableImpactDamage`
  - Whether this rigidbody can deal damage to damageable objects on high-speed impacts.
- `System.Single MinImpactDamageSpeed`
  - The minimum speed required for an impact to cause damage.
- `System.Single ImpactDamage`
  - The amount of damage this rigidbody deals to other objects when it collides at high speed.
If set to 0 or less, this will be calculated from the mass of the rigidbody.
- `Vector3 Velocity`
- `Vector3 AngularVelocity`
- `System.Boolean MotionEnabled`
- `System.Boolean CollisionEventsEnabled`
  - Enable or disable touch events. If you disable the events then ICollisionListener won't get any touch events
and you won't get things like collision sounds.
- `System.Boolean CollisionUpdateEventsEnabled`
  - Like CollisionEventsEnabled but means the OnCollisionUpdate gets called when the collision persists
- `System.Boolean Sleeping`
- `Vector3 InertiaTensor`
  - Gets or sets the inertia tensor for this body.
By default, the inertia tensor is automatically calculated from the shapes attached to the body.
Setting this property overrides the automatically calculated inertia tensor until `Sandbox.Rigidbody.ResetInertiaTensor` is called.
- `Rotation InertiaTensorRotation`
  - Gets or sets the rotation applied to the inertia tensor.
Like `Sandbox.Rigidbody.InertiaTensor`, this acts as an override to the automatically calculated inertia tensor rotation
and remains in effect until `Sandbox.Rigidbody.ResetInertiaTensor` is called.
- `System.Boolean EnhancedCcd`
  - Enable enhanced continuous collision detection (CCD) for this body.
When enabled, the body performs CCD against dynamic bodies
(but not against other bodies with enhanced CCD enabled).
This is useful for fast-moving objects like bullets or rockets
that need reliable collision detection.
- `Sandbox.PhysicsBody PhysicsBody`
  - Get the actual physics body that was created by this component. You should be careful, this
can of course be null when the object is not enabled or the physics world is not available.
It might also get deleted and re-created, so best use this to access, but don't store it.
- `System.Collections.Generic.IEnumerable<Sandbox.Collider> Touching`
  - This is a list of all of the triggers that we are touching.
- `System.Collections.Generic.IReadOnlySet<Sandbox.Joint> Joints`
  - A list of joints that we're connected to, if any.

## Methods

### Instance methods

- `System.Void ApplyBuoyancy(Sandbox.Plane plane, System.Single dt)`
  - Applies buoyancy and drag to the rigidbody relative to a plane to simulate things floating in water.
- `System.Void ResetInertiaTensor()`
  - Resets the inertia tensor and its rotation to the values automatically calculated from the attached colliders.
This removes any custom overrides set via `Sandbox.Rigidbody.InertiaTensor` or `Sandbox.Rigidbody.InertiaTensorRotation`.
- `Vector3 FindClosestPoint(Vector3 position)`
  - Returns the closest point to the given one between all convex shapes of this body.
- `Vector3 GetVelocityAtPoint(Vector3 position)`
  - Returns the world space velocity of a point of the object. This is useful for objects rotating around their own axis/origin.
- `System.Void ApplyForceAt(Vector3 position, Vector3 force)`
  - Applies force to this body at given position.
- `System.Void ApplyForce(Vector3 force)`
  - Applies linear force to this body
- `System.Void ApplyTorque(Vector3 force)`
  - Applies angular velocity to this body.
- `System.Void ApplyImpulseAt(Vector3 position, Vector3 force)`
  - Applies instant linear impulse (i.e. a bullet impact) to this body at given position
- `System.Void ApplyImpulse(Vector3 force)`
  - Applies instant linear impulse (i.e. a bullet impact) to this body
- `System.Void ClearForces()`
  - Clear accumulated linear forces (`Sandbox.Rigidbody.ApplyForce(Vector3@)` and `Sandbox.Rigidbody.ApplyForceAt(Vector3@,Vector3@)`) during this physics frame that were not yet applied to the physics body.
- `System.Void SmoothMove(Transform transform, System.Single timeToArrive, System.Single timeDelta)`
  - Move body to this position in a way that cooperates with the physics system. This is quite
good for things like grabbing and moving objects.
- `System.Void SmoothMove(Vector3 position, System.Single timeToArrive, System.Single timeDelta)`
  - Move body to this position in a way that cooperates with the physics system. This is quite
good for things like grabbing and moving objects.
- `System.Void SmoothRotate(Rotation rotation, System.Single timeToArrive, System.Single timeDelta)`
  - Rotate the body to this position in a way that cooperates with the physics system.
- `BBox GetWorldBounds()`
  - Get the world bounds of this object
