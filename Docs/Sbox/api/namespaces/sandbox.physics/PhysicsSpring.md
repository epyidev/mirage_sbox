# Sandbox.Physics.PhysicsSpring

Spring related settings for joints such as `Sandbox.Physics.FixedJoint`.

- **Kind:** struct
- **Namespace:** `Sandbox.Physics`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `PhysicsSpring(System.Single frequency, System.Single damping, System.Single maximum)`

## Properties

- `System.Single Frequency`
  - The stiffness of the spring
- `System.Single Damping`
  - The damping ratio of the spring, usually between 0 and 1
- `System.Single Maximum`
  - For weld joints only, maximum force. Not for breaking.
