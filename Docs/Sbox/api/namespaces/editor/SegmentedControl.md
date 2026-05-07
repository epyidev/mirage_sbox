# Editor.SegmentedControl

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Widget`

## Constructors

- `SegmentedControl(Editor.Widget parent)`

## Properties

- `System.Int32 SelectedIndex`
- `System.String Selected`
- `System.Boolean ShowText`

## Fields

- `System.Action<System.String> OnSelectedChanged`

## Methods

### Instance methods

- `virtual System.Void DoLayout()`
- `System.Void AddOption(System.String name, System.String icon, System.Nullable<System.Int32> count)`
- `System.Boolean HasOption(System.String name)`
- `virtual System.Void OnPaint()`
