# Sandbox.SceneTrace

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Fields

- `Sandbox.PhysicsTraceBuilder PhysicsTrace`

## Methods

### Instance methods

- `Sandbox.SceneTrace Sphere(System.Single radius, Vector3 from, Vector3 to)`
  - Casts a sphere from point A to point B.
- `Sandbox.SceneTrace Sphere(System.Single radius, Ray ray, System.Single distance)`
  - Casts a sphere from a given position and direction, up to a given distance.
- `Sandbox.SceneTrace Box(Vector3 extents, Vector3 from, Vector3 to)`
  - Casts a box from point A to point B.
- `Sandbox.SceneTrace Box(Vector3 extents, Ray ray, System.Single distance)`
  - Casts a box from a given position and direction, up to a given distance.
- `Sandbox.SceneTrace Box(BBox bbox, Vector3 from, Vector3 to)`
  - Casts a box from point A to point B.
- `Sandbox.SceneTrace Box(BBox bbox, Ray ray, System.Single distance)`
  - Casts a box from a given position and direction, up to a given distance.
- `Sandbox.SceneTrace Capsule(Capsule capsule)`
  - Casts a capsule
- `Sandbox.SceneTrace Capsule(Capsule capsule, Vector3 from, Vector3 to)`
  - Casts a capsule from point A to point B.
- `Sandbox.SceneTrace Capsule(Capsule capsule, Ray ray, System.Single distance)`
  - Casts a capsule from a given position and direction, up to a given distance.
- `Sandbox.SceneTrace Cylinder(System.Single height, System.Single radius)`
  - Casts a cylinder
- `Sandbox.SceneTrace Cylinder(System.Single height, System.Single radius, Vector3 from, Vector3 to)`
  - Casts a cylinder from point A to point B.
- `Sandbox.SceneTrace Cylinder(System.Single height, System.Single radius, Ray ray, System.Single distance)`
  - Casts a cylinder from a given position and direction, up to a given distance.
- `Sandbox.SceneTrace Ray(Vector3 from, Vector3 to)`
  - Casts a ray from point A to point B.
- `Sandbox.SceneTrace Ray(Ray ray, System.Single distance)`
  - Casts a ray from a given position and direction, up to a given distance.
- `Sandbox.SceneTrace Body(Sandbox.PhysicsBody body, Vector3 to)`
  - Casts a PhysicsBody from its current position and rotation to desired end point.
- `Sandbox.SceneTrace Body(Sandbox.Rigidbody body, Vector3 to)`
  - Casts a PhysicsBody from its current position and rotation to desired end point.
- `Sandbox.SceneTrace Body(Sandbox.PhysicsBody body, Transform from, Vector3 to)`
  - Casts a PhysicsBody from a position and rotation to desired end point.
- `Sandbox.SceneTrace Sweep(Sandbox.PhysicsBody body, Transform from, Transform to)`
  - Sweeps each <see cref="T:Sandbox.PhysicsShape">PhysicsShape</see> of given PhysicsBody and returns the closest collision. Does not support Mesh PhysicsShapes.
Basically 'hull traces' but with physics shapes.
Same as tracing a body but allows rotation to change during the sweep.
- `Sandbox.SceneTrace Sweep(Sandbox.Rigidbody body, Transform from, Transform to)`
  - Sweeps each <see cref="T:Sandbox.PhysicsShape">PhysicsShape</see> of given PhysicsBody and returns the closest collision. Does not support Mesh PhysicsShapes.
Basically 'hull traces' but with physics shapes.
Same as tracing a body but allows rotation to change during the sweep.
- `Sandbox.SceneTrace Sweep(Sandbox.PhysicsBody body, Transform to)`
  - Creates a Trace.Sweep using the <see cref="T:Sandbox.PhysicsBody">PhysicsBody</see>'s position as the starting position.
- `Sandbox.SceneTrace FromTo(Vector3 from, Vector3 to)`
  - Sets the start and end positions of the trace request
