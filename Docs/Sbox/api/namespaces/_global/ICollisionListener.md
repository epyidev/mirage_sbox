# Sandbox.Component.ICollisionListener

A `Sandbox.Component` with this interface can react to collisions.

- **Kind:** interface
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Component`

## Methods

### Instance methods

- `virtual System.Void OnCollisionStart(Sandbox.Collision collision)`
  - Called when this collider/rigidbody starts touching another collider.
- `virtual System.Void OnCollisionUpdate(Sandbox.Collision collision)`
  - Called once per physics step for every collider being touched.
- `virtual System.Void OnCollisionStop(Sandbox.CollisionStop collision)`
  - Called when this collider/rigidbody stops touching another collider.
