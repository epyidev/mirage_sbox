# Sandbox.WheelJoint

The wheel joint can be used to simulate wheels on vehicles.
The wheel joint restricts body B to move along a local axis in body A. Body B is free to rotate.
Supports a linear spring, linear limits, and a rotational motor.
The assumption is that you will create this joint on the wheel body.This will enable suspension to be in the correct direction.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Joint`

## Constructors

- `WheelJoint()`

## Properties

- `System.Boolean EnableSuspensionLimit`
- `Vector2 SuspensionLimits`
- `System.Boolean EnableSpinMotor`
- `System.Single MaxSpinTorque`
- `System.Single SpinMotorSpeed`
- `System.Boolean EnableSuspension`
- `System.Single SuspensionHertz`
- `System.Single SuspensionDampingRatio`
- `System.Boolean EnableSteering`
- `System.Single SteeringHertz`
- `System.Single SteeringDampingRatio`
- `System.Single TargetSteeringAngle`
- `System.Single MaxSteeringTorque`
- `System.Boolean EnableSteeringLimit`
- `Vector2 SteeringLimits`
- `System.Single SpinSpeed`
- `System.Single SpinTorque`
- `System.Single SteeringAngle`
- `System.Single SteeringTorque`
