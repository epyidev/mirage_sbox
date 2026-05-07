# Sandbox.Movement.MoveModeSwim

The character is swimming

- **Kind:** class
- **Namespace:** `Sandbox.Movement`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Movement.MoveMode`

## Constructors

- `MoveModeSwim()`

## Properties

- `System.Int32 Priority`
- `System.Single SwimLevel`
- `System.Single WaterLevel`
  - We will update this based on how much you're in a "water" tagged trigger.

## Methods

### Instance methods

- `virtual System.Void UpdateRigidBody(Sandbox.Rigidbody body)`
- `virtual System.Int32 Score(Sandbox.PlayerController controller)`
- `virtual System.Void OnModeBegin()`
- `virtual System.Void OnModeEnd(Sandbox.Movement.MoveMode next)`
- `virtual System.Void OnFixedUpdate()`
- `virtual Vector3 UpdateMove(Rotation eyes, Vector3 input)`
