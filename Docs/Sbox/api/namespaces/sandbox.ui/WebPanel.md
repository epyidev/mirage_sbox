# Sandbox.UI.WebPanel

A panel that displays an interactive web page.

- **Kind:** class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.UI.Panel`

## Constructors

- `WebPanel()`

## Properties

- `Sandbox.WebSurface Surface`
  - Access to the HTML surface to change URL, etc.
- `System.String Url`

## Methods

### Instance methods

- `virtual System.Void OnFocus(Sandbox.UI.PanelEvent e)`
- `virtual System.Void OnBlur(Sandbox.UI.PanelEvent e)`
- `virtual System.Void OnMouseWheel(Vector2 value)`
- `virtual System.Void OnMouseDown(Sandbox.UI.MousePanelEvent e)`
- `virtual System.Void OnMouseUp(Sandbox.UI.MousePanelEvent e)`
- `virtual System.Void OnKeyTyped(System.Char k)`
- `virtual System.Void OnButtonEvent(Sandbox.UI.ButtonEvent e)`
- `virtual System.Void OnLayout(Sandbox.Rect layoutRect)`
- `virtual System.Void OnMouseMove(Sandbox.UI.MousePanelEvent e)`
- `virtual System.Void OnDeleted()`
