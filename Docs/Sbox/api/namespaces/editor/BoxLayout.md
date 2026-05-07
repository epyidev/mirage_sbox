# Editor.BoxLayout

A widget layout. You can think of it as an invisible box of rows or columns, each one containing a widget, useful for automatic positioning and scaling.

- **Kind:** sealed class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Layout`

## Methods

### Instance methods

- `virtual System.Void AddSpacingCell(System.Single size)`
  - Add a spacing item
- `virtual System.Void AddStretchCell(System.Int32 stretch)`
  - Add a stretch item
- `System.Int32 GetCellStretch(System.Int32 index)`
- `System.Void SetCellStretch(System.Int32 index, System.Int32 stretch)`
- `System.Void SetCellStretch(Editor.Widget widget, System.Int32 stretch)`
- `System.Void SetCellStretch(Editor.Layout layout, System.Int32 stretch)`
- `virtual T Add(T widget, System.Int32 stretch)`
- `virtual Editor.Layout Add(Editor.Layout layout)`
- `virtual Editor.Layout Add(Editor.Layout layout, System.Int32 stretch)`
