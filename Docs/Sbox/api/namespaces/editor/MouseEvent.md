# Editor.MouseEvent

Information about a `Editor.Widget`s mouse event.

- **Kind:** struct
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Properties

- `System.Boolean LeftMouseButton`
  - Whether the event was triggered by the left mouse button.
- `System.Boolean RightMouseButton`
  - Whether the event was triggered by the left mouse button.
- `System.Boolean MiddleMouseButton`
  - Whether the event was triggered by the left mouse button.
- `Sandbox.MouseButtons ButtonState`
  - The current mouse button state.
- `Sandbox.MouseButtons Button`
  - The mouse button that triggered the event.
- `Vector2 LocalPosition`
  - Position of the mouse cursor relative to the widgets top left corner.
- `Vector2 WindowPosition`
  - Position of the mouse cursor relative to the top left corner of the window the widget belongs to.
- `Vector2 ScreenPosition`
  - Absolute position of the mouse cursor on the screen.
- `Sandbox.KeyboardModifiers KeyboardModifiers`
  - The keyboard modifier keys that were held down at the moment the event triggered.
- `System.Boolean HasShift`
  - Whether `Shift` key was being held down at the time of the event.
- `System.Boolean HasCtrl`
  - Whether `Control` key was being held down at the time of the event.
- `System.Boolean HasAlt`
  - Whether `Alt` key was being held down at the time of the event.
- `System.Boolean Accepted`
  - Whether this event should be propagated to parent widgets (`false`) or not (`true`).
- `System.Boolean IsDoubleClick`
  - Whether this mouse event was a double click.
