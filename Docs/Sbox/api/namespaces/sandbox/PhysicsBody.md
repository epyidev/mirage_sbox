# Sandbox.PhysicsBody

Represents a physics object. An entity can have multiple physics objects. See <see cref="P:Sandbox.PhysicsBody.PhysicsGroup">PhysicsGroup</see>.
A physics objects consists of one or more <see cref="T:Sandbox.PhysicsShape">PhysicsShape</see>s.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `PhysicsBody(Sandbox.PhysicsWorld world)`

## Properties

- `Sandbox.GameObject GameObject`
  - The GameObject that created this body
- `Sandbox.Component Component`
  - The component that created this body
- `Vector3 Position`
  - Position of this body in world coordinates.
- `Sandbox.PhysicsWorld World`
  - The physics world this body belongs to.
- `Rotation Rotation`
  - Rotation of the physics body in world space.
- `System.Single Scale`
- `Vector3 Velocity`
  - Linear velocity of this body in world space.
- `Vector3 AngularVelocity`
  - Angular velocity of this body in world space.
- `Vector3 MassCenter`
  - Center of mass for this physics body in world space coordinates.
- `Vector3 LocalMassCenter`
  - Center of mass for this physics body relative to its <see cref="P:Sandbox.PhysicsBody.Position">origin</see>.
- `System.Boolean OverrideMassCenter`
  - Is this physics body mass calculated or set directly.
- `System.Single Mass`
  - Mass of this physics body.
- `System.Boolean GravityEnabled`
  - Whether gravity is enabled for this body or not.
- `System.Boolean EnableCollisionSounds`
  - Whether to play collision sounds
- `System.Single GravityScale`
  - Scale the gravity relative to `Sandbox.PhysicsWorld.Gravity`. 2 is double the gravity, etc.
- `System.Boolean UseController`
  - If true we'll create a controller for this physics body. This is useful
for keyframed physics objects that need to push things. The controller will
sweep as the entity moves, rather than teleporting the object.. which works better
when pushing dynamic objects etc.
- `System.Boolean EnableTouch`
  - Enables Touch callbacks on all <see cref="T:Sandbox.PhysicsShape">PhysicsShapes</see> of this body.
Returns true if ANY of the physics shapes have touch events enabled.
- `System.Boolean EnableTouchPersists`
  - Sets `Sandbox.PhysicsShape.EnableTouchPersists` on all shapes of this body.
<br /><br />
Returns true if ANY of the physics shapes have persistent touch events enabled.
- `System.Boolean EnableSolidCollisions`
  - Sets `Sandbox.PhysicsShape.EnableSolidCollisions` on all shapes of this body.
<br /><br />
Returns true if ANY of the physics shapes have solid collisions enabled.
- `Sandbox.PhysicsBodyType BodyType`
  - Movement type of physics body, either Static, Keyframed, Dynamic
Note: If this body is networked and dynamic, it will return Keyframed on the client
- `System.Boolean AutoSleep`
  - Whether this body is allowed to automatically go into "sleep" after a certain amount of time of inactivity.
`Sandbox.PhysicsBody.Sleeping` for more info on the sleep mechanic.
- `Transform Transform`
  - Transform of this physics body.
- `System.Int32 ShapeCount`
  - How many shapes belong to this body.
- `System.Collections.Generic.IEnumerable<Sandbox.PhysicsShape> Shapes`
  - All shapes that belong to this body.
- `System.Boolean Enabled`
  - Whether this body is enabled or not. Disables collisions, physics simulation, touch events, trace queries, etc.
- `System.Boolean MotionEnabled`
  - Controls physics simulation on this body.
- `System.Boolean Sleeping`
  - Physics bodies automatically go to sleep after a certain amount of time of inactivity to save on performance.
You can use this to wake the body up, or prematurely send it to sleep.
- `System.Boolean SpeculativeContactEnabled`
  - If enabled, this physics body will move slightly ahead each frame based on its velocities.
