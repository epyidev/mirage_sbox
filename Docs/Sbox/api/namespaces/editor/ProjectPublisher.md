# Editor.ProjectPublisher

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Properties

- `System.String TargetPackageIdent`
- `Editor.ProjectPublisher.PackageManifest Manifest`
- `System.Int32 TotalFileCount`
- `System.Int32 MissingFileCount`
- `System.Int64 MissingFileSize`
- `System.Action OnProgressChanged`
- `System.Collections.Generic.IEnumerable<Editor.ProjectPublisher.ProjectFile> Files`
  - Get access to the files within the manifest

## Methods

### Static methods

- `static System.Threading.Tasks.Task<Editor.ProjectPublisher> FromAsset(Editor.Asset asset)`
- `static System.Threading.Tasks.Task<Editor.ProjectPublisher> FromProject(Sandbox.Project project)`
- `static System.Boolean CanPublishFile(Editor.Asset a)`
  - Return true if we're not opposed to publishing this asset

### Instance methods

- `System.Void SetMeta(System.String key, System.Object obj)`
- `System.Collections.Generic.List<Sandbox.DataModel.GameSetting> GetGameSettings(Sandbox.CompilerOutput[] assemblies)`
  - Fetch a list of game settings to be added to the project's metadata
- `System.Threading.Tasks.Task Publish(Editor.IProgress progress, System.Threading.CancellationToken cancel)`
  - Publish a new revision
- `System.Threading.Tasks.Task PrePublish(System.Threading.CancellationToken cancellationToken)`
  - Check the intended manifest, ask the backend which files need to be uploaded.
- `System.Threading.Tasks.Task UploadFiles()`
- `System.Threading.Tasks.Task AddFile(System.Byte[] contents, System.String relativePath)`
  - Manually add a file to the manifest
- `System.Threading.Tasks.Task AddFile(System.String contents, System.String relativePath)`
  - Manually add a file to the manifest
- `System.Threading.Tasks.Task AddCodePackageReference(System.String package)`
  - If the code is referencing a package - we can add it to the manifest using this.
- `System.Void SetChangeDetails(System.String change, System.String detail)`
  - Allows to set information on the revision - for future reference
