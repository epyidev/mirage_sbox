# Editor.AdvancedDropdownItem

A tree node for use with `Editor.AdvancedDropdownWidget`.
Items with children are categories; items without children are selectable leaves.

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Constructors

- `AdvancedDropdownItem()`
- `AdvancedDropdownItem(System.String title, System.String icon, System.Object value)`

## Properties

- `System.String Title`
- `System.String Icon`
- `System.String Description`
- `System.String Tooltip`
- `System.Object Value`
- `System.Action<Sandbox.Rect,System.Single> PaintIcon`
  - Optional custom icon painting. Receives the icon rect and current opacity.
- `System.Collections.Generic.IReadOnlyList<Editor.AdvancedDropdownItem> Children`
- `System.Boolean HasChildren`

## Methods

### Instance methods

- `Editor.AdvancedDropdownItem Add(System.String title, System.String icon, System.Object value)`
  - Add a child item and return it.
- `System.Void Add(Editor.AdvancedDropdownItem item)`
  - Add an existing item as a child.
- `System.Void Clear()`
  - Remove all children.
