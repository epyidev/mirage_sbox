# Sandbox.FixedJointBuilder

Provides ability to generate a fixed joint for a `Sandbox.Model` at runtime.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.PhysicsJointBuilder`

## Properties

- `System.Single LinearFrequency`
  - The frequency of the joint's linear spring in hertz.
Higher values make the joint stiffer in translation.
- `System.Single LinearDamping`
  - The damping ratio for the joint's linear spring.
Higher values reduce oscillation in translation.
- `System.Single AngularFrequency`
  - The frequency of the joint's angular spring in hertz.
Higher values make the joint stiffer in rotation.
- `System.Single AngularDamping`
  - The damping ratio for the joint's angular spring.
Higher values reduce oscillation in rotation.

## Methods

### Instance methods

- `Sandbox.FixedJointBuilder WithLinearFrequency(System.Single v)`
- `Sandbox.FixedJointBuilder WithLinearDamping(System.Single v)`
- `Sandbox.FixedJointBuilder WithAngularFrequency(System.Single v)`
- `Sandbox.FixedJointBuilder WithAngularDamping(System.Single v)`
