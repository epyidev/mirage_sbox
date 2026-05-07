# Editor.GridLayout

A widget layout. You can think of it as an invisible box of rows or columns, each one containing a widget, useful for automatic positioning and scaling.

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Layout`

## Constructors

- `GridLayout()`

## Properties

- `System.Single HorizontalSpacing`
- `System.Single VerticalSpacing`

## Methods

### Instance methods

- `virtual T Add(T widget)`
- `T AddCell(System.Int32 x, System.Int32 y, T widget, System.Int32 xSpan, System.Int32 ySpan, Sandbox.TextFlag alignment)`
- `virtual Editor.Layout Add(Editor.Layout layout)`
- `virtual Editor.Layout Add(Editor.Layout layout, System.Int32 stretch)`
- `Editor.Layout AddCell(System.Int32 x, System.Int32 y, Editor.Layout layout, System.Int32 xSpan, System.Int32 ySpan, Sandbox.TextFlag alignment)`
- `System.Void SetRowStretch(System.Single[] values)`
- `System.Void SetColumnStretch(System.Single[] values)`
- `System.Void SetMinimumRowHeight(System.Int32 row, System.Int32 height)`
- `System.Void SetMinimumColumnWidth(System.Int32 column, System.Int32 width)`
- `Sandbox.Rect GetCellRect(System.Int32 x, System.Int32 y)`
