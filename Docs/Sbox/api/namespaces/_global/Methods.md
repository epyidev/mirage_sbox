# Sandbox.Doo.Methods

Built-in static methods available to Doo scripts.

- **Kind:** static class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Doo`

## Methods

### Static methods

- `static System.Void LogInfo(System.String text)`
  - Logs an informational message.
- `static System.Void LogWarning(System.String text)`
  - Logs a warning message.
- `static System.Void LogError(System.String text)`
  - Logs an error message.
- `static System.Void GameObjectDestroy(Sandbox.GameObject gameObject)`
  - Destroys the given GameObject.
- `static Sandbox.GameObject GameObjectClone(Sandbox.GameObject gameObject, System.Boolean enabled, System.Boolean networked)`
  - Clones a GameObject, optionally spawning it on the network.
- `static Sandbox.GameObject GameObjectCloneEx(Sandbox.GameObject gameObject, Vector3 position, Rotation angles, Vector3 scale)`
  - Clones a GameObject with an explicit position, rotation, and scale.
