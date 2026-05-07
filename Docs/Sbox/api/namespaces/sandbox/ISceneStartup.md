# Sandbox.ISceneStartup

Allows listening to events related to scene startup. This should really only apply to GameObjectSystem's
because components won't have been spawned/created when most of this is invoked.

- **Kind:** interface
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Methods

### Instance methods

- `virtual System.Void OnHostPreInitialize(Sandbox.SceneFile scene)`
  - Called before the scene is loaded. In game only, on host only.
- `virtual System.Void OnHostInitialize()`
  - Called after the scene is loaded. In game only, on the host only.
- `virtual System.Void OnClientInitialize()`
  - Called in game after the client has loaded the initial scene from the server, or after OnHostInitialize. 
This is not called on the dedicated server.
