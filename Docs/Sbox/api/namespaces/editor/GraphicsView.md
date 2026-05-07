# Editor.GraphicsView

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Widget`

## Constructors

- `GraphicsView(Editor.Widget parent)`

## Properties

- `Sandbox.Rect SceneRect`
- `Sandbox.Rect SelectionRect`
  - All items inside this rect will be selected
- `Vector2 Center`
  - Where in the scene is the view currently centered.
- `Vector2 Scale`
- `System.Single Rotation`
- `System.Collections.Generic.IEnumerable<Editor.GraphicsItem> SelectedItems`
- `System.Single MinZoom`
- `System.Single MaxZoom`
- `System.Collections.Generic.IEnumerable<Editor.GraphicsItem> Items`
- `Editor.ScrollbarMode HorizontalScrollbar`
- `Editor.ScrollbarMode VerticalScrollbar`
- `Editor.GraphicsView.ViewportAnchorType TransformAnchor`
- `System.Action OnSelectionChanged`
- `Editor.GraphicsView.DragTypes DragType`
  - What happens when the user drags the mouse. You generally want to toggle this in
OnMouseDown to switch what happens with different mouse buttons.
- `System.Boolean Antialiasing`
- `System.Boolean TextAntialiasing`
- `System.Boolean BilinearFiltering`

## Methods

### Instance methods

- `System.Boolean Capture(System.String path)`
- `System.Void Zoom(System.Single adjust, Vector2 viewpos)`
- `System.Void Translate(Vector2 delta)`
- `Vector2 ToScene(Vector2 pos)`
- `Sandbox.Rect ToScene(Sandbox.Rect pos)`
- `Vector2 FromScene(Vector2 pos)`
- `Sandbox.Rect FromScene(Sandbox.Rect pos)`
- `System.Void DeleteAllItems()`
- `System.Void CenterOn(Vector2 center)`
- `System.Void FitInView(Sandbox.Rect rect)`
- `System.Void SetBackgroundImage(System.String image)`
- `System.Void SetBackgroundImage(Editor.Pixmap image)`
- `Editor.GraphicsItem GetItemAt(Vector2 scenePosition)`
- `System.Void Add(Editor.GraphicsItem t)`
- `Editor.GraphicsWidget Add(Editor.Widget t)`
