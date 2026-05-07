# Editor.EditorUtility.Mounting

- **Kind:** static class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Tools`
- **Declaring type:** `Editor.EditorUtility`

## Methods

### Static methods

- `static Sandbox.Mounting.BaseGameMount Get(System.String name)`
  - Get the mount
- `static System.Threading.Tasks.Task SetMounted(System.String name, System.Boolean state)`
  - Set a mount state. This state will be saved in the project, and your game will require it if you publish it.
- `static System.Threading.Tasks.Task Refresh(System.String name)`
  - Flush this source to force a refresh. Unmount and re-mount, updating and getting a list of all the new files.
This is used during development to force an update of the files, so you don't have to restart the editor.
