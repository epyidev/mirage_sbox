# Sandbox.UI.MousePanelEvent

Mouse related `Sandbox.UI.PanelEvent`.

- **Kind:** class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.UI.PanelEvent`

## Constructors

- `MousePanelEvent(System.String event_name, Sandbox.UI.Panel active, System.String button)`

## Properties

- `Sandbox.MouseButtons MouseButton`
  - Which button triggered the event, as a `Sandbox.MouseButtons` enum.

## Fields

- `Vector2 LocalPosition`
  - Position of the cursor relative to the panel's top left corner at the time the event was triggered.
- `System.String Button`
  - Which button triggered the event, in string form.
