# Editor.Option

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.QObject`

## Constructors

- `Option(Editor.QObject parent, System.String title, System.String icon, System.Action action)`
- `Option(Editor.QObject parent, System.String title, Editor.Pixmap icon, System.Action action)`
- `Option(System.String title, System.String icon, System.Action action)`

## Properties

- `System.String Text`
  - Text for this option.
- `System.String IconText`
  - Text to display if `Editor.Option.Text` is empty.
- `System.Boolean Checkable`
  - Whether this option is a toggle option. `Editor.Option.Checked`.
- `System.Boolean Checked`
  - Whether this option is toggled/checked. `Editor.Option.Checkable`.
- `System.String Tooltip`
- `System.String ToolTip`
- `System.String StatusText`
- `System.String StatusTip`
- `System.Boolean Enabled`
  - Whether this option can be clicked. Will also be visually different.
- `System.String Shortcut`
- `System.String ShortcutName`
- `System.String Icon`
  - The icon for this option.
- `Editor.Pixmap IconImage`
  - The icon for this option.

## Fields

- `System.Action Triggered`
- `System.Action<System.Boolean> Toggled`
- `System.Func<System.Boolean> FetchCheckedState`
  - A method to get the checked state. Called periodically to update the status

## Methods

### Instance methods

- `virtual System.Void OnTriggered()`
  - Called when this option was clicked..
- `virtual System.Void OnToggled(System.Boolean b)`
  - Called when this option was toggled.
- `System.Void SetIcon(Editor.Pixmap pixmap)`
  - Sets an icon for the option via a raw image.
