# Editor.DragAssetData

Represents an asset being dragged into an editor window. Assets will either
be sourced from a package (see `Editor.DragAssetData.PackageIdent`) or a local path (see `Editor.DragAssetData.AssetPath`).
Instances of this type are accessed through `Editor.DragData.Assets`.

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Properties

- `System.String PackageIdent`
  - For package assets, the identifier of the source package. Will always be of the form `org.package[#version]`.
- `System.String AssetPath`
  - For local assets, the path to the asset. Equivalent to `Editor.Asset.Path`.
- `System.Single DownloadProgress`
  - For cloud assets, a value between `0.0` and `1.0` representing download progress.
Download will only start after the first call to `Editor.DragAssetData.GetAssetAsync`.
- `System.Boolean IsInstalled`
  - True when the asset is ready for use locally.
For cloud assets, download will only start after the first call to `Editor.DragAssetData.GetAssetAsync`.

## Methods

### Instance methods

- `System.Threading.Tasks.Task<Sandbox.Package> GetPackageAsync()`
  - For package assets, completes when the source package information is available.
- `System.Threading.Tasks.Task<Editor.Asset> GetAssetAsync()`
  - Completes when the asset is ready to use. For cloud assets, the first call to this
will start downloading and installing the source package. This is safe to call
multiple times, the same task will be returned.
