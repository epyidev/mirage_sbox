# Editor.LibrarySystem

- **Kind:** static class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Properties

- `static System.Collections.Generic.IEnumerable<Editor.LibraryProject> All`
  - Get all active libraries

## Methods

### Static methods

- `static System.Threading.Tasks.Task Add(System.String folderName, System.Threading.CancellationToken token)`
  - Add a library from this folder
- `static System.Threading.Tasks.Task<System.Boolean> Install(System.String ident, System.Int64 versionId, System.Threading.CancellationToken token)`
  - Install a library from a package. This will download the package and install it in the project's Library folder.
