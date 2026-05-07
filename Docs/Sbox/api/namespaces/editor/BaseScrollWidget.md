# Editor.BaseScrollWidget

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Frame`

## Constructors

- `BaseScrollWidget(Editor.Widget parent)`

## Properties

- `Editor.ScrollBar VerticalScrollbar`
  - The vertical scroll bar.
- `Editor.ScrollBar HorizontalScrollbar`
  - The horizontal scroll bar.
- `System.Boolean SmoothScrolling`
- `Editor.ScrollbarMode HorizontalScrollbarMode`
  - `Editor.BaseScrollWidget.HorizontalScrollbar` mode.
- `Editor.ScrollbarMode VerticalScrollbarMode`
  - `Editor.BaseScrollWidget.VerticalScrollbar` mode.
- `System.Single SmoothScrollTarget`
  - The smooth scrolling wants to move by this amount

## Methods

### Instance methods

- `virtual System.Void Update()`
- `virtual System.Void OnScrollChanged()`
  - Called when the scroll position has changed.
- `virtual System.Void OnMouseWheel(Editor.WheelEvent e)`
- `virtual System.Void OnKeyPress(Editor.KeyEvent e)`
- `virtual System.Void ScrollingFrame()`