- `Sandbox.PhysicsBody Parent`
  - The physics body we are attached to, if any
- `Sandbox.PhysicsBody SelfOrParent`
  - A convenience property, returns <see cref="P:Sandbox.PhysicsBody.Parent">Parent</see>, or if there is no parent, returns itself.
- `Sandbox.PhysicsGroup PhysicsGroup`
  - The physics group we belong to.
- `System.Single LinearDamping`
  - Generic linear damping, i.e. how much the physics body will slow down on its own.
- `System.Single AngularDamping`
  - Generic angular damping, i.e. how much the physics body will slow down on its own.
- `System.Single LinearDrag`
- `System.Single AngularDrag`
- `System.Boolean DragEnabled`
- `Vector3 Inertia`
  - The diagonal elements of the local inertia tensor matrix.
- `Rotation InertiaRotation`
  - The orientation of the principal axes of local inertia tensor matrix.
- `System.Single Density`
  - Returns average of densities for all physics shapes of this body. This is based on `Sandbox.PhysicsShape.SurfaceMaterial` of each shape.
- `Sandbox.RealTimeSince LastWaterEffect`
  - Time since last water splash effect. Used internally.
- `System.String SurfaceMaterial`
  - Sets `Sandbox.PhysicsShape.SurfaceMaterial` on all child <see cref="T:Sandbox.PhysicsShape">PhysicsShape</see>s.
- `Sandbox.Surface Surface`
- `System.String GroupName`
  - What is this body called in the group?
- `System.Int32 GroupIndex`
  - Return the index of this body in its PhysicsGroup
- `System.Action<Sandbox.PhysicsIntersection> OnIntersectionStart`
- `System.Action<Sandbox.PhysicsIntersection> OnIntersectionUpdate`
- `System.Action<Sandbox.PhysicsIntersectionEnd> OnIntersectionEnd`
- `System.Boolean EnhancedCcd`
  - Enable enhanced continuous collision detection (CCD) for this body.
When enabled, the body performs CCD against dynamic bodies
(but not against other bodies with enhanced CCD enabled).
This is useful for fast-moving objects like bullets or rockets
that need reliable collision detection.
- `Sandbox.PhysicsLock Locking`

## Methods

### Instance methods

- `System.Void SetComponentSource(Sandbox.Component c)`
- `Sandbox.GameObject GetGameObject()`
- `System.Void Move(Transform tx, System.Single delta)`
  - Move to a new position. Unlike Transform, if you have `UseController` enabled, this will sweep the shadow
to the new position, rather than teleporting there.
- `Sandbox.PhysicsShape AddSphereShape(Vector3 center, System.Single radius, System.Boolean rebuildMass)`
  - Add a sphere shape to this body.
  - `center`: Center of the sphere, relative to `Sandbox.PhysicsBody.Position` of this body.
  - `radius`: Radius of the sphere.
  - `rebuildMass`: Whether the mass should be <see cref="M:Sandbox.PhysicsBody.RebuildMass">recalculated</see> after adding the shape.
  - returns: The newly created shape, if any.
- `Sandbox.PhysicsShape AddSphereShape(Sandbox.Sphere sphere, System.Boolean rebuildMass)`
  - Add a sphere shape to this body.
- `Sandbox.PhysicsShape AddCapsuleShape(Vector3 center, Vector3 center2, System.Single radius, System.Boolean rebuildMass)`
  - Add a capsule shape to this body.
  - `center`: Point A of the capsule, relative to `Sandbox.PhysicsBody.Position` of this body.
  - `center2`: Point B of the capsule, relative to `Sandbox.PhysicsBody.Position` of this body.
  - `radius`: Radius of the capsule end caps.
  - `rebuildMass`: Whether the mass should be <see cref="M:Sandbox.PhysicsBody.RebuildMass">recalculated</see> after adding the shape.
  - returns: The newly created shape, or null on failure.
