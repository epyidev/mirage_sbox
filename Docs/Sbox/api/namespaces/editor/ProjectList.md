# Editor.ProjectList

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Constructors

- `ProjectList()`

## Methods

### Instance methods

- `System.Void Refresh()`
- `System.Void SaveList()`
- `System.Collections.Generic.IEnumerable<Sandbox.Project> GetAll()`
- `System.Boolean Remove(Sandbox.Project item)`
  - Remove an item from the list. This doesn't save the changes.
- `Sandbox.Project TryAddFromFile(System.String path)`
  - Tries to add a project from a file. Returns true if it was added, or already existed.
Project list is saved if it was added.
