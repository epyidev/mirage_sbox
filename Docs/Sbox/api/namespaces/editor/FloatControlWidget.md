# Editor.FloatControlWidget

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.StringControlWidget`

## Constructors

- `FloatControlWidget(Sandbox.SerializedProperty property)`

## Properties

- `Color HighlightColor`
- `System.String Icon`
- `System.String Label`
- `System.Action<Sandbox.Rect,System.Single> SliderPaint`
- `System.Boolean HasRange`
  - If true we can draw a slider
- `Vector2 Range`
  - The range, min and max
- `System.Single RangeStep`
  - The step size between range
- `System.Boolean RangeClamped`
  - True if the range is clamped between min and max

## Methods

### Instance methods

- `System.Void MakeRanged(Vector2 range, System.Single step, System.Boolean clamped, System.Boolean slider)`
- `virtual System.Void DoLayout()`
- `virtual System.String ValueToString()`
- `virtual System.Object StringToValue(System.String text)`
- `virtual System.Void PaintSlider(Sandbox.Rect rect, System.Single pos)`
- `virtual System.Void PaintControl()`
- `virtual System.Void OnMousePress(Editor.MouseEvent e)`
- `virtual System.Void OnMouseReleased(Editor.MouseEvent e)`
- `virtual System.Void OnDragValue(System.Decimal add)`
- `virtual System.Void OnMouseMove(Editor.MouseEvent e)`
- `virtual System.Void OnValueChanged()`
- `virtual System.Void OnKeyPress(Editor.KeyEvent e)`
- `virtual System.Void OnKeyRelease(Editor.KeyEvent e)`
