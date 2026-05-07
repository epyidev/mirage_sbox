# Sandbox.BallJoint

Fix two objects together but can rotate - like a shoulder.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Joint`

## Constructors

- `BallJoint()`

## Properties

- `Sandbox.BallJoint.MotorMode Motor`
  - Motor mode
- `System.Boolean SwingLimitEnabled`
  - Enables or disables the swing limit.
- `Vector2 SwingLimit`
  - The minimum and maximum swing angles allowed by the joint in degrees.
- `System.Boolean TwistLimitEnabled`
  - Enables or disables the twist limit.
- `Vector2 TwistLimit`
  - The minimum and maximum twist angles allowed by the joint in degrees.
- `System.Single Friction`
  - Joint friction.
- `Rotation TargetRotation`
  - Target angle of motor.
- `System.Single Frequency`
  - Frequency of motor.
- `System.Single DampingRatio`
  - Damping of motor.
- `Vector3 TargetVelocity`
  - Target angular velocity of the motor.
- `System.Single MaxTorque`
  - Maximum torque the motor can apply when in velocity mode.
