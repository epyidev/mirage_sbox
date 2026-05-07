# Sandbox.Movement.MoveModeLadder

The character is climbing up a ladder

- **Kind:** class
- **Namespace:** `Sandbox.Movement`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Movement.MoveMode`

## Constructors

- `MoveModeLadder()`

## Properties

- `System.Int32 Priority`
- `System.Single Speed`
- `Sandbox.TagSet ClimbableTags`
  - A list of tags we can climb up - when they're on triggers
- `Sandbox.GameObject ClimbingObject`
  - The GameObject we're climbing. This will usually be a ladder trigger.
- `Rotation ClimbingRotation`
  - When climbing, this is the rotation of the wall/ladder you're climbing, where
Forward is the direction to look at the ladder, and Up is the direction to climb.

## Methods

### Instance methods

- `virtual System.Void UpdateRigidBody(Sandbox.Rigidbody body)`
- `virtual System.Int32 Score(Sandbox.PlayerController controller)`
- `virtual System.Void OnModeBegin()`
- `virtual System.Void OnModeEnd(Sandbox.Movement.MoveMode next)`
- `virtual System.Void PostPhysicsStep()`
- `virtual System.Void OnFixedUpdate()`
- `virtual Vector3 UpdateMove(Rotation eyes, Vector3 input)`
- `virtual System.Void OnRotateRenderBody(Sandbox.SkinnedModelRenderer renderer)`
