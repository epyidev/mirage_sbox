# Editor.CodeEditor

For opening source code files in whatever code editor the user has selected.

- **Kind:** static class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Properties

- `static Editor.ICodeEditor Current`
  - The current code editor we're using.
- `static System.String Title`
  - Friendly name for our current code editor.

## Methods

### Static methods

- `static System.Void OpenFile(Sandbox.Internal.ISourcePathProvider location)`
- `static System.Void OpenFile(System.String path, System.Nullable<System.Int32> line, System.Nullable<System.Int32> column)`
- `static System.Boolean CanOpenFile(System.String path)`
  - Returns true if the file exists and can be opened by the current code editor.
- `static System.Void OpenSolution()`
  - Open the solution of all s&amp;box projects
- `static System.Void OpenAddon(Sandbox.Project addon)`
- `static System.String FindSolutionFromPath(System.String path)`
  - Finds a .sln this path belongs to, this is pretty much entirely for internal usage to open engine slns
- `static System.String AddonSolutionPath()`
