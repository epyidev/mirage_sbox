# Sandbox.CharacterController

Allows collision constrained movement without the need for a rigidbody. This is not affected by forces and will only move when you call the Move() method.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `CharacterController()`

## Properties

- `System.Single Radius`
- `System.Single Height`
- `System.Single StepHeight`
- `System.Single GroundAngle`
- `System.Single Acceleration`
- `System.Single Bounciness`
  - When jumping into walls, should we bounce off or just stop dead?
- `System.Boolean UseCollisionRules`
  - If enabled, determine what to collide with using current project's collision rules for the `Sandbox.GameObject.Tags`
of the containing `Sandbox.GameObject`.
- `Sandbox.TagSet IgnoreLayers`
- `BBox BoundingBox`
- `Vector3 Velocity`
- `System.Boolean IsOnGround`
- `Sandbox.GameObject GroundObject`
- `Sandbox.Collider GroundCollider`

## Methods

### Instance methods

- `virtual System.Void DrawGizmos()`
- `System.Void Accelerate(Vector3 vector)`
  - Add acceleration to the current velocity. 
No need to scale by time delta - it will be done inside.
- `System.Void ApplyFriction(System.Single frictionAmount, System.Single stopSpeed)`
  - Apply an amount of friction to the current velocity.
No need to scale by time delta - it will be done inside.
- `Sandbox.SceneTraceResult TraceDirection(Vector3 direction)`
  - Trace the controller's current position to the specified delta
- `System.Void Punch(Vector3 amount)`
  - Disconnect from ground and punch our velocity. This is useful if you want the player to jump or something.
- `System.Void Move()`
  - Move a character, with this velocity
- `System.Void MoveTo(Vector3 targetPosition, System.Boolean useStep)`
  - Move from our current position to this target position, but using tracing an sliding.
This is good for different control modes like ladders and stuff.
