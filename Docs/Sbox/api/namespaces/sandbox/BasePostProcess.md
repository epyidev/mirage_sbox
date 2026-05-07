# Sandbox.BasePostProcess

The base class for all post process effects.

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `BasePostProcess()`

## Properties

- `Sandbox.CameraComponent Camera`
  - The camera we're being applied to. This is only valid during the Render call.

## Fields

- `Sandbox.RenderAttributes Attributes`
  - The default attributes for this post process. This will be used by helper functions like Blit.

## Methods

### Instance methods

- `virtual System.Void Render()`
  - Override in your implementation to do your rendering
- `System.Void Blit(Sandbox.BasePostProcess.BlitMode blit, System.String debugName)`
  - Helper to do a blit with the current camera's post process
- `System.Void BlitSimple(Sandbox.Material shader, Sandbox.Rendering.Stage stage, System.Int32 order, System.String debugName)`
  - Helper to do a blit with the current camera's post process
- `System.Void InsertCommandList(Sandbox.Rendering.CommandList cl, Sandbox.Rendering.Stage stage, System.Int32 order, System.String debugName)`
  - Helper to add a command list to the current camera's post process
