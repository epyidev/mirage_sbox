# Editor.IconButton

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Widget`

## Constructors

- `IconButton(System.String icon, System.Action onClick, Editor.Widget parent)`

## Properties

- `System.String Icon`
- `System.Action OnClick`
- `System.Single IconSize`
- `Color Background`
- `Color Foreground`
- `Color BackgroundActive`
- `Color ForegroundActive`
- `System.Boolean IsToggle`
  - If true we will toggle IsActive automatically
- `System.Boolean IsActive`
  - If IsToggle is true, this is toggled on press
- `System.Action<System.Boolean> OnToggled`

## Methods

### Instance methods

- `virtual Vector2 SizeHint()`
- `virtual System.Void OnMouseClick(Editor.MouseEvent e)`
- `virtual System.Void OnPaint()`
