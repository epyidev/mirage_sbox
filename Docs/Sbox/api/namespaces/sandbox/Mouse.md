# Sandbox.Mouse

Gives access to mouse position etc

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static Vector2 Velocity`
- `static Vector2 Position`
  - Access to local clients' cursor position, relative to game windows' top left corner.
- `static Vector2 Delta`
  - Change in local clients' cursor position since last frame.
- `static System.String CursorType`
  - Sets the cursor type until another panel stomps this value.
Doesn't affect main menu.
- `static System.Boolean Active`
  - Whether the local clients' cursor is active or not, meaning it can interact with UI elements, etc.
- `static System.Boolean Visible`
  - DEPRECATED. Use Mouse.Visibility instead.
- `static Sandbox.MouseVisibility Visibility`
  - The visibility state of the mouse cursor. Auto will only show the mouse when clickable UI elements are visible.
