# Sandbox.EditorSystemPublic

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.EditorSystem`

## Constructors

- `EditorSystemPublic()`

## Properties

- `Sandbox.Scene Scene`
- `Sandbox.CameraComponent Camera`

## Methods

### Instance methods

- `virtual System.Threading.Tasks.Task ForEachAsync(System.Collections.Generic.IEnumerable<T> list, System.String title, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task> worker, System.Threading.CancellationToken cancel, System.Boolean modal)`
- `virtual Editor.IProgressSection ProgressSection(System.Boolean modal)`
  - Start a progress section
