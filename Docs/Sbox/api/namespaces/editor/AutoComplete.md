# Editor.AutoComplete

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Menu`

## Constructors

- `AutoComplete(Editor.Widget parent)`

## Properties

- `System.Boolean HasAutocompleteOptions`
- `System.Int32 MinimumLength`
- `Vector2 OpenOffset`

## Fields

- `System.Action<Editor.Menu,System.String> OnBuildOptions`
  - The text has changed - fill in the options
- `System.Action<System.String> OnOptionSelected`
  - You should hook this up to change the text on your control

## Methods

### Instance methods

- `System.Void OnAutoComplete(System.String newPrefix, Vector2 screenPosition)`
- `virtual Editor.Option AddOption(System.String name, System.String icon, System.Action action, System.String shortcut)`
  - Add an option for this autocomplete
- `System.Void OpenAbove(Vector2 position)`
  - Open above this position
- `System.Void OnParentKeyPress(Editor.KeyEvent e)`
  - You should call this from the parent when a key is pressed. Will forward
the appropriate keys to us and accept the event.
- `System.Void OnParentBlur()`
  - Call this when the widget that spawns this blurs, so we can hide ourself
- `System.Void OnGlobalMousePressed()`
  - Called when the mouse is pressed. Will hide this window if we clicked on anything
except ourselves or our parent control.
