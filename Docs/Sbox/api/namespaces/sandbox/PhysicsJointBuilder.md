# Sandbox.PhysicsJointBuilder

Provides ability to generate a physics joint for a `Sandbox.Model` at runtime.

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `PhysicsJointBuilder()`

## Properties

- `System.Int32 Body1`
  - The index of the first body connected by the joint.
- `System.Int32 Body2`
  - The index of the second body connected by the joint.
- `Transform Frame1`
  - The joint frame in the local space of `Sandbox.PhysicsJointBuilder.Body1`.
- `Transform Frame2`
  - The joint frame in the local space of `Sandbox.PhysicsJointBuilder.Body2`.
- `System.Boolean EnableCollision`
  - Whether the connected bodies can collide with each other.
- `System.Single LinearStrength`
  - The maximum linear force the joint can withstand before breaking.
- `System.Single AngularStrength`
  - The maximum angular force/torque the joint can withstand before breaking.
