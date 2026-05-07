# Editor.ListView

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.BaseItemWidget`

## Constructors

- `ListView(Editor.Widget parent)`

## Properties

- `System.Action<System.Object> ItemScrollEnter`
  - Called when an item is scrolled into view.
- `System.Action<System.Object> ItemScrollExit`
  - Called when an item is scrolled out of view.
- `Vector2 ItemSize`
- `Vector2 ItemSpacing`
- `Sandbox.UI.Align ItemAlign`

## Methods

### Instance methods

- `virtual System.Void OnLayoutChanged()`
- `virtual System.Void OnPaint()`
- `virtual System.Boolean SelectMoveRow(System.Int32 positions)`
- `virtual System.Void ScrollTo(System.Object target)`
- `virtual System.Void Rebuild()`
  - Rebuild the scrollbars and layout for the visible items
- `virtual System.Void LayoutScrollbar()`
  - Work out how big the scrollbars need to be and layout the current PVS
- `virtual System.Void LayoutItems()`
