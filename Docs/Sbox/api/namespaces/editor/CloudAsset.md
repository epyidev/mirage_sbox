# Editor.CloudAsset

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Constructors

- `CloudAsset()`

## Methods

### Static methods

- `static System.Threading.Tasks.Task InstallSingle(System.String ident)`
  - Install a cloud asset by ident
- `static System.Threading.Tasks.Task<System.Boolean> Install(System.String windowTitle, System.Collections.Generic.IEnumerable<System.String> packages)`
- `static System.Threading.Tasks.Task<System.Boolean> Install(System.Collections.Generic.IEnumerable<System.String> packages, System.Threading.CancellationToken token)`
- `static System.Collections.Generic.HashSet<System.String> GetAssetReferences(System.Boolean currentProjectOnly)`
  - Gets all cloud packages referenced from assets
