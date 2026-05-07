# Sandbox.ModelPhysics

Physics for a model. This is primarily used for ragdolls and other physics driven models, otherwise you should be using a Rigidbody.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `ModelPhysics()`

## Properties

- `Sandbox.PhysicsGroup PhysicsGroup`
- `System.Boolean PhysicsWereCreated`
- `Sandbox.Model Model`
  - The model used to generate physics bodies, collision shapes, and joints.
- `Sandbox.SkinnedModelRenderer Renderer`
  - The renderer that receives transform updates from physics bodies.
- `System.Boolean IgnoreRoot`
  - If true, the root physics body will not drive this component's transform.
- `Sandbox.RigidbodyFlags RigidbodyFlags`
  - Rigidbody flags applied to all bodies.
- `Sandbox.PhysicsLock Locking`
  - Rigidbody locking applied to all bodies.
- `System.Boolean StartAsleep`
  - All bodies will be put to sleep on start.
- `System.Boolean MotionEnabled`
  - Enable to drive renderer from physics, disable to drive physics from renderer.
- `System.Single Mass`
  - Returns the total mass of every `Sandbox.Rigidbody`
- `Vector3 MassCenter`
  - Returns the center of mass of every `Sandbox.Rigidbody` in world-space
- `System.Collections.Generic.List<Sandbox.ModelPhysics.Body> Bodies`
  - Networked list of bodies.
- `System.Collections.Generic.List<Sandbox.ModelPhysics.Joint> Joints`
  - Networked list of joints.

## Methods

### Instance methods

- `System.Void CopyBonesFrom(Sandbox.SkinnedModelRenderer source, System.Boolean teleport)`
  - Copy the bone positions and velocities from a different SkinnedModelRenderer
