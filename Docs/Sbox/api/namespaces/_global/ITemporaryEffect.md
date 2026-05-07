# Sandbox.Component.ITemporaryEffect

Allows components to indicate their state in a generic way. This is useful if you have a temporary effect system in which
you want to remove GameObjects when their effects have all finished.

- **Kind:** interface
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Component`

## Properties

- `System.Boolean IsActive`
  - Should return true if the effect is active in a visible way

## Methods

### Static methods

- `static System.Void DisableLoopingEffects(Sandbox.GameObject go)`
  - Disable the any looping effects. This indicates to the target object that we want it to die soon.

### Instance methods

- `virtual System.Void DisableLooping()`
  - Indicates to the target object that we want it to die. If it's looping then
it should stop now and put itself in a state where it will eventually die.
