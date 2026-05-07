# Editor.EnumControlWidget

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.ControlWidget`

## Constructors

- `EnumControlWidget(Sandbox.SerializedProperty property)`

## Properties

- `System.Boolean IsFlagsMode`
  - If true, then this control is operating in flags mode (FlagsAttribute)
- `System.Boolean IsControlActive`
- `System.Boolean IsControlButton`
- `System.Boolean IsControlHovered`
- `System.Boolean SupportsMultiEdit`
- `System.Nullable<System.Single> MenuWidthOverride`

## Methods

### Instance methods

- `virtual System.Void PaintControl()`
- `virtual System.Void StartEditing()`
- `virtual System.Void OnMouseClick(Editor.MouseEvent e)`
- `virtual System.Void OnDoubleClick(Editor.MouseEvent e)`
