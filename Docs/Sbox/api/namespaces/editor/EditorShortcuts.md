# Editor.EditorShortcuts

- **Kind:** static class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Properties

- `static System.Boolean AllowShortcuts`
- `static System.Boolean PassShortcut`
  - Set this to true in a shortcut method to indicate the shortcut should not be consumed,
allowing other shortcuts with the same key binding to be tried.

## Fields

- `static System.Collections.Generic.List<Editor.EditorShortcuts.Entry> Entries`

## Methods

### Static methods

- `static System.String GetKeys(System.String identifier)`
  - Returns the keybind for a given identifier
  - `identifier`: The identifier of the shortcut
- `static System.String GetDisplayKeys(System.String identifier)`
  - Returns the pretty key hint for a given identifier
  - `identifier`: The identifier of the shortcut
- `static System.String GetDefaultKeys(System.String identifier)`
  - Returns the default keybind for a given identifier
  - `identifier`: The identifier of the shortcut
- `static System.Boolean IsDown(System.String identifier)`
  - Returns whether a given shortcut is currently being held down
  - `identifier`: The identifier of the shortcut
