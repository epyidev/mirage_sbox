# Editor.GraphicsItem

- **Kind:** abstract class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Constructors

- `GraphicsItem(Editor.GraphicsItem parent)`

## Properties

- `System.Collections.Generic.IEnumerable<Editor.GraphicsItem> Children`
- `Editor.GraphicsView GraphicsView`
- `Editor.GraphicsItem Parent`
- `System.Boolean IsValid`
- `Vector2 Position`
- `Vector2 ViewPosition`
- `Vector2 Center`
- `Sandbox.Rect LocalRect`
- `Sandbox.Rect SceneRect`
- `System.Single Rotation`
- `System.Single Scale`
- `System.Boolean Movable`
- `System.Boolean ClipChildren`
- `System.Boolean Clip`
- `System.String Tooltip`
- `System.String ToolTip`
- `System.Boolean Selected`
- `System.Boolean Selectable`
- `System.Boolean Focusable`
  - Gets keyboard input
- `System.Boolean HoverEvents`
- `System.Single ZIndex`
- `Sandbox.Rect BoundingRect`
  - The outer bounds of the item as a rectangle; all painting must be restricted to inside an item's bounding rect.
- `Vector2 Size`
- `System.Single Width`
- `System.Single Height`
- `Vector2 HandlePosition`
  - 0,0 means top left, 1,1 means bottom right
- `System.Boolean Hovered`
- `Editor.CursorShape Cursor`

## Methods

### Instance methods

- `System.Void Destroy()`
- `virtual System.Void OnDestroy()`
- `virtual System.Void OnPaint()`
- `virtual System.Void OnMouseReleased(Editor.GraphicsMouseEvent e)`
- `virtual System.Void OnMousePressed(Editor.GraphicsMouseEvent e)`
- `virtual System.Void OnMouseMove(Editor.GraphicsMouseEvent e)`
- `virtual System.Void OnHoverEnter(Editor.GraphicsHoverEvent e)`
- `virtual System.Void OnHoverMove(Editor.GraphicsHoverEvent e)`
- `virtual System.Void OnHoverLeave(Editor.GraphicsHoverEvent e)`
- `System.Void Update()`
- `System.Void PrepareGeometryChange()`
  - Usually called before resizing items so they paint properly.
- `Vector2 ToScene(Vector2 pos)`
- `Vector2 FromScene(Vector2 pos)`
- `Vector2 ToParent(Vector2 pos)`
- `Vector2 FromParent(Vector2 pos)`
- `Vector2 ToItem(Editor.GraphicsItem item, Vector2 pos)`
- `Vector2 FromItem(Editor.GraphicsItem item, Vector2 pos)`
- `virtual System.Void OnPositionChanged()`
- `virtual System.Void OnMoved()`
  - Item has been moved by the user dragging it
- `virtual System.Void OnSelectionChanged()`
- `Sandbox.Bind.Builder Bind(System.String targetName)`
- `virtual System.Void OnKeyPress(Editor.KeyEvent e)`
  - A key has been pressed.
- `virtual System.Void OnKeyRelease(Editor.KeyEvent e)`
  - A key has been released.
- `virtual System.Boolean Contains(Vector2 localPos)`