- `Sandbox.PhysicsShape AddBoxShape(Vector3 position, Rotation rotation, Vector3 extent, System.Boolean rebuildMass)`
  - Add a box shape to this body.
  - `position`: Center of the box, relative to `Sandbox.PhysicsBody.Position` of this body.
  - `rotation`: Rotation of the box, relative to `Sandbox.PhysicsBody.Rotation` of this body.
  - `extent`: The extents of the box. The box will extend from its center by this much in both negative and positive directions of each axis.
  - `rebuildMass`: Whether the mass should be <see cref="M:Sandbox.PhysicsBody.RebuildMass">recalculated</see> after adding the shape.
  - returns: The newly created shape, or null on failure.
- `Sandbox.PhysicsShape AddBoxShape(BBox box, Rotation rotation, System.Boolean rebuildMass)`
  - Add a box shape to this body.
- `Sandbox.PhysicsShape AddHullShape(Vector3 position, Rotation rotation, System.Collections.Generic.List<Vector3> points, System.Boolean rebuildMass)`
- `Sandbox.PhysicsShape AddHullShape(Vector3 position, Rotation rotation, System.Span<Vector3> points, System.Boolean rebuildMass)`
- `Sandbox.PhysicsShape AddCylinderShape(Vector3 position, Rotation rotation, System.Single height, System.Single radius, System.Int32 slices)`
  - Add a cylinder shape to this body.
- `Sandbox.PhysicsShape AddConeShape(Vector3 position, Rotation rotation, System.Single height, System.Single radius1, System.Single radius2, System.Int32 slices)`
  - Add a cone shape to this body.
- `Sandbox.PhysicsShape AddConeShape(Vector3 a, Vector3 b, System.Single radiusA, System.Single radiusB, System.Int32 slices)`
  - Add a cone shape to this body.
- `Sandbox.PhysicsShape AddMeshShape(System.Collections.Generic.List<Vector3> vertices, System.Collections.Generic.List<System.Int32> indices)`
- `Sandbox.PhysicsShape AddMeshShape(System.Span<Vector3> vertices, System.Span<System.Int32> indices)`
- `Sandbox.PhysicsShape AddHeightFieldShape(System.UInt16[] heights, System.Byte[] materials, System.Int32 sizeX, System.Int32 sizeY, System.Single sizeScale, System.Single heightScale)`
- `Sandbox.PhysicsShape AddCloneShape(Sandbox.PhysicsShape shape)`
- `System.Void ClearShapes()`
  - Remove all physics shapes, but not the physics body itself.
- `System.Void RebuildMass()`
  - Meant to be only used on <b>dynamic</b> bodies, rebuilds mass from all shapes of this body based on their volume and <see cref="P:Sandbox.PhysicsBody.Surface">physics properties</see>, for cases where they may have changed.
- `System.Void Remove()`
  - Completely removes this physics body.
- `System.Void ApplyImpulse(Vector3 impulse)`
  - Applies instant linear impulse (i.e. a bullet impact) to this body at its center of mass.
For continuous force (i.e. a moving car), use `Sandbox.PhysicsBody.ApplyForce(Vector3)`
- `System.Void ApplyImpulseAt(Vector3 position, Vector3 velocity)`
  - Applies instant linear impulse (i.e. a bullet impact) to this body at given position.
For continuous force (i.e. a moving car), use `Sandbox.PhysicsBody.ApplyForceAt(Vector3,Vector3)`
- `System.Void ApplyAngularImpulse(Vector3 impulse)`
  - Applies instant angular impulse (i.e. a bullet impact) to this body.
For continuous force (i.e. a moving car), use `Sandbox.PhysicsBody.ApplyTorque(Vector3)`
- `System.Void ApplyForce(Vector3 force)`
  - Applies force to this body at the center of mass.
This force will only be applied on the next physics frame and is scaled with physics timestep.
- `System.Void ApplyForceAt(Vector3 position, Vector3 force)`
  - Applies force to this body at given position.
