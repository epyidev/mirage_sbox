# Editor.AdvancedDropdownWidget.AdvancedDropdownPanel

A single sliding panel with header, scroll area, and item list.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Widget`
- **Declaring type:** `Editor.AdvancedDropdownWidget`

## Constructors

- `AdvancedDropdownPanel(Editor.Widget parent, Editor.AdvancedDropdownWidget owner, System.String title)`

## Properties

- `System.String Title`
- `Editor.Widget CategoryHeader`
- `Editor.AdvancedDropdownItem SourceItem`
  - The item whose children this panel displays. Null for root panel.
- `System.Collections.Generic.List<Editor.Widget> ItemList`
- `Editor.Widget CurrentItem`
- `System.Boolean IsManual`

## Methods

### Instance methods

- `System.Boolean SelectMoveRow(System.Int32 delta)`
- `System.Boolean Enter()`
- `virtual System.Void OnKeyRelease(Editor.KeyEvent e)`
- `Editor.Widget AddEntry(Editor.Widget entry)`
  - Add an entry widget to this panel.
- `System.Void AddStretchCell()`
- `System.Void ClearEntries()`
- `virtual System.Void OnPaint()`
