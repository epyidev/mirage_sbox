# Editor.StandaloneExporter

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Properties

- `Sandbox.Project Project`
- `System.Collections.Generic.IReadOnlyList<Editor.StandaloneExporter.QueuedFile> Files`
- `Editor.ProjectPublisher.PackageManifest PackageManifest`
- `Sandbox.StandaloneManifest StandaloneManifest`
- `System.Action<Editor.StandaloneExporter.ExportProgress> OnProgressChanged`

## Methods

### Static methods

- `static System.Threading.Tasks.Task<Editor.StandaloneExporter> FromConfig(Editor.ExportConfig config)`

### Instance methods

- `System.Threading.Tasks.Task Run()`
- `System.Threading.Tasks.Task AddFile(System.Byte[] contents, System.String relativePath)`
  - Manually add a file to the manifest
- `System.Threading.Tasks.Task AddFile(System.String contents, System.String relativePath)`
  - Manually add a file to the manifest
- `System.Threading.Tasks.Task AddCodePackageReference(System.String package)`
  - If the code is referencing a package - we can add it to the manifest using this.
