# Sandbox.ProjectSettings

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `ProjectSettings()`

## Properties

- `static Sandbox.Physics.CollisionRules Collision`
  - Get the `Sandbox.Physics.CollisionRules` from the active project settings.
- `static Sandbox.InputSettings Input`
  - Get the `Sandbox.ProjectSettings.Input` from the active project settings.
- `static Sandbox.NetworkingSettings Networking`
  - Get the `Sandbox.NetworkingSettings` from the active project settings.
- `static Sandbox.Physics.PhysicsSettings Physics`
  - Get the `Sandbox.Physics.PhysicsSettings` from the active project settings.
- `static Sandbox.SystemsConfig Systems`
  - Get the `Sandbox.SystemsConfig` from the active project settings.

## Methods

### Static methods

- `static T Get(System.String filename)`
  - Gets or creates a default version of this config data. You can safely call this multiple times
and it will return the same object. The cache is cleared automatically when the project changes, 
or when it's hotloaded.
