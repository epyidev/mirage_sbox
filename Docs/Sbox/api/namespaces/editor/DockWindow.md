# Editor.DockWindow

A window that is built from docking windows

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Window`

## Constructors

- `DockWindow()`

## Properties

- `Editor.DockManager DockManager`
  - The dock manager for this window, that is automatically created.

## Methods

### Instance methods

- `virtual System.Void RestoreDefaultDockLayout()`
  - Override to apply a default layout to your window. This is called automatically from
RestoreFromStateCookie if there is no cookie set.
- `virtual System.Void RestoreFromStateCookie()`
- `virtual System.Void SaveToStateCookie()`
- `System.Void CreateDynamicViewMenu(Editor.Menu menu)`
  - Create a viewmenu dynamically, with common options
