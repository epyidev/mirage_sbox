# Namespace `Sandbox.Physics`

13 types.

## Classes

- [`BallSocketJoint`](./BallSocketJoint.md) - A ballsocket constraint.
- [`CollisionRules`](./CollisionRules.md) - This is a JSON serializable description of the physics's collision rules. This allows us to send it
- [`ControlJoint`](./ControlJoint.md) - The control joint is designed to control the movement of a body while remaining responsive to collisions.  
- [`FixedJoint`](./FixedJoint.md) - A generic "rope" type constraint.
- [`HingeJoint`](./HingeJoint.md) - A hinge-like constraint.
- [`PhysicsJoint`](./PhysicsJoint.md) - A physics constraint.
- [`PhysicsPoint`](./PhysicsPoint.md) - Used to describe a point on a physics body. This is used for things like joints where
- [`PhysicsSettings`](./PhysicsSettings.md)
- [`PhysicsSpring`](./PhysicsSpring.md) - Spring related settings for joints such as `Sandbox.Physics.FixedJoint`.
- [`PulleyJoint`](./PulleyJoint.md) - A pulley constraint. Consists of 2 ropes which share same length, and the ratio changes via physics interactions.
- [`SliderJoint`](./SliderJoint.md) - A slider constraint, basically allows movement only on the arbitrary axis between the 2 constrained objects on creation.
- [`SpringJoint`](./SpringJoint.md) - A rope-like constraint that is has springy/bouncy.
- [`UprightJoint`](./UprightJoint.md) - A parallel joint that constrains the Z-axes of two bodies to be parallel using a spring.

## Structs

- [`PhysicsPoint`](./PhysicsPoint.md) - Used to describe a point on a physics body. This is used for things like joints where
- [`PhysicsSpring`](./PhysicsSpring.md) - Spring related settings for joints such as `Sandbox.Physics.FixedJoint`.
