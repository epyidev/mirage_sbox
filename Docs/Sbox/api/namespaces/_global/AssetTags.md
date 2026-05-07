# Editor.Asset.AssetTags

Represents a collection of tags for an asset.
This is only necessary so we can save tags as soon as they are added.

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Tools`
- **Declaring type:** `Editor.Asset`

## Methods

### Instance methods

- `System.Void Add(System.String tag)`
  - Add a single tag.
- `System.Void Add(System.String[] in_tags)`
  - Add multiple tags at once.
- `System.Void Remove(System.String tag)`
  - Remove given tag from the asset.
- `System.Void Toggle(System.String tag)`
  - Remove the tag if present, add if not.
- `System.Void Set(System.String tag, System.Boolean set)`
  - Set or remove the tag based on second argument.
- `System.Boolean Contains(System.String tag)`
  - Returns whether this asset has given tag.
- `System.String[] GetAll()`
  - Returns all tags of this asset.
- `virtual System.Collections.Generic.IEnumerator<System.String> GetEnumerator()`
