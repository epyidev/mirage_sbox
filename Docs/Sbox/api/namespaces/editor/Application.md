# Editor.Application

- **Kind:** static class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Properties

- `static System.Action<Editor.Widget,Editor.MouseEvent> OnWidgetClicked`
  - Called when any widget is clicked. Can set MouseEvent.Accepted to true to prevent the Widget's OnMouseClick from firing.
- `static System.Single DpiScale`
- `static Vector2 CursorPosition`
  - Get/Set cursor position.
- `static Vector2 UnscaledCursorPosition`
  - The cursor position, not scaled for DPI
- `static Vector2 CursorDelta`
  - The cursor delta between this and previous frame.
- `static Vector2 MouseWheelDelta`
  - The mouse wheel delta between this and previous frame
- `static Sandbox.KeyboardModifiers KeyboardModifiers`
  - Returns which keyboard modified keys are held down right at this point.
- `static Sandbox.MouseButtons MouseButtons`
  - Returns the current state of the mouse buttons.
- `static Editor.Widget FocusWidget`
  - The `Editor.Widget` that has the keyboard input focus, or `null`if no widget in this application has the focus.
- `static Editor.Widget HoveredWidget`
  - The Widget that is currently hovered
- `static Editor.EditorSystem Editor`
  - Get the current editor if any. Will return null if we're not in the editor, or there is no active editor session.

## Methods

### Static methods

- `static System.Void SetStyles(System.String style)`
- `static System.Void Spin()`
  - Will process all of the UI events - allowing the UI to stay responsive during a blocking call.
- `static System.Boolean IsKeyDown(Editor.KeyCode code)`
  - Returns whether or not a key is currently being held down.
- `static System.String KeyCodeToString(Editor.KeyCode code)`
  - Converts an editor keycode to a string used by the game
Qt::Key -&gt; WindowsVirtualKey -&gt; ButtonCode_t -&gt; string
