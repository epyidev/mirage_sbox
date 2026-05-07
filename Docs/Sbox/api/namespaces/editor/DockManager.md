# Editor.DockManager

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Widget`

## Constructors

- `DockManager(Editor.Widget parent)`

## Properties

- `System.Action OnLayoutLoaded`
  - Called when the layout state is changed programatically. This is generally called when the default
layout is loaded, or a saved layout is loaded.
- `System.Collections.Generic.IEnumerable<Editor.DockManager.DockInfo> DockTypes`
  - A list of dock types that are registered.
- `System.String State`
  - A JSON string representing the entire state of the dock manager, i.e. position of all the docks, etc.

## Methods

### Instance methods

- `System.Void RegisterDockType(System.String name, System.String icon, System.Func<Editor.Widget> create, System.Boolean deleteOnClose)`
- `System.Void UnregisterDockType(System.String name)`
  - Unregister a dock type.
- `System.Void AddDock(Editor.Widget sibling, Editor.Widget window, Editor.DockArea dockArea, Editor.DockManager.DockProperty properties, System.Single split)`
  - Add a window next (or on top of) to the specified window.
- `System.Boolean IsDockOpen(System.String title)`
  - Whether the given dock-able window is visible or not.
- `System.Boolean IsDockOpen(Editor.Widget widget, System.Boolean includeCookied)`
  - Whether the given dock-able window is visible or not.
- `Editor.Widget GetDockWidget(System.String name)`
  - Get an active, created dock
- `System.Boolean RaiseDock(System.String name)`
  - Raise this dock to the front of any tabs.
- `System.Void RaiseDock(Editor.Widget val)`
  - Raise this dock to the front of any tabs.
- `System.Void SetDockState(System.String name, System.Boolean visible)`
  - Set dock as visible, or hidden, by name.
- `T Create()`
  - Creates a widget by type
- `System.Void Clear()`
  - Clear the known widgets, reset manager to an empty state.
