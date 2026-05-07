# Sandbox.BallJointBuilder

Provides ability to generate a ball joint for a `Sandbox.Model` at runtime.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.PhysicsJointBuilder`

## Properties

- `System.Boolean EnableSwingLimit`
  - Whether the joint enforces a swing angle limit.
- `System.Boolean EnableTwistLimit`
  - Whether the joint enforces a twist angle limit.
- `System.Single SwingLimit`
  - Maximum allowed swing angle in degrees.
- `Vector2 TwistLimit`
  - Minimum and maximum allowed twist angles in degrees.

## Methods

### Instance methods

- `Sandbox.BallJointBuilder WithSwingLimit(System.Single v)`
- `Sandbox.BallJointBuilder WithTwistLimit(System.Single min, System.Single max)`
