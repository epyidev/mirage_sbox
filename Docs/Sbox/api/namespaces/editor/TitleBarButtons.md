# Editor.TitleBarButtons

A list of title bar buttons, at the top right of a window.

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Widget`

## Constructors

- `TitleBarButtons()`

## Methods

### Instance methods

- `Editor.Widget AddButton(System.String icon, System.Action onClick)`
  - Adds a button to the title bar.
- `Editor.Widget AddToggleButton(System.String icon, System.Action<System.Boolean> onSet, System.Boolean initialValue)`
- `Editor.Widget AddToggleButton(Editor.Pixmap icon, System.Action<System.Boolean> onSet, System.Boolean initialValue)`
- `Editor.Widget Add(Editor.Widget widget)`
  - Adds a custom widget to the title bar.
