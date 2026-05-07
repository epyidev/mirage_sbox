# Sandbox.Physics.PhysicsJoint

A physics constraint.

- **Kind:** class
- **Namespace:** `Sandbox.Physics`
- **Assembly:** `Sandbox.Engine`

## Properties

- `Sandbox.PhysicsWorld World`
  - The `Sandbox.PhysicsWorld` this joint belongs to.
- `Sandbox.PhysicsBody Body1`
  - The source physics body this joint is attached to.
- `Sandbox.PhysicsBody Body2`
  - The target physics body this joint is constraining.
- `Sandbox.Physics.PhysicsPoint Point1`
  - A specific point this joint is attached at on `Sandbox.Physics.PhysicsJoint.Body1`
- `Sandbox.Physics.PhysicsPoint Point2`
  - A specific point this joint is attached at on `Sandbox.Physics.PhysicsJoint.Body2`
- `System.Boolean IsActive`
- `System.Boolean Collisions`
  - Enables or disables collisions between the 2 constrained physics bodies.
- `System.Single Strength`
  - Strength of the linear constraint. If it takes any more energy than this, it'll break.
- `System.Single AngularStrength`
  - Strength of the angular constraint. If it takes any more energy than this, it'll break.

## Methods

### Static methods

- `static Sandbox.Physics.FixedJoint CreateFixed(Sandbox.Physics.PhysicsPoint a, Sandbox.Physics.PhysicsPoint b)`
  - Creates an almost solid constraint between two physics bodies.
- `static Sandbox.Physics.SpringJoint CreateLength(Sandbox.Physics.PhysicsPoint a, Sandbox.Physics.PhysicsPoint b, System.Single maxLength)`
  - Creates a constraint like a rope, where it has no minimum length but its max length is restrained.
- `static Sandbox.Physics.SpringJoint CreateSpring(Sandbox.Physics.PhysicsPoint a, Sandbox.Physics.PhysicsPoint b, System.Single minLength, System.Single maxLength)`
  - Creates a constraint that will try to stay the same length, like a spring, or a rod.
- `static Sandbox.Physics.HingeJoint CreateHinge(Sandbox.Physics.PhysicsPoint a, Sandbox.Physics.PhysicsPoint b)`
- `static Sandbox.Physics.HingeJoint CreateHinge(Sandbox.PhysicsBody body1, Sandbox.PhysicsBody body2, Transform localFrame1, Transform localFrame2)`
- `static Sandbox.Physics.SliderJoint CreateSlider(Sandbox.Physics.PhysicsPoint a, Sandbox.Physics.PhysicsPoint b, System.Single minLength, System.Single maxLength)`
  - Creates a slider constraint between two physics bodies via `Sandbox.Physics.PhysicsPoint`s.
- `static Sandbox.Physics.BallSocketJoint CreateBallSocket(Sandbox.PhysicsBody body1, Sandbox.PhysicsBody body2, Vector3 origin)`
  - Creates a ball socket constraint.
  - `body1`: The source physics body.
  - `body2`: The target physics body to constrain to.
  - `origin`: The origin of the hinge in world coordinates. The 2 bodies will rotate around this point.
  - returns: The created ball socket joint.
- `static Sandbox.Physics.BallSocketJoint CreateBallSocket(Sandbox.Physics.PhysicsPoint a, Sandbox.Physics.PhysicsPoint b)`
  - Creates a ball socket constraint.
  - `a`: The source physics body.
  - `b`: The target physics body to constrain to.
  - returns: The created ball socket joint.
- `static Sandbox.Physics.ControlJoint CreateControl(Sandbox.Physics.PhysicsPoint a, Sandbox.Physics.PhysicsPoint b)`
- `static Sandbox.Physics.UprightJoint CreateUpright(Sandbox.Physics.PhysicsPoint a, Sandbox.Physics.PhysicsPoint b)`
- `static Sandbox.Physics.HingeJoint CreateHinge(Sandbox.PhysicsBody body1, Sandbox.PhysicsBody body2, Vector3 center, Vector3 axis)`
- `static Sandbox.Physics.SliderJoint CreateSlider(Sandbox.PhysicsBody body1, Sandbox.PhysicsBody body2, Vector3 origin1, Vector3 origin2, Vector3 axis, System.Single minLength, System.Single maxLength)`
- `static Sandbox.Physics.PulleyJoint CreatePulley(Sandbox.PhysicsBody body1, Sandbox.PhysicsBody body2, Vector3 anchor1, Vector3 ground1, Vector3 anchor2, Vector3 ground2)`

### Instance methods

- `System.Void Remove()`
  - Removes this joint.
