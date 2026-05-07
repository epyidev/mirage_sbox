# Editor.ProjectPublisher.PackageManifest

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Tools`
- **Declaring type:** `Editor.ProjectPublisher`

## Constructors

- `PackageManifest()`

## Properties

- `System.String Summary`
- `System.String Description`
- `System.Boolean IncludeSourceFiles`
- `System.Collections.Generic.HashSet<System.String> CodePackageReferences`
  - List of packages that the code references
- `System.Collections.Generic.List<Editor.ProjectPublisher.ProjectFile> Assets`

## Fields

- `System.Collections.Generic.List<System.String> Errors`
- `static System.String[] DissallowedExtensions`
  - This really exists only to dissallow dangerous extensions like .exe etc.
So feel free to add anything non dangerous to this list.

## Methods

### Static methods

- `static System.Boolean LooseFileAllowed(System.String file, System.Boolean allowSourceFiles)`

### Instance methods

- `Editor.ProjectPublisher.ProjectFile FindAsset(System.String relativePath)`
- `System.Threading.Tasks.Task BuildFromAssets(Sandbox.Project project, Editor.IProgress progress, System.Threading.CancellationToken cancel)`
- `System.Threading.Tasks.Task BuildFromSource(Sandbox.Project addon, Editor.IProgress progress, System.Threading.CancellationToken cancel)`
- `System.String ToJson()`
- `System.Threading.Tasks.Task AddTextFile(System.String contents, System.String relativePath)`
