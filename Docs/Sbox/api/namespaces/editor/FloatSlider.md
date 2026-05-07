# Editor.FloatSlider

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Widget`

## Constructors

- `FloatSlider(Editor.Widget parent)`

## Properties

- `System.Single Minimum`
- `System.Single Maximum`
- `System.Action OnValueEdited`
- `Color HighlightColor`
- `System.Action<Sandbox.Rect,System.Single> SliderPaint`
- `System.Action EditingStarted`
- `System.Action EditingFinished`
- `System.Single Value`
- `System.Single DeltaValue`
- `System.Single Step`

## Methods

### Instance methods

- `virtual System.Void OnMouseEnter()`
- `virtual System.Void OnMouseLeave()`
- `virtual System.Void OnPaint()`
- `virtual System.Void OnMousePress(Editor.MouseEvent e)`
- `virtual System.Void OnMouseMove(Editor.MouseEvent e)`
- `virtual System.Void OnMouseReleased(Editor.MouseEvent e)`
