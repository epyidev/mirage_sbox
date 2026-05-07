# Sandbox.UprightJoint

Constrains a physics body to stay upright relative to another body or the world.
Uses a spring to keep the Z-axes of both bodies parallel.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Joint`

## Constructors

- `UprightJoint()`

## Properties

- `System.Single Hertz`
  - Spring stiffness in cycles per second (Hertz).
Higher values make the joint stiffer and snap back faster.
- `System.Single DampingRatio`
  - Spring damping ratio (non-dimensional). A value of 1 is critically damped;
values below 1 are springy, values above 1 are over-damped.
- `System.Single MaxTorque`
  - Maximum torque the joint can apply in newton-meters.
Set to 0 for unlimited torque.
