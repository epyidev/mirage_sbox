# Sandbox.Renderer

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `Renderer()`

## Properties

- `Sandbox.RenderOptions RenderOptions`
- `Sandbox.RenderAttributes Attributes`
  - Attributes that are applied to the renderer based on the current material and shader.
If the renderer is disabled, the changes are deferred until it is enabled again.
Attributes are not saved to disk, and are not cloned when copying the renderer.
- `Sandbox.Rendering.CommandList ExecuteBefore`
  - A command list which is executed immediately before rendering this
- `Sandbox.Rendering.CommandList ExecuteAfter`
  - A command list which is executed immediately after rendering this

## Methods

### Instance methods

- `virtual System.Void OnRenderOptionsChanged()`
- `virtual System.Void CopyFrom(Sandbox.Renderer other)`
  - Copy everything from another renderer
- `System.Void BackupRenderAttributes(Sandbox.RenderAttributes attributes)`
  - Backup the specified RenderAttributes so we can restore them later with `Sandbox.Renderer.RestoreRenderAttributes(Sandbox.RenderAttributes)`
- `System.Void RestoreRenderAttributes(Sandbox.RenderAttributes attributes)`
  - Restore any attributes that were previously backed up with `Sandbox.Renderer.BackupRenderAttributes(Sandbox.RenderAttributes)`
