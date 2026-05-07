# Editor.ToolRender

Renders basic stuff for tool views

- **Kind:** static class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Properties

- `static System.Boolean IsActiveView`

## Methods

### Static methods

- `static System.Void DrawScreenText(System.String text, Vector2 pos, Color color)`
- `static System.Void DrawWorldSpaceText(System.String text, Vector3 pos, Vector2 pixelOffset2D, Color color, System.Single minZoomLevelToRender)`
- `static System.Void DrawLine(Vector3 start, Vector3 end, Color startColor, Color endColor)`
- `static System.Void DrawLine(Vector3 start, Vector3 end, Color color)`
- `static System.Void DrawBox(Vector3 mins, Vector3 maxs, Color color)`
- `static System.Void Draw2DRectangleFilled(Vector2 topLeft, Vector2 bottomRight, Color color)`
- `static System.Void Draw2DRectangleOutlined(Vector2 topLeft, Vector2 bottomRight, Color color)`
- `static System.Void Draw2DCircle(Vector2 center, System.Single radius, System.Int32 segments, Color color)`
- `static System.Void Draw2DCross(Vector2 topLeft, Vector2 bottomRight, Color color)`
- `static System.Void Draw2DRectangleTextured(Vector2 topLeft, Vector2 bottomRight, Sandbox.Texture texture, System.Boolean alpha, System.Boolean srgb)`
