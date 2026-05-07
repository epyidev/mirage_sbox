# Sandbox.Particle.BaseListener

Allows creating a class that will exist for as long as a particle.
The methods get called in the particle thread, which removes the need to run through
the particle list again, but it has the danger and restrictions that come with threaded code.

- **Kind:** abstract class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Particle`

## Constructors

- `BaseListener()`

## Properties

- `Sandbox.Component Source`
  - The component that created this listener. May be null.

## Methods

### Instance methods

- `virtual System.Void OnEnabled(Sandbox.Particle p)`
  - Called in a thread. The particle is in its first position.
- `virtual System.Void OnUpdate(Sandbox.Particle p, System.Single dt)`
  - Called in a thread, guarenteed to be called after OnEnabled
- `virtual System.Void OnDisabled(Sandbox.Particle p)`
  - Called in a thread. OnUpdate won't be called again.
