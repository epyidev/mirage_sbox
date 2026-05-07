# Sandbox.Component.ITriggerListener

A `Sandbox.Component` with this interface can react to interactions with triggers.

- **Kind:** interface
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Component`

## Methods

### Instance methods

- `virtual System.Void OnTriggerEnter(Sandbox.Collider other)`
  - Called when a collider enters the trigger.
  - `other`: The collider that entered.
- `virtual System.Void OnTriggerEnter(Sandbox.Collider self, Sandbox.Collider other)`
  - Called when a collider enters the trigger.
  - `self`: This trigger's collider.
  - `other`: The collider that entered.
- `virtual System.Void OnTriggerExit(Sandbox.Collider other)`
  - Called when a collider exits the trigger.
  - `other`: The collider that exited.
- `virtual System.Void OnTriggerExit(Sandbox.Collider self, Sandbox.Collider other)`
  - Called when a collider exits the trigger.
  - `self`: This trigger's collider.
  - `other`: The collider that exited.
- `virtual System.Void OnTriggerEnter(Sandbox.GameObject other)`
  - Called when a game object enters the trigger.
  - `other`: The game object that entered.
- `virtual System.Void OnTriggerEnter(Sandbox.Collider self, Sandbox.GameObject other)`
  - Called when a game object enters the trigger.
  - `self`: This trigger's collider.
  - `other`: The game object that entered.
- `virtual System.Void OnTriggerExit(Sandbox.GameObject other)`
  - Called when a game object exits the trigger.
  - `other`: The game object that exited.
- `virtual System.Void OnTriggerExit(Sandbox.Collider self, Sandbox.GameObject other)`
  - Called when a game object exits the trigger.
  - `self`: This trigger's collider.
  - `other`: The game object that exited.
