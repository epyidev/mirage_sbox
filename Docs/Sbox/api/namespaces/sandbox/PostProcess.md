# Sandbox.PostProcess

Adds an effect to the camera

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `PostProcess()`

## Properties

- `Sandbox.CameraComponent Camera`
- `Sandbox.Rendering.Stage RenderStage`
  - The stage in the render pipeline that we'll get rendered in
- `System.Int32 RenderOrder`
  - Lower numbers get renderered first
- `Sandbox.Rendering.CommandList CommandList`

## Methods

### Instance methods

- `virtual System.Void OnEnabled()`
- `virtual System.Void OnDisabled()`
- `virtual System.Void OnUpdate()`
- `virtual System.Void UpdateCommandList()`
  - You should implement this method and fill the CommandList with the actions
that you want to do for this post process.
