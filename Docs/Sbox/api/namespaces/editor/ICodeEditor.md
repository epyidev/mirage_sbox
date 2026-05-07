# Editor.ICodeEditor

Interface for editors to open code files.
Any class that implements this interface is automatically added to the list.
An editor is only enabled if `Editor.ICodeEditor.IsInstalled` returns true.
            
Decorate your implementation with a `TitleAttribute`.

- **Kind:** interface
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Methods

### Instance methods

- `virtual System.Void OpenFile(System.String path, System.Nullable<System.Int32> line, System.Nullable<System.Int32> column)`
- `virtual System.Void OpenSolution()`
  - Open the solution of all sandbox projects
- `virtual System.Void OpenAddon(Sandbox.Project addon)`
  - Open given addon in the editor.
- `virtual System.Boolean IsInstalled()`
  - Whether or not this editor is installed.
