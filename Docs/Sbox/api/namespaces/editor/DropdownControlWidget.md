# Editor.DropdownControlWidget

Base class for dropdown control widgets with multi-select support.

- **Kind:** abstract class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.ControlWidget`

## Constructors

- `DropdownControlWidget(Sandbox.SerializedProperty property)`

## Properties

- `System.Boolean IsControlActive`
- `System.Boolean IsControlButton`
- `System.Boolean IsControlHovered`
- `System.Boolean IsMultiSelect`

## Fields

- `Editor.PopupWidget _menu`

## Methods

### Instance methods

- `virtual System.Void PaintControl()`
- `virtual System.Void PaintDisplayText(Sandbox.Rect rect, Color color)`
  - Override to paint the display text in the control
- `virtual System.Void StartEditing()`
- `virtual System.Void OnMouseClick(Editor.MouseEvent e)`
- `virtual System.Void OnDoubleClick(Editor.MouseEvent e)`
- `virtual System.Void PopulateMenu(Editor.Widget canvas)`
  - Override to populate the menu with options
- `Editor.Widget AddMenuOption(Editor.Widget canvas, System.String displayName, System.String icon, System.Func<System.Boolean> isSelected, System.Action onSelect)`
