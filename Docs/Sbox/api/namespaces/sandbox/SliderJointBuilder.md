# Sandbox.SliderJointBuilder

Provides ability to generate a slider joint for a `Sandbox.Model` at runtime.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.PhysicsJointBuilder`

## Properties

- `System.Boolean EnableLimit`
  - Whether the joint enforces a translation limit along its axis.
- `Vector2 Limit`
  - The minimum and maximum allowed translation along the joint axis.

## Methods

### Instance methods

- `Sandbox.SliderJointBuilder WithLimit(System.Single min, System.Single max)`
