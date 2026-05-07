# Editor.MenuBar

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Widget`

## Constructors

- `MenuBar(Editor.Widget parent)`

## Methods

### Static methods

- `static System.Void RegisterNamed(System.String name, Editor.MenuBar b)`
  - Register a named menubar target. This allows [Menu] to target a specific menubar.

### Instance methods

- `Editor.Option AddOption(System.String path, System.String icon, System.Action action, System.String shortcut)`
- `System.Void AddOption(System.String path, Editor.Option option)`
- `System.Void RemovePath(System.String path)`
- `System.Collections.Generic.List<Editor.Menu> GetPathTo(System.String path)`
- `Editor.Menu FindOrCreateMenu(System.String name)`
- `Editor.Option AddSeparator()`
- `Editor.Menu AddMenu(System.String name)`
- `Editor.Menu AddMenu(System.String icon, System.String name)`
- `System.Void Clear()`
