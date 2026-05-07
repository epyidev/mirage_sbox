# Sandbox.UI.Panel.Draw

To be used inside `Sandbox.UI.Panel.OnDraw` to add custom shapes, textures and text to a panel.
These draw calls will be batched together with the panel's CSS-styled content for efficient rendering.
<example>

```

public override void OnDraw()
{
    Draw.Rect( new Rect( 0, 0, 100, 100 ), Color.Red, cornerRadius: 8 );
    Draw.Text( "Hello", new Rect( 10, 10, 80, 20 ), 14, Color.White );
}

```

</example>

- **Kind:** static class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.UI.Panel`

## Methods

### Static methods

- `static System.Void Rect(Sandbox.Rect rect, Color color, System.Single cornerRadius)`
  - Draws a filled rectangle.
  - `rect`: The rectangle to draw, in panel-local coordinates.
  - `color`: Fill color.
  - `cornerRadius`: Uniform corner radius for rounded rectangles. Use the `Sandbox.UI.Panel.Draw.Rect(Sandbox.Rect,Color,Vector4)` overload for per-corner control.
- `static System.Void Rect(Sandbox.Rect rect, Color color, Vector4 cornerRadius)`
  - Draws a filled rectangle with per-corner radius control.
  - `rect`: The rectangle to draw, in panel-local coordinates.
  - `color`: Fill color.
  - `cornerRadius`: Corner radii as (bottom-right, top-right, bottom-left, top-left).
- `static System.Void Circle(Vector2 center, System.Single radius, Color color)`
  - Draws a filled circle.
  - `center`: Center position in panel-local coordinates.
  - `radius`: Circle radius in pixels.
  - `color`: Fill color.
- `static System.Void Texture(Sandbox.Texture texture, Sandbox.Rect rect, System.Nullable<Color> tint)`
- `static System.Void Text(System.String text, Sandbox.Rect rect, System.Single size, Color color, Sandbox.TextFlag flags)`
  - Draws a text string within the given rectangle.
  - `text`: The text to render.
  - `rect`: Bounding rectangle for text layout, in panel-local coordinates.
  - `size`: Font size in pixels.
  - `color`: Text color.
  - `flags`: Text alignment and layout flags. Defaults to `Sandbox.TextFlag.LeftTop`.
- `static System.Void Shadow(Sandbox.Rect rect, Color color, System.Single blur, System.Single spread, Vector2 offset, System.Single cornerRadius, System.Boolean inset)`
  - Draws a box shadow (drop shadow or inset shadow).
  - `rect`: The rectangle to cast the shadow from, in panel-local coordinates.
  - `color`: Shadow color.
  - `blur`: Blur radius in pixels. Higher values produce softer shadows.
  - `spread`: Spread distance in pixels. Positive values expand the shadow, negative values shrink it.
  - `offset`: Shadow offset from the rectangle position.
  - `cornerRadius`: Corner radius to match rounded rectangles.
  - `inset`: If true, draws an inner shadow instead of a drop shadow.
- `static System.Void Outline(Sandbox.Rect rect, Color color, System.Single width, System.Single cornerRadius, System.Single offset)`
  - Draws an outline (stroke) around a rectangle.
  - `rect`: The rectangle to outline, in panel-local coordinates.
  - `color`: Outline color.
  - `width`: Outline thickness in pixels.
  - `cornerRadius`: Corner radius to match rounded rectangles.
  - `offset`: Outline offset. Positive values push the outline outward, negative values pull it inward.
