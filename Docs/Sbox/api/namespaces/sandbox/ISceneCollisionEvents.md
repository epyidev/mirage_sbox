# Sandbox.ISceneCollisionEvents

Listen to all collision events that happen during a physics step.

- **Kind:** interface
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Methods

### Instance methods

- `virtual System.Void OnCollisionStart(Sandbox.Collision collision)`
  - Called when a collider/rigidbody starts touching another collider.
- `virtual System.Void OnCollisionUpdate(Sandbox.Collision collision)`
  - Called once per physics step for every collider being touched.
- `virtual System.Void OnCollisionStop(Sandbox.CollisionStop collision)`
  - Called when a collider/rigidbody stops touching another collider.
- `virtual System.Void OnCollisionHit(Sandbox.Collision collision)`
  - Called when a collider/rigidbody hits another collider, including repeated hits
on the same shape while they are already touching.
