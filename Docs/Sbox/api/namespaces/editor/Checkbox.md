# Editor.Checkbox

A generic checkbox widget.

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Widget`

## Constructors

- `Checkbox(Editor.Widget parent)`
- `Checkbox(System.String title, Editor.Widget parent)`
- `Checkbox(System.String title, System.String icon, Editor.Widget parent)`

## Properties

- `System.String Text`
  - The checkbox label.
- `System.Boolean Value`
  - Whether the checkbox is checked or not.
- `Editor.CheckState State`
  - Current state of this checkbox.
- `System.Boolean TriState`
  - Enable the third state, the half checked half not checked state.
Disabled by default
- `System.String Icon`
  - Name of a material icon to be drawn in front of the checkbox label.

## Fields

- `System.Action Clicked`
- `System.Action Pressed`
- `System.Action Released`
- `System.Action Toggled`
- `System.Action<Editor.CheckState> StateChanged`

## Methods

### Instance methods

- `virtual System.Void OnClicked()`
  - Called when checkbox was clicked, on release.
- `virtual System.Void OnPressed()`
  - Called when checkbox was pressed down.
- `virtual System.Void OnReleased()`
  - Called when checkbox was released.
- `virtual System.Void OnToggled()`
  - Called when checkbox gets toggled on or off.
- `virtual System.Void OnStateChanged(Editor.CheckState state)`
  - Called when the `Editor.Checkbox.State` of the checkbox states.
