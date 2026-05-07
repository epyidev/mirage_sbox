# Sandbox.CollisionSoundSystem

This system exists to collect pending collision sounds and filter them into a unique set, to avoid
unnesssary sounds playing, when they're going to be making the same sound anyway.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.GameObjectSystem<T>`

## Constructors

- `CollisionSoundSystem(Sandbox.Scene scene)`

## Methods

### Instance methods

- `System.Void RegisterCollision(Sandbox.Collision collision)`
  - Register this physics collision with the sound system
- `System.Void AddShapeCollision(Sandbox.PhysicsShape shape, Sandbox.Surface surface, Vector3 position, System.Single speed, System.Boolean networked)`
  - Add a collision sound for this shape
- `System.Void AddShapeCollision(Sandbox.PhysicsShape shape, Sandbox.Surface surface, Sandbox.PhysicsContact contact, System.Boolean networked)`
