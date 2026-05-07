# Editor.DockManager.DockInfo

Description of a dock that is available to create by the backend.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Tools`
- **Declaring type:** `Editor.DockManager`

## Constructors

- `DockInfo()`

## Properties

- `System.String Title`
  - This is what the dock will be shown as in the menu - but also what it will be referenced as internally.
- `System.String Icon`
  - Icon to show in the menu.
- `System.Func<Editor.Widget> CreateAction`
  - Called when the window wants to create this dock but it doesn't exist.
- `System.Boolean DeleteOnClose`
  - If true we'll delete the widget when it's closed. Otherwise it'll just be hidden.
