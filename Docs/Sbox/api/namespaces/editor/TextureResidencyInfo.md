# Editor.TextureResidencyInfo

Provides information about currently resident textures on the GPU

- **Kind:** struct
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Fields

- `System.String Name`
- `Editor.TextureResidencyInfo.TextureDimension Dimension`
- `Sandbox.ImageFormat Format`
- `Editor.TextureResidencyInfo.Desc Loaded`
- `Editor.TextureResidencyInfo.Desc Disk`

## Methods

### Static methods

- `static System.Collections.Generic.IEnumerable<Editor.TextureResidencyInfo> GetAll()`
  - Get info about all resident textures
