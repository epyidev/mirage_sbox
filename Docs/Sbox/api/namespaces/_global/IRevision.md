# Sandbox.Package.IRevision

- **Kind:** interface
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Package`

## Properties

- `System.Int64 VersionId`
  - Unique index of this revision.
- `System.Int64 FileCount`
  - Number of files in this revision.
- `System.Int64 TotalSize`
  - Total size of all the files in this revision, in bytes.
- `System.String Summary`
  - A summary of the changes in this revision.
- `System.DateTimeOffset Created`
  - When this revision was created.
- `System.Int32 EngineVersion`
  - Engine version of this revision.
TODO: How exactly is this different from `Sandbox.Package.EngineVersion`?
- `Sandbox.ManifestSchema Manifest`
  - Manifest of the revision, describing what files are available. For this to be available
you should call DownloadManifestAsync first.

## Methods

### Instance methods

- `virtual System.Threading.Tasks.Task DownloadManifestAsync(System.Threading.CancellationToken token)`
  - The manifest will not be immediately available until you've downloaded it.
