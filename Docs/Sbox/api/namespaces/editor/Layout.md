# Editor.Layout

- **Kind:** abstract class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.QObject`

## Properties

- `System.Single Spacing`
  - The amount of space between items
- `Editor.SizeConstraint SizeConstraint`
  - How the layout should resize the owning widget
- `System.Boolean Enabled`
  - An enabled layout adjusts dynamically to changes; a disabled layout acts as if it did not exist.
- `Sandbox.TextFlag Alignment`
  - An enabled layout adjusts dynamically to changes; a disabled layout acts as if it did not exist.
- `Sandbox.Rect OuterRect`
  - The rect of this layout including margins
- `Sandbox.Rect InnerRect`
  - The rect of this layout excluding margins
- `Sandbox.UI.Margin Margin`
  - The amount of space to leave free around the outside of the layout

## Methods

### Static methods

- `static Editor.Layout Row(System.Boolean reversed)`
- `static Editor.Layout Column(System.Boolean reversed)`
- `static Editor.GridLayout Grid()`
- `static Editor.Layout Flow()`

### Instance methods

- `System.Void Clear(System.Boolean deleteWidgets)`
  - Remove all widgets from this layout, without deleting them outright.
  - `deleteWidgets`: Also delete all the widgets.
- `virtual Editor.Layout Add(Editor.Layout layout)`
- `virtual Editor.Layout Add(Editor.Layout layout, System.Int32 stretch)`
- `virtual T AddLayout(T layout, System.Int32 stretch)`
- `virtual T Add(T widget)`
- `virtual T Add(T widget, System.Int32 stretch)`
- `Editor.Layout AddFlow(System.Int32 stretch)`
- `Editor.Layout AddRow(System.Int32 stretch, System.Boolean reversed)`
- `Editor.Layout AddColumn(System.Int32 stretch, System.Boolean reversed)`
- `virtual System.Void AddSpacingCell(System.Single size)`
  - Add a spacing item
- `virtual System.Void AddStretchCell(System.Int32 stretch)`
  - Add a stretch item
- `Editor.Separator AddSeparator(System.Boolean light)`
  - Adds a 1 pixel line
- `Editor.Separator AddSeparator(System.Single size, Color color)`
  - Adds a line
