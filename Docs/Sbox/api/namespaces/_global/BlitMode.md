# Sandbox.BasePostProcess.BlitMode

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.BasePostProcess`

## Fields

- `Sandbox.Material Material`
  - The material to use for the blit.
- `Sandbox.RenderAttributes Attributes`
  - We'll use this instead of BasePostProcess.Attributes if set.
- `Sandbox.Rendering.Stage RenderStage`
  - Where to place this in the render pipeline
- `System.Int32 Order`
  - The order within the stage. Lower numbers get rendered first.
- `System.Boolean WantsBackbuffer`
  - If true, the backbuffer will be copied to a texture called "ColorBuffer" before the blit.
- `System.Boolean WantsBackbufferMips`
  - If both WantsBackbuffer and this is true the backbuffer will be mipped after being copied.

## Methods

### Static methods

- `static Sandbox.BasePostProcess.BlitMode Simple(Sandbox.Material m, Sandbox.Rendering.Stage stage, System.Int32 order)`
  - Shortcut to build a simple blit mode
- `static Sandbox.BasePostProcess.BlitMode WithBackbuffer(Sandbox.Material m, Sandbox.Rendering.Stage stage, System.Int32 order, System.Boolean mip)`
  - Shortcut to build a blit mode that copies the backbuffer first
