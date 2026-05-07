# Sandbox.UI.Construct.PanelCreator

Used for `Sandbox.UI.Panel.Add` for quick panel creation with certain settings. Other panels types are added via extension methods.

- **Kind:** struct
- **Namespace:** `Sandbox.UI.Construct`
- **Assembly:** `Sandbox.Engine`

## Fields

- `Sandbox.UI.Panel panel`
  - The panel to add children to.

## Methods

### Instance methods

- `Sandbox.UI.Panel Panel()`
  - Add a new blank panel as a child.
  - returns: The crated panel.
- `Sandbox.UI.Panel Panel(System.String classname)`
  - Add a new blank panel with given CSS classes as a child.
  - returns: The crated panel.
