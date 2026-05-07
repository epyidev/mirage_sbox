# Editor.Button

A simple button widget.

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Widget`

## Constructors

- `Button(Editor.Widget parent)`
- `Button(System.String title, Editor.Widget parent)`
- `Button(System.String title, System.String icon, Editor.Widget parent)`

## Properties

- `System.String Text`
  - Text on the button.
- `Color Tint`
  - The tint of the button color
- `System.Boolean IsChecked`
  - Whether this button is checked. See `Editor.Button.IsToggle`.
- `System.Boolean IsToggle`
  - Whether this button can be toggled on or off. See `Editor.Button.IsChecked`.
- `System.String Icon`
  - Sets an icon for the button via a filepath.

## Fields

- `System.Action Clicked`
- `System.Action Pressed`
- `System.Action Released`
- `System.Action Toggled`

## Methods

### Instance methods

- `virtual System.Void OnClicked()`
- `virtual System.Void OnPressed()`
- `virtual System.Void OnReleased()`
- `virtual System.Void OnToggled()`
- `System.Void SetIcon(Editor.Pixmap pixmap)`
  - Sets an icon for the button via a raw image.
- `Editor.Pixmap GetIcon()`
- `virtual System.Void OnPaint()`
