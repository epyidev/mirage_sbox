# Editor.Widget.DragEvent

Information about a widget drag and drop event.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Tools`
- **Declaring type:** `Editor.Widget`

## Constructors

- `DragEvent()`

## Properties

- `Vector2 LocalPosition`
  - Cursor position, local to this widget.
- `Editor.DragData Data`
  - The drag data.
- `Sandbox.KeyboardModifiers KeyboardModifiers`
  - The keyboard modifier keys that were held down at the moment the event triggered.
- `System.Boolean HasShift`
  - Whether `Shift` key was being held down at the time of the event.
- `System.Boolean HasCtrl`
  - Whether `Control` key was being held down at the time of the event.
- `System.Boolean HasAlt`
  - Whether `Alt` key was being held down at the time of the event.
- `Editor.DropAction Action`
  - Set this to what action will be (or was) performed.
