# Sandbox.AmbientOcclusion.DenoiseModes

- **Kind:** enum
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Enum`
- **Declaring type:** `Sandbox.AmbientOcclusion`

## Values

- `Spatial` - Applies same-frame multi-pass spatial denoising (dilated edge-aware blur).
This smooths sampling noise without requiring previous frame history.
- `Temporal` - Applies temporal denoising to reduce noise by averaging pixel values over multiple frames.
This method leverages the temporal coherence of consecutive frames to achieve a noise-free result.
