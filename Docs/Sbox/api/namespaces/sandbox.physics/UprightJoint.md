# Sandbox.Physics.UprightJoint

A parallel joint that constrains the Z-axes of two bodies to be parallel using a spring.
Useful for keeping a physics body upright relative to another body or a static anchor.

- **Kind:** class
- **Namespace:** `Sandbox.Physics`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Physics.PhysicsJoint`

## Properties

- `System.Single Hertz`
  - The spring stiffness in cycles per second (Hertz).
Higher values make the constraint stiffer.
- `System.Single DampingRatio`
  - The spring damping ratio (non-dimensional).
A value of 1 is critically damped; values below 1 are under-damped (springy).
- `System.Single MaxTorque`
  - The maximum torque the joint can apply.
