# Sandbox.HingeJointBuilder

Provides ability to generate a hinge joint for a `Sandbox.Model` at runtime.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.PhysicsJointBuilder`

## Properties

- `System.Boolean EnableTwistLimit`
  - Whether the hinge enforces a twist angle limit.
- `Vector2 TwistLimit`
  - The minimum and maximum allowed twist angles (degrees).
- `System.Boolean EnableMotor`
  - Whether the hinge's angular motor is enabled.
- `Vector3 TargetVelocity`
  - Target angular velocity for the motor.
- `System.Single MaxTorque`
  - Maximum torque the motor may apply.

## Methods

### Instance methods

- `Sandbox.HingeJointBuilder WithTwistLimit(System.Single min, System.Single max)`
- `Sandbox.HingeJointBuilder WithTargetVelocity(Vector3 v)`
- `Sandbox.HingeJointBuilder WithMaxTorque(System.Single v)`
