# Sandbox.Physics.ControlJoint

The control joint is designed to control the movement of a body while remaining responsive to collisions.  
A spring can be used to control position and rotation, while a velocity motor can control velocity and  
simulate friction in top-down games. Both methods can be combined — for example, a spring with friction.  
Position and velocity control each have configurable force and torque limits.

- **Kind:** class
- **Namespace:** `Sandbox.Physics`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Physics.PhysicsJoint`

## Properties

- `Vector3 LinearVelocity`
  - The desired relative linear velocity.
- `Vector3 AngularVelocity`
  - The desired relative angular velocity in radians per second.
- `System.Single MaxVelocityForce`
  - The joint maximum force.
- `System.Single MaxVelocityTorque`
  - The joint maximum torque.
- `Sandbox.Physics.PhysicsSpring LinearSpring`
  - The spring linear hertz stiffness and damping ratio.
- `Sandbox.Physics.PhysicsSpring AngularSpring`
  - The spring angular hertz stiffness and damping ratio.
