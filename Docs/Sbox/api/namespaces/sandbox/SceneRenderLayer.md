# Sandbox.SceneRenderLayer

SceneObjects can be rendered on layers other than the main game layer.
This is useful if, for example, you want to render on top of everything without
applying post processing.

- **Kind:** enum
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Enum`

## Values

- `Default` - Draw wherever makes sense based on the flags, default behaviour
- `ViewModel` - Layer drawn on top of everything else - with altered depth
- `OverlayWithDepth` - Overlay - after post processing - but still with the scene's depth
- `OverlayWithoutDepth` - Overlay - after post processing - without depth (draw over)
