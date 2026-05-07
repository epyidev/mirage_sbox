# Sandbox.Screen

Access screen dimension etc.

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static Vector2 Size`
  - The total size of the game screen
- `static System.Single Width`
  - The width of the game screen. Equal to Screen.x
- `static System.Single Height`
  - The height of the game screen. Equal to Screen.y
- `static System.Single Aspect`
  - The aspect ratio of the screen. Equal to Width/Height
- `static System.Single DesktopScale`
  - The desktop's dpi scale on the current monitor.

## Methods

### Static methods

- `static System.Single CreateVerticalFieldOfView(System.Single fieldOfView)`
  - Converts a vertical field of view to a horizontal field of view based on the screen aspect ratio.
- `static System.Single CreateVerticalFieldOfView(System.Single fieldOfView, System.Single aspectRatio)`
  - Converts a vertical field of view to a horizontal field of view based on the given aspect ratio.
