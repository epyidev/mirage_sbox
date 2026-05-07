# Editor.AssetSystem

The asset system, provides access to all the assets.

- **Kind:** static class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Properties

- `static System.Collections.Generic.IEnumerable<Editor.Asset> All`
  - All the assets that are being tracked by the asset system. Does not include deleted assets.

## Methods

### Static methods

- `static System.Threading.Tasks.Task<Editor.Asset> InstallAsync(System.String packageIdent, System.Boolean skipIfInstalled, System.Action<System.Single> loading, System.Threading.CancellationToken token)`
- `static System.Threading.Tasks.Task<Editor.Asset> InstallAsync(Sandbox.Package package, System.Boolean skipIfInstalled, System.Action<System.Single> loading, System.Threading.CancellationToken token)`
- `static Sandbox.Package.IRevision GetInstalledRevision(System.String packageIdent)`
  - Gets the locally installed package revision by ident
- `static System.Boolean IsCloudInstalled(System.String packageIdent)`
  - Is this package installed in our cloud directory?
- `static System.Boolean IsCloudInstalled(Sandbox.Package package, System.Boolean exactVersion)`
  - Is a version this package installed in our cloud directory?
- `static System.Collections.Generic.IReadOnlyCollection<Sandbox.Package> GetInstalledPackages()`
  - Get all packages in the download cache
- `static System.Collections.Generic.IReadOnlyCollection<Sandbox.Package> GetReferencedPackages()`
  - Get all packages, referenced by assets in the current project, in the download cache
- `static System.Collections.Generic.IReadOnlyCollection<System.String> GetPackageFiles(Sandbox.Package package)`
- `static System.Boolean CanCloudInstall(Sandbox.Package package)`
  - Is this package type something we can install?
- `static System.Boolean CompileResource(System.String path, System.String text)`
  - Compile a resource from text.
- `static System.Boolean CompileResource(System.String path, System.ReadOnlySpan<System.Byte> data)`
- `static Editor.Asset FindByPath(System.String path)`
  - Find an asset by path.
  - `path`: The file path to an asset. Can be absolute or relative.
- `static Editor.Asset RegisterFile(System.String absoluteFilePath)`
  - If you just created an asset, you probably want to immediately register it
- `static System.Void DeleteOrphans()`
  - Delete orphaned trivial children. These are things that are generated for
usage by an asset, but aren't referenced by anything, so are useless.
- `static Editor.Asset CreateResource(System.String type, System.String absoluteFilename)`
  - Create an empty `Sandbox.GameResource`.
  - `type`: Asset type extension for our new `Sandbox.GameResource` instance.
  - `absoluteFilename`: Where to save the new `Sandbox.GameResource` instance. For example from `Editor.FileDialog`.
  - returns: The new asset, or null if creation failed.
- `static Editor.Asset CreateEmbeddedAsset(Sandbox.SerializedProperty target)`
  - Create an Asset from a serialized property. This is expected to be an embedded asset property.
