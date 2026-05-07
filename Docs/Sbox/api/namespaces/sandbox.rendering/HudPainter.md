# Sandbox.Rendering.HudPainter

2D Drawing functions for a `Sandbox.Rendering.CommandList`.


`HudPainter` provides a set of methods for drawing shapes, textures, and text onto a command list, typically for HUD or UI rendering.

- **Kind:** struct
- **Namespace:** `Sandbox.Rendering`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `HudPainter(Sandbox.Rendering.CommandList commandList)`
  - Initializes a new instance of the `Sandbox.Rendering.HudPainter` struct for the specified `commandList`.
  - `commandList`: The command list to draw to. Must not be null.

## Fields

- `Sandbox.Rendering.CommandList list`
  - The underlying `Sandbox.Rendering.CommandList` used for rendering.

## Methods

### Instance methods

- `System.Void SetBlendMode(Sandbox.BlendMode mode)`
  - Sets the blend mode for subsequent drawing operations.
  - `mode`: The blend mode to use.
- `System.Void SetMatrix(Matrix matrix)`
  - Sets the transformation matrix for subsequent drawing operations.
  - `matrix`: The transformation matrix to apply.
- `System.Void DrawCircle(Vector2 position, Vector2 size, Color color)`
  - Draws a filled circle at the specified position and size.
  - `position`: The center position of the circle.
  - `size`: The size (diameter) of the circle.
  - `color`: The color of the circle.
- `System.Void DrawRect(Sandbox.Rect rect, Color color, Vector4 cornerRadius, Vector4 borderWidth, Color borderColor)`
  - Draws a rectangle with optional corner radius and border.
  - `rect`: The rectangle to draw.
  - `color`: The fill color of the rectangle.
  - `cornerRadius`: The radius for each corner (optional).
  - `borderWidth`: The width of the border for each edge (optional).
  - `borderColor`: The color of the border (optional).
- `System.Void DrawTexture(Sandbox.Texture texture, Sandbox.Rect rect)`
  - Draws a texture in the specified rectangle with a white tint.
  - `texture`: The texture to draw.
  - `rect`: The rectangle to draw the texture in.
- `System.Void DrawTexture(Sandbox.Texture texture, Sandbox.Rect rect, Color tint)`
  - Draws a texture in the specified rectangle with a tint color.
  - `texture`: The texture to draw.
  - `rect`: The rectangle to draw the texture in.
  - `tint`: The tint color to apply to the texture.
- `System.Void DrawText(System.String text, System.Single size, Color color, Vector2 point, Sandbox.TextFlag flags)`
  - Draws text at a 3D point with the specified size, color, and alignment flags.
  - `text`: The text to draw.
  - `size`: The font size.
  - `color`: The color of the text.
  - `point`: The 3D point to draw the text at.
  - `flags`: Text alignment flags (optional).
- `System.Void DrawText(System.String text, System.Single size, Color color, Sandbox.Rect rect, Sandbox.TextFlag flags)`
  - Draws text within a rectangle with the specified size, color, and alignment flags.
  - `text`: The text to draw.
  - `size`: The font size.
  - `color`: The color of the text.
  - `rect`: The rectangle to draw the text in.
  - `flags`: Text alignment flags (optional).
- `Sandbox.Rect DrawText(Sandbox.TextRendering.Scope scope, Vector2 point, Sandbox.TextFlag flags)`
  - Draws text at a 3D point using a prepared `Sandbox.TextRendering.Scope`.
  - `scope`: The text rendering scope.
  - `point`: The 3D point to draw the text at.
  - `flags`: Text alignment flags (optional).
- `Sandbox.Rect DrawText(Sandbox.TextRendering.Scope scope, Sandbox.Rect rect, Sandbox.TextFlag flags)`
  - Draws text within a rectangle using a prepared `Sandbox.TextRendering.Scope`.
  - `scope`: The text rendering scope.
  - `rect`: The rectangle to draw the text in.
  - `flags`: Text alignment flags (optional).
- `System.Void DrawLine(Vector2 a, Vector2 b, System.Single width, Color color, Vector4 corners)`
  - Draws a line between two points with the specified width and color.
  - `a`: The start point of the line.
  - `b`: The end point of the line.
  - `width`: The width of the line.
  - `color`: The color of the line.
  - `corners`: Optional corner flags for line end caps.
