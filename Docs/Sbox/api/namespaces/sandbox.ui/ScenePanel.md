# Sandbox.UI.ScenePanel

Allows to render a scene world onto a panel.

- **Kind:** class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.UI.Panel`

## Constructors

- `ScenePanel()`
- `ScenePanel(System.String sceneFilename)`
  - Creates and loads a Scene from a file to render to this panel.

## Properties

- `Sandbox.SceneWorld World`
  - Shortcut to Camera.World
- `Sandbox.SceneCamera Camera`
  - The camera we're going to be using to render
- `System.Boolean RenderOnce`
  - If enabled, the scene will only render once. That isn't totally accurate though, because we'll
also re-render the scene when the size of the panel changes.
- `Sandbox.Texture RenderTexture`
  - The texture that the panel is rendering to internally. This will change to a different
texture if the panel changes size, so I wouldn't hold onto this object.
- `Sandbox.Scene RenderScene`
  - The Scene this panel renders.

## Methods

### Instance methods

- `virtual System.Void Tick()`
- `System.Void RenderNextFrame()`
  - Render the panel again next frame. This is meant to be used with RenderOnce, where
you might want to render on demand or only once.
- `virtual System.Void Delete(System.Boolean immediate)`
- `virtual System.Void OnDraw()`
- `virtual System.Void SetProperty(System.String name, System.String value)`