This force will only be applied on the next physics frame and is scaled with physics timestep.
- `System.Void ApplyTorque(Vector3 force)`
  - Applies angular velocity to this body.
This force will only be applied on the next physics frame and is scaled with physics timestep.
- `System.Void ClearForces()`
  - Clear accumulated linear forces (`Sandbox.PhysicsBody.ApplyForce(Vector3)` and `Sandbox.PhysicsBody.ApplyForceAt(Vector3,Vector3)`) during this physics frame that were not yet applied to the physics body.
- `System.Void ClearTorque()`
  - Clear accumulated torque (angular force, `Sandbox.PhysicsBody.ApplyTorque(Vector3)`) during this physics frame that were not yet applied to the physics body.
- `Vector3 GetVelocityAtPoint(Vector3 point)`
  - Returns the world space velocity of a point of the object. This is useful for objects rotating around their own axis/origin.
  - `point`: The point to test, in world coordinates.
  - returns: Velocity at the given point.
- `Vector3 FindClosestPoint(Vector3 vec)`
  - Returns the closest point to the given one between all shapes of this body.
  - `vec`: Input position.
  - returns: The closest possible position on the surface of the physics body to the given position.
- `System.Void SetInertiaTensor(Vector3 inertia, Rotation rotation)`
  - Sets the inertia tensor using the given moments and rotation.
  - `inertia`: Principal moments (Ixx, Iyy, Izz).
  - `rotation`: Rotation of the principal axes.
- `System.Void ResetInertiaTensor()`
  - Resets the inertia tensor to its calculated values.
- `BBox GetBounds()`
  - Returns Axis-Aligned Bounding Box (AABB) of this physics body.
- `Sandbox.Physics.PhysicsPoint LocalPoint(Vector3 p)`
  - Convenience function that returns a `Sandbox.Physics.PhysicsPoint` from a position relative to this body.
- `Sandbox.Physics.PhysicsPoint WorldPoint(Vector3 p)`
  - Convenience function that returns a `Sandbox.Physics.PhysicsPoint` for this body from a world space position.
- `Sandbox.Physics.PhysicsPoint MassCenterPoint()`
  - Returns a `Sandbox.Physics.PhysicsPoint` at the center of mass of this body.
- `System.Boolean CheckOverlap(Sandbox.PhysicsBody body)`
  - Checks if another body overlaps us, ignoring all collision rules
- `System.Boolean CheckOverlap(Sandbox.PhysicsBody body, Transform transform)`
  - Checks if another body overlaps us at a given transform, ignoring all collision rules
- `Sandbox.PhysicsShape AddShape(Sandbox.PhysicsGroupDescription.BodyPart.HullPart part, Transform transform, System.Boolean rebuildMass)`
  - Add a shape from a physics hull
- `Sandbox.PhysicsShape AddShape(Sandbox.PhysicsGroupDescription.BodyPart.MeshPart part, Transform transform, System.Boolean convertToHull, System.Boolean rebuildMass)`
  - Add a shape from a mesh hull
- `Transform GetLerpedTransform(System.Double time)`
  - When the physics world is run at a fixed timestep, getting the positions of bodies will not be smooth.
You can use this function to get the lerped position between steps, to make things super awesome.
- `System.Void SmoothMove(Vector3 position, System.Single timeToArrive, System.Single timeDelta)`
  - Move body to this position in a way that cooperates with the physics system. This is quite
good for things like grabbing and moving objects.
- `System.Void SmoothMove(Transform transform, System.Single smoothTime, System.Single timeDelta)`
  - Move body to this position in a way that cooperates with the physics system. This is quite
good for things like grabbing and moving objects.
- `System.Void SmoothRotate(Rotation rotation, System.Single smoothTime, System.Single timeDelta)`
  - Rotate the body to this position in a way that cooperates with the physics system.
