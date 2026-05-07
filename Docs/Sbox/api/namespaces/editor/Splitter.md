# Editor.Splitter

Split frame, allows dragging to resize panels

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Frame`

## Constructors

- `Splitter(Editor.Widget parent)`

## Properties

- `System.Boolean IsHorizontal`
- `System.Boolean IsVertical`
- `System.Boolean OpaqueResize`
- `System.Int32 HandleWidth`

## Methods

### Instance methods

- `System.Void AddWidget(Editor.Widget w)`
- `System.String SaveState()`
- `System.Void RestoreState(System.String state)`
- `System.Void SetStretch(System.Int32 cell, System.Int32 stretch)`
- `System.Void SetCollapsible(System.Int32 index, System.Boolean collapsible)`
