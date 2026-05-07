# Sandbox.UI.BaseVirtualPanel

Base class for virtualized, scrollable panels that only create item panels when visible.

- **Kind:** abstract class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.UI.Panel`

## Constructors

- `BaseVirtualPanel()`
  - Initializes the base virtual panel with default styles.

## Properties

- `System.Boolean NeedsRebuild`
  - When true, forces a layout rebuild on the next `Sandbox.UI.BaseVirtualPanel.Tick`.
- `Microsoft.AspNetCore.Components.RenderFragment<System.Object> Item`
  - Template used to render an item into a cell panel.
- `System.Action<Sandbox.UI.Panel,System.Object> OnCreateCell`
  - Called when a cell is created. Allows you to fill the cell in
- `System.Action OnLastCell`
  - Called when the last cell has been viewed. This allows you to view more.
- `System.Collections.Generic.IEnumerable<System.Object> Items`
  - Replaces the current items. Only triggers a rebuild if the sequence is actually different.
When set to an IList (like List&lt;T&gt;), changes to the source list will be automatically detected.
- `System.Int32 ItemCount`
  - Gets the number of items in the panel.

## Fields

- `System.Collections.Generic.Dictionary<System.Int32,System.Object> _cellData`
- `System.Collections.Generic.Dictionary<System.Int32,Sandbox.UI.Panel> _created`
- `System.Collections.Generic.List<System.Int32> _removals`
- `System.Collections.Generic.List<System.Object> _items`
- `System.Boolean _lastCellCreated`

## Methods

### Instance methods

- `System.Void AddItem(System.Object item)`
  - Adds a single item and marks the panel for rebuild.
  - `item`: The item to append.
- `System.Void AddItems(System.Collections.Generic.IEnumerable<System.Object> items)`
- `System.Boolean RemoveItem(System.Object item)`
  - Removes the first occurrence of a specific item and marks the panel for rebuild.
  - `item`: The item to remove.
  - returns: True if item was found and removed; otherwise false.
- `System.Void RemoveAt(System.Int32 index)`
  - Removes the item at the specified index and marks the panel for rebuild.
  - `index`: The zero-based index of the item to remove.
- `System.Void InsertItem(System.Int32 index, System.Object item)`
  - Inserts an item at the specified index and marks the panel for rebuild.
  - `index`: The zero-based index at which item should be inserted.
  - `item`: The item to insert.
- `System.Void Clear()`
  - Clears all items and destroys created panels.
- `virtual System.Void Tick()`
  - Per-frame update: adjusts spacing from CSS, updates layout, creates/destroys visible panels.
- `virtual System.Void FinalLayoutChildren(Vector2 offset)`
  - Final layout pass for child panels and scroll bounds.
  - `offset`: Layout offset.
- `System.Boolean HasData(System.Int32 i)`
  - Returns true if `i` is a valid item index.
  - `i`: Item index.
  - returns: True if within bounds; otherwise false.
- `System.Void SetItems(System.Collections.Generic.IEnumerable<System.Object> enumerable)`
- `virtual System.Void UpdateLayoutSpacing(Vector2 spacing)`
  - Updates the layout spacing based on CSS gaps.
  - `spacing`: The spacing vector from CSS.
- `virtual System.Boolean UpdateLayout()`
  - Updates the layout and returns true if the layout changed.
  - returns: True if layout was updated; otherwise false.
- `virtual System.Void GetVisibleRange(System.Int32 first, System.Int32 pastEnd)`
  - Gets the range of visible item indices.
  - `first`: First visible index (inclusive).
  - `pastEnd`: Past-the-end index (exclusive).
- `virtual System.Void PositionPanel(System.Int32 index, Sandbox.UI.Panel panel)`
  - Positions a panel at the specified index.
  - `index`: Item index.
  - `panel`: Panel to position.
- `virtual System.Single GetTotalHeight(System.Int32 itemCount)`
  - Gets the total height needed to display the specified number of items.
  - `itemCount`: Number of items.
  - returns: Total height in layout units.
