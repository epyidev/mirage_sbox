# Editor.EditorSystem

- **Kind:** abstract class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `EditorSystem()`

## Properties

- `Sandbox.Scene Scene`
  - The scene we're currently editing
- `Sandbox.CameraComponent Camera`
  - The main editor camera

## Methods

### Instance methods

- `virtual System.Threading.Tasks.Task ForEachAsync(System.Collections.Generic.IEnumerable<T> list, System.String title, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task> worker, System.Threading.CancellationToken cancel, System.Boolean modal)`
- `virtual Editor.IProgressSection ProgressSection(System.Boolean modal)`
  - Start a progress section
