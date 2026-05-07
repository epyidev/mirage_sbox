# Editor.ControlWidget

A control widget is used to edit the value of a single SerializedProperty.

- **Kind:** abstract class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Widget`

## Constructors

- `ControlWidget(Sandbox.SerializedProperty property)`

## Properties

- `Sandbox.SerializedProperty SerializedProperty`
- `Sandbox.TextFlag CellAlignment`
  - If none, when in a grid, the control will fill the entire cell
- `System.Boolean IsWideMode`
  - If true we prefer to be full inspector width
with the label above us
- `System.Boolean IncludeLabel`
  - If true (default) we'll include a label next to the control
- `System.Boolean IsControlActive`
- `System.Boolean IsControlHovered`
- `System.Boolean IsControlDisabled`
- `System.Boolean IsControlButton`
- `Color Tint`
- `System.Boolean SupportsMultiEdit`
- `System.Int32 ValueHash`

## Fields

- `static Color ControlHighlightPrimary`
- `static Color ControlHighlightSecondary`
- `System.Boolean PaintBackground`

## Methods

### Static methods

- `static Editor.ControlWidget Create(Sandbox.SerializedProperty property)`
- `static Editor.ControlWidget TryCreateGenericObjectControlWidget(Sandbox.SerializedProperty property)`

### Instance methods

- `virtual System.Void StartEditing()`
  - Selects this widget and starts editing. Used when we want to focus on the widget in the
inspector, like when double-clicking on something in a graph editor that maps to this widget.
- `virtual Vector2 MinimumSizeHint()`
- `virtual Vector2 SizeHint()`
- `virtual System.Void OnPaint()`
- `virtual System.Void PaintUnder()`
- `virtual System.Void PaintControl()`
- `virtual System.Void PaintOver()`
- `virtual System.Void Think()`
- `System.Void Prime()`
  - Should get called right after creation
- `System.Void PropertyStartEdit()`
- `System.Void PropertyFinishEdit()`
- `virtual System.Void OnValueChanged()`
- `virtual System.Void OnContextMenu(Editor.ContextMenuEvent e)`
- `virtual System.Void OnLabelContextMenu(Editor.ContextMenu menu)`
  - Called when right clicking a label in a ControlSheet for this widget. This allows
you to add advanced menu items for this widget at the top of the menu, before the default ones.
- `virtual System.String ToClipboardString()`
- `virtual System.Void FromClipboardString(System.String clipboard)`
- `virtual System.Void OnMultipleDifferentValues(System.Boolean state)`
