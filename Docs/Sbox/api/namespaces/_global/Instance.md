# Sandbox.Gizmo.Instance

Holds the backend state for a Gizmo scope. This allows us to have multiple different gizmo
states (for multiple views, multiple windows, game and editor) and push them as the current
active state whenever needed.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Gizmo`

## Constructors

- `Instance()`

## Properties

- `System.Boolean Debug`
  - If true, we'll draw some debug information
- `System.Boolean DebugHitboxes`
  - If true we'll enable hitbox debugging
- `Sandbox.SceneWorld World`
  - The SceneWorld this instance is writing to. This world exists only for this instance.
You need to add this world to your camera for it to render (!)
- `Sandbox.Gizmo.Inputs PreviousInput`
  - The previous input state
- `Sandbox.SelectionSystem Selection`
  - This frame's created (or re-used) objects
- `System.String ControlMode`
  - The current control mode. This is generally implementation specific. 
We tend to use "mouse" and "firstperson".
- `Sandbox.Gizmo.SceneSettings Settings`
  - Some global settings accessible to the gizmos. Your implementation
generally lets your users set up  these things to their preference, 
and the gizmos should try to obey them.

## Fields

- `Sandbox.Gizmo.Inputs Input`
  - Input state. Should be setup before push.

## Methods

### Instance methods

- `T GetValue(System.String name)`
  - Generic storage for whatever you want to do. 
You're responsible for not spamming into this and cleaning up after yourself.
- `System.Void SetValue(System.String name, T value)`
  - Generic storage for whatever you want to do. 
You're responsible for not spamming into this and cleaning up after yourself.
- `System.Void Clear()`
  - Called when the scene changes and we don't want to inherit a bunch of values.
We might want to just target some specific values here instead of clearing the log.
- `virtual System.Void Dispose()`
  - Destroy this instance, clean up any created resources/scene objects, destroy the world.
- `System.IDisposable Push()`
  - Push this instance as the global Gizmo state. All Gizmo calls during this scope
will use this instance.
- `System.Void StompCursorPosition(Vector2 position)`
  - Set all of the state's cursor positions to this value. This stomps previous values
which will effectively clear any deltas. This should be used prior to starting a loop.
