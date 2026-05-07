# Sandbox.PhysicsGroup

Represents a set of <see cref="T:Sandbox.PhysicsBody">PhysicsBody</see> objects. Think ragdoll.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `Sandbox.PhysicsWorld World`
  - The world in which this group belongs
- `Vector3 Pos`
  - Returns position of the first physics body of this group, or zero vector if it has none.
- `Vector3 MassCenter`
  - Returns the center of mass for this group of physics bodies.
- `Vector3 Velocity`
  - Sets `Sandbox.PhysicsBody.Velocity` on all bodies of this group.
- `Vector3 AngularVelocity`
  - Sets `Sandbox.PhysicsBody.AngularVelocity` on all bodies of this group.
- `System.Boolean Sleeping`
  - Physics bodies automatically go to sleep after a certain amount of time of inactivity to save on performance.
You can use this to wake the body up, or prematurely send it to sleep.
- `System.Single Mass`
  - The total mass of all the <b>dynamic</b><see cref="T:Sandbox.PhysicsBody">PhysicsBodies</see> in this group.
When setting the total mass, it will be set on each body proportionally to each of their old masses,
i.e. if a body had 25% of previous total mass, it will have 25% of new total mass.
- `System.Single LinearDamping`
  - Sets `Sandbox.PhysicsBody.LinearDamping` on all bodies in this group.
- `System.Single AngularDamping`
  - Sets `Sandbox.PhysicsBody.AngularDamping` on all bodies in this group.
- `System.Collections.Generic.IEnumerable<Sandbox.PhysicsBody> Bodies`
  - Returns all physics bodies that belong to this physics group.
- `System.Int32 BodyCount`
  - Returns amount of physics bodies that belong to this physics group.
- `System.Collections.Generic.IEnumerable<Sandbox.Physics.PhysicsJoint> Joints`
  - Any and all joints that are attached to any body in this group.

## Methods

### Instance methods

- `System.Void AddVelocity(Vector3 vel)`
  - Adds given amount of velocity (`Sandbox.PhysicsBody.ApplyForce(Vector3)`) to all physics bodies in this group.
  - `vel`: How much linear force to add?
- `System.Void AddAngularVelocity(Vector3 vel)`
  - Adds given amount of angular velocity to all physics bodies in this group.
  - `vel`: How much angular force to add?
- `System.Void ApplyImpulse(Vector3 vel, System.Boolean withMass)`
  - Adds given amount of linear impulse (`Sandbox.PhysicsBody.ApplyImpulse(Vector3)`) to all physics bodies in this group.
  - `vel`: Velocity to apply.
  - `withMass`: Whether to multiply the velocity by mass of the `Sandbox.PhysicsBody` on a per-body basis.
- `System.Void ApplyAngularImpulse(Vector3 vel, System.Boolean withMass)`
  - Adds given amount of angular linear impulse (`Sandbox.PhysicsBody.ApplyAngularImpulse(Vector3)`) to all physics bodies in this group.
  - `vel`: Angular velocity to apply.
  - `withMass`: Whether to multiply the velocity by mass of the `Sandbox.PhysicsBody` on a per-body basis.
- `System.Void RebuildMass()`
  - Calls `Sandbox.PhysicsBody.RebuildMass` on all bodies of this group.
- `Sandbox.PhysicsBody GetBody(System.Int32 groupIndex)`
  - Gets a `Sandbox.PhysicsBody` at given index within this physics group. See `Sandbox.PhysicsGroup.BodyCount`.
  - `groupIndex`: Index for the body to look up, in range from 0 to `Sandbox.PhysicsGroup.BodyCount`.
- `Sandbox.PhysicsBody GetBody(System.String groupName)`
  - Returns a `Sandbox.PhysicsBody` by its `Sandbox.PhysicsBody.GroupName` within this group.
  - `groupName`: Name of the physics body to look up.
  - returns: The physics body, or null if body with given name is not found.
- `System.Void SetSurface(System.String name)`
  - Sets the physical properties of each <see cref="T:Sandbox.PhysicsShape">PhysicsShape</see> of this group.
- `System.Void Remove()`
  - Delete this group, and all of its bodies
