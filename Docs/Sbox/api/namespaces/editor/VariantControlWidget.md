# Editor.VariantControlWidget

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.ControlWidget`

## Constructors

- `VariantControlWidget(Sandbox.SerializedProperty property)`

## Methods

### Static methods

- `static System.Void OpenTypeSelector(Editor.Widget parent, System.Type current, System.Action<System.Type> onChanged)`

### Instance methods

- `virtual System.Void OnPaint()`
  - We don't want to paint anything, let the underlying control do that
- `virtual System.Void OnLabelContextMenu(Editor.ContextMenu menu)`
- `System.Void OpenMenu()`
