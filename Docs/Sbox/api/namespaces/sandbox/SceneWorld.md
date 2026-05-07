# Sandbox.SceneWorld

A scene world that contains `Sandbox.SceneObject`s. See <a href="https://sbox.game/api/Tools.Utility.CreateSceneWorld()">Utility.CreateSceneWorld</a>.
            


You may also want a `Sandbox.SceneCamera` to manually render the scene world.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `SceneWorld()`

## Properties

- `System.Collections.Generic.IReadOnlyCollection<Sandbox.SceneObject> SceneObjects`
  - List of scene objects belonging to this scene world.
- `Sandbox.Engine.Utility.RayTrace.MeshTraceRequest Trace`
  - Trace against all scene objects in this scene world

## Fields

- `Sandbox.Rendering.GradientFogSetup GradientFog`
  - Controls gradient fog settings.
- `Color AmbientLightColor`
  - Sets the ambient lighting color
- `Color ClearColor`
  - Sets the clear color, if nothing else is drawn, this is the color you will see

## Methods

### Instance methods

- `System.Void Delete()`
  - Delete this scene world. You shouldn't access it anymore.
- `System.Void DeletePendingObjects()`
  - Deleted objects are actually deleted at the end of each frame. Call this
to actually delete pending deletes right now instead of waiting.
