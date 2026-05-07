# Sandbox.ISceneLoadingEvents

Allows listening to events related to scene loading

- **Kind:** interface
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Methods

### Instance methods

- `virtual System.Void BeforeLoad(Sandbox.Scene scene, Sandbox.SceneLoadOptions options)`
  - Called before the loading starts
- `virtual System.Threading.Tasks.Task OnLoad(Sandbox.Scene scene, Sandbox.SceneLoadOptions options)`
  - Called during loading. The game will wait for your task to finish
- `virtual System.Threading.Tasks.Task OnLoad(Sandbox.Scene scene, Sandbox.SceneLoadOptions options, Sandbox.LoadingContext context)`
  - Called during loading. The game will wait for your task to finish
- `virtual System.Void AfterLoad(Sandbox.Scene scene)`
  - Loading has finished
