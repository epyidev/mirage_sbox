# Sandbox.Gizmo.Pressed

Access to the currently pressed path information

- **Kind:** static class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Gizmo`

## Properties

- `static Ray Ray`
  - The ray representing the cursor direction
- `static System.Boolean This`
  - True if the current gizmo scope is pressed
- `static System.Boolean Any`
  - True if any object is currently pressed
- `static Vector2 CursorDelta`
  - The distance the cursor has travelled since press started
- `static Vector2 CursorPosition`
  - The cursor position at the start of the press
- `static System.Boolean IsActive`
  - True if press is active. This generally means that the left mouse button is down

## Methods

### Static methods

- `static System.Void ClearPath()`