- `Sandbox.SceneTrace FromTo(Transform from, Vector3 to)`
  - Sets the start transform and end position of the trace request
- `Sandbox.SceneTrace Size(BBox hull)`
  - Makes this trace an axis aligned box of given size. Extracts mins and maxs from the Bounding Box.
- `Sandbox.SceneTrace Size(Vector3 size)`
  - Makes this trace an axis aligned box of given size. Calculates mins and maxs by assuming given size is (maxs-mins) and the center is in the middle.
- `Sandbox.SceneTrace Size(Vector3 mins, Vector3 maxs)`
  - Makes this trace an axis aligned box of given size.
- `Sandbox.SceneTrace Rotated(Rotation rotation)`
  - Makes this a rotated trace, for tracing rotated boxes and capsules.
- `Sandbox.SceneTrace Radius(System.Single radius)`
  - Makes this trace a sphere of given radius.
- `Sandbox.SceneTrace UseHitPosition(System.Boolean enabled)`
  - Should we compute hit position.
- `Sandbox.SceneTrace UseHitboxes(System.Boolean hit)`
  - Should we hit hitboxes
- `Sandbox.SceneTrace UseRenderMeshes(System.Boolean hit)`
  - Should we hit meshes too? This can be slow and only works for the editor.
- `Sandbox.SceneTrace UseRenderMeshes(System.Boolean hitFront, System.Boolean hitBack)`
  - Should we hit meshes too? This can be slow and only works for the editor.
- `Sandbox.SceneTrace UsePhysicsWorld(System.Boolean hit)`
  - Should we hit physics objects?
- `Sandbox.SceneTrace WithTag(System.String tag)`
  - Only return entities with this tag. Subsequent calls to this will add multiple requirements
and they'll all have to be met (ie, the entity will need all tags).
- `Sandbox.SceneTrace WithAllTags(System.String[] tags)`
  - Only return entities with all of these tags
- `Sandbox.SceneTrace WithAllTags(Sandbox.ITagSet tags)`
  - Only return entities with all of these tags
- `Sandbox.SceneTrace WithAnyTags(System.String[] tags)`
  - Only return entities with any of these tags
- `Sandbox.SceneTrace WithAnyTags(Sandbox.ITagSet tags)`
  - Only return entities with any of these tags
- `Sandbox.SceneTrace WithoutTags(System.String[] tags)`
  - Only return entities without any of these tags
- `Sandbox.SceneTrace WithoutTags(Sandbox.ITagSet tags)`
  - Only return entities without any of these tags
- `Sandbox.SceneTrace WithCollisionRules(System.String tag, System.Boolean asTrigger)`
  - Use the collision rules of an object with the given tags.
  - `tag`: Which tag this trace will adopt the collision rules of.
  - `asTrigger`: If true, trace against triggers only. Otherwise, trace for collisions (default).
- `Sandbox.SceneTrace WithCollisionRules(System.Collections.Generic.IEnumerable<System.String> tags, System.Boolean asTrigger)`
- `Sandbox.SceneTrace IgnoreGameObject(Sandbox.GameObject obj)`
  - Do not hit this object
- `Sandbox.SceneTrace IgnoreGameObjectHierarchy(Sandbox.GameObject obj)`
  - Do not hit this object
- `Sandbox.SceneTrace HitTriggers()`
  - Hit Triggers
- `Sandbox.SceneTrace HitTriggersOnly()`
  - Hit Only Triggers
- `Sandbox.SceneTrace IgnoreStatic()`
  - Do not hit static objects
- `Sandbox.SceneTrace IgnoreDynamic()`
  - Do not hit dynamic objects
- `Sandbox.SceneTrace IgnoreKeyframed()`
  - Do not hit keyframed objects
- `Sandbox.SceneTraceResult Run()`
  - Run the trace and return the result. The result will return the first hit.
- `System.Collections.Generic.IEnumerable<Sandbox.SceneTraceResult> RunAll()`
  - Run the trace and record everything we hit along the way. The result will be an array of hits.
