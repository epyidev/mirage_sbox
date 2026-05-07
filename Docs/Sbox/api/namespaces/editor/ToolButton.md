# Editor.ToolButton

A button that shows as an icon and tries to keep itself square.

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Widget`

## Constructors

- `ToolButton(System.String name, System.String icon, Editor.Widget parent)`

## Properties

- `System.String IconChecked`
  - Icon to display when the `Editor.ToolButton.Checked` is `true`.
- `System.String Icon`
  - Icon for the tool button.
- `System.Boolean IsToggle`
  - Whether the button is toggle-able or not.
- `System.Boolean Checked`
  - Whether the tool button is currently checked or not.

## Methods

### Instance methods

- `virtual System.Void OnMousePress(Editor.MouseEvent e)`
- `virtual System.Void DoLayout()`
- `virtual System.Void OnPaint()`
