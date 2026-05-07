# Sandbox.IScenePhysicsEvents

Allows events before and after the the physics step

- **Kind:** interface
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Methods

### Instance methods

- `virtual System.Void PrePhysicsStep()`
  - Called before the physics step is run. This is called pretty much
right after FixedUpdate.
- `virtual System.Void PostPhysicsStep()`
  - Called after the physics step is run
- `virtual System.Void OnOutOfBounds(Sandbox.Rigidbody body)`
  - Called when a rigidbody goes out of bounds.
- `virtual System.Void OnFellAsleep(Sandbox.Rigidbody body)`
  - Called when a rigidbody goes to sleep.
