# Sandbox.SceneCustomObject

A scene object that allows custom rendering within a scene world.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.SceneObject`

## Constructors

- `SceneCustomObject(Sandbox.SceneWorld sceneWorld)`

## Fields

- `System.Action<Sandbox.SceneObject> RenderOverride`
  - Called by default version of `Sandbox.SceneCustomObject.RenderSceneObject`.

## Methods

### Instance methods

- `virtual System.Void RenderSceneObject()`
  - Called when this scene object needs to be rendered.
Invokes `Sandbox.SceneCustomObject.RenderOverride` by default. See the `Sandbox.Graphics` library for a starting point.
