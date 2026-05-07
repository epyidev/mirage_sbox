# Editor.AssetSystem.IEventListener

Callbacks for the asset system. Add this interface to your Widget to get events.

- **Kind:** interface
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Tools`
- **Declaring type:** `Editor.AssetSystem`

## Methods

### Instance methods

- `virtual System.Void OnAssetChanged(Editor.Asset asset)`
  - An asset has been modified
- `virtual System.Void OnAssetThumbGenerated(Editor.Asset asset)`
  - The thumbnail for an asset has been updated
- `virtual System.Void OnAssetSystemChanges()`
  - Changes have been detected in the asset system. We won't tell you what, but
you probably need to update the asset list or something.
- `virtual System.Void OnAssetTagsChanged()`
  - Called when a new tag has been added to the asset system.
