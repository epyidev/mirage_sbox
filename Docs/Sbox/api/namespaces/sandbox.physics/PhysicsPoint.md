# Sandbox.Physics.PhysicsPoint

Used to describe a point on a physics body. This is used for things like joints where
you want to pass in just a body, or sometimes you want to pass in a body with a specific
location and rotation to attach to.

- **Kind:** struct
- **Namespace:** `Sandbox.Physics`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `PhysicsPoint(Sandbox.PhysicsBody body, System.Nullable<Vector3> localPosition, System.Nullable<Rotation> localRotation)`

## Properties

- `Transform LocalTransform`
  - A transform relative to `Sandbox.Physics.PhysicsPoint.Body`, containing `Sandbox.Physics.PhysicsPoint.LocalPosition` and `Sandbox.Physics.PhysicsPoint.LocalRotation` with scale of 1.
- `Transform Transform`
  - Transform of this point in world space.

## Fields

- `Sandbox.PhysicsBody Body`
  - The physics body this point is attached to.
- `Vector3 LocalPosition`
  - Position offset from the body's position.
- `Rotation LocalRotation`
  - Rotation offset from the body's position.

## Methods

### Static methods

- `static Sandbox.Physics.PhysicsPoint Local(Sandbox.PhysicsBody body, System.Nullable<Vector3> localPosition, System.Nullable<Rotation> localRotation)`
- `static Sandbox.Physics.PhysicsPoint World(Sandbox.PhysicsBody body, System.Nullable<Vector3> worldPosition, System.Nullable<Rotation> worldRotation)`
