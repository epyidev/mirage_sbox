# Editor.AssetType

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Constructors

- `AssetType()`

## Properties

- `static System.Collections.Generic.IReadOnlyCollection<Editor.AssetType> All`
  - All currently registered asset types, including the base types such as models, etc.
- `static Editor.AssetType Model`
  - Model (.vmdl) asset type.
- `static Editor.AssetType Animation`
  - Animation (.vanim) asset type.
- `static Editor.AssetType AnimationGraph`
  - Animation Graph (.vanmgrph) asset type.
- `static Editor.AssetType Texture`
  - Texture (.vtex) asset type.
- `static Editor.AssetType Material`
  - Material (.vmat) asset type.
- `static Editor.AssetType SoundFile`
  - Sound (.wav, .ogg or .mp3) asset type.
- `static Editor.AssetType SoundEvent`
  - A sound event
- `static Editor.AssetType Soundscape`
  - A soundscape
- `static Editor.AssetType ImageFile`
  - Image source (.png or .jpg) asset type.
- `static Editor.AssetType Shader`
  - Shader (.shader) asset type.
- `static Editor.AssetType MapFile`
  - A map (.vmap) asset type.
- `System.String FriendlyName`
  - Name of the asset type for UI purposes.
- `System.String FileExtension`
  - Primary file extension for this asset type.
- `System.Collections.Generic.IReadOnlyList<System.String> FileExtensions`
  - All file extensions for this asset type.
- `System.Boolean HiddenByDefault`
  - This asset type is hidden by default from asset browser, etc.
- `System.Boolean IsSimpleAsset`
  - A simple asset is used by something else. It never exists in the game on its own.
- `System.Boolean HasDependencies`
  - This asset type can have dependencies
- `System.Boolean PrefersIconThumbnail`
  - Use asset type icon, over any preview image.
- `Editor.Pixmap Icon16`
  - 16x16 icon for this asset type.
- `Editor.Pixmap Icon64`
  - 64x64 icon for this asset type.
- `Editor.Pixmap Icon128`
  - 128x128 icon for this asset type.
- `Editor.Pixmap Icon256`
  - 256x256 icon for this asset type.
- `System.Boolean IsGameResource`
  - Whether this asset type is a custom game resource or not.
- `System.Type ResourceType`
  - Type that will be returned by `Editor.Asset.LoadResource`.
- `System.String Category`
  - Category of this asset type, for grouping in UI.
- `Color Color`
  - Color that represents this asset, for use in the asset browser.
- `Sandbox.AssetTypeFlags Flags`
  - Flags for this asset type
- `System.Boolean HasEditor`
  - Returns true if there is an editor available for this asset type.

## Methods

### Static methods

- `static Editor.AssetType Find(System.String name, System.Boolean allowPartials)`
  - Find an asset type by name or extension match.
  - `name`: Name or extension of an asset type to search for.
  - `allowPartials`: Whether partial matches for the name are allowed.
- `static Editor.AssetType FromType(System.Type t)`
  - For a type (ie Texture, Material, Surface) return the appropriate AssetType.
Returns null if can't resolve.
- `static Editor.AssetType FromExtension(System.String extension)`
