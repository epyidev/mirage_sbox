# Editor.Paint

- **Kind:** static class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Properties

- `static Sandbox.Rect LocalRect`
- `static System.Boolean Antialiasing`
- `static System.Boolean TextAntialiasing`
- `static System.Boolean BilinearFiltering`
- `static Color Pen`
- `static System.Single PenSize`
- `static Editor.PenStyle PenStyle`
- `static System.Boolean HasSelected`
- `static System.Boolean HasMouseOver`
- `static System.Boolean HasPressed`
- `static System.Boolean HasFocus`
- `static System.Boolean HasEnabled`
- `static Editor.RenderMode RenderMode`

## Methods

### Static methods

- `static System.Void Translate(Vector2 tx)`
- `static System.Void Scale(System.Single x, System.Single y)`
- `static System.Void Rotate(System.Single scale)`
- `static System.Void Rotate(System.Single scale, Vector2 center)`
- `static System.Void ResetTransform()`
- `static System.Void DrawRect(Sandbox.Rect rect, System.Single borderRadius)`
- `static System.Void DrawRect(Sandbox.Rect rect)`
- `static System.Void DrawCircle(Sandbox.Rect rect)`
- `static System.Void DrawCircle(Vector2 position, Vector2 scale)`
- `static System.Void DrawArc(Vector2 center, Vector2 radius, System.Single angle, System.Single angleSize)`
  - Draws an arc (line). Angles are clockwise, 0 is north.
  - `center`: The center of the circle
  - `radius`: The radius of the circle
  - `angle`: The center of the arc, in degrees
  - `angleSize`: The size of the arc, in degrees
- `static System.Void DrawPie(Vector2 center, Vector2 radius, System.Single angle, System.Single angleSize)`
  - Draws a pie. Angles are clockwise, 0 is north.
  - `center`: The center of the circle
  - `radius`: The radius of the circle
  - `angle`: The center of the pie, in degrees
  - `angleSize`: The size of the pie, in degrees
- `static System.Void DrawSquare(Vector2 position, Vector2 scale)`
- `static System.Void DrawPolygon(System.Collections.Generic.IEnumerable<Vector2> points)`
- `static System.Void DrawLine(System.Collections.Generic.IEnumerable<Vector2> points)`
- `static System.Void DrawPoints(System.Collections.Generic.IEnumerable<Vector2> points)`
- `static System.Void DrawPolygon(Vector2[] points)`
- `static System.Void DrawArrow(Vector2 p1, Vector2 p2, System.Single width)`
- `static Sandbox.Rect DrawText(Vector2 position, System.String text)`
- `static System.Void DrawLine(Vector2 from, Vector2 to)`
- `static Sandbox.Rect DrawText(Sandbox.Rect position, System.String text, Sandbox.TextFlag flags)`
- `static System.String GetElidedText(System.String text, System.Single width, Editor.ElideMode mode, Sandbox.TextFlag flags)`
  - Adds required ellipses to a string if it doesn't fit within the width
- `static Sandbox.Rect MeasureText(Sandbox.Rect position, System.String text, Sandbox.TextFlag flags)`
- `static Vector2 MeasureText(System.String text)`
- `static System.Void SetFont(System.String name, System.Single size, System.Int32 weight, System.Boolean italic, System.Boolean sizeInPixels)`
- `static System.Void SetDefaultFont(System.Single size, System.Int32 weight, System.Boolean italic, System.Boolean sizeInPixels)`
- `static System.Void SetHeadingFont(System.Single size, System.Int32 weight, System.Boolean italic, System.Boolean sizeInPixels)`
- `static System.Void ClearPen()`
- `static System.Void ClearBrush()`
- `static System.Void SetFont(Sandbox.UI.Styles style)`
  - Set the pen and font style from a style
- `static System.Void Rect(Sandbox.UI.Styles styles, Sandbox.Rect rect)`
  - Draw a rectangle using the background of a style
- `static System.Void SetPen(Color color, System.Single size, Editor.PenStyle style)`
- `static System.Void SetBrush(Color color)`
- `static System.Void SetBrushAndPen(Color brushColor, Color penColor, System.Single penSize, Editor.PenStyle style)`
- `static System.Void SetBrushAndPen(Color brushColor)`
- `static System.Void SetBrushLinear(Vector2 a_pos, Vector2 b_pos, Color a_color, Color b_color)`
- `static System.Void SetBrushRadial(Vector2 center, System.Single radius, Color a_color, Color b_color)`
- `static System.Void SetBrushRadial(Vector2 center, System.Single radius, System.Single a, Color a_color, System.Single b, Color b_color)`
- `static Editor.Pixmap LoadImage(System.String filename)`
- `static Editor.Pixmap LoadImage(System.String filename, System.Int32 x, System.Int32 y)`
- `static System.Void SetBrush(System.String image)`
- `static System.Void SetBrush(Editor.Pixmap pixmap)`
- `static System.Void SetFlags(System.Boolean selected, System.Boolean mouseOver, System.Boolean pressed, System.Boolean focused, System.Boolean enabled)`
- `static Sandbox.Rect DrawIcon(Sandbox.Rect rect, System.String iconName, System.Single pixelHeight, Sandbox.TextFlag alignment)`
- `static System.Void Draw(Sandbox.Rect r, Editor.Pixmap pixmap, System.Single alpha, System.Single borderRadius)`
- `static System.Void Draw(Sandbox.Rect r, System.String image, System.Single alpha, System.Single borderRadius)`
- `static System.IDisposable ToPixmap(Editor.Pixmap pixmap)`
- `static Sandbox.Rect DrawTextBox(Sandbox.Rect position, System.String text, Color textColor, Sandbox.UI.Margin padding, System.Single borderRadius, Sandbox.TextFlag flag)`
