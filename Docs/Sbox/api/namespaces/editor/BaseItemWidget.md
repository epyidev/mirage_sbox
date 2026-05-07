# Editor.BaseItemWidget

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.BaseScrollWidget`

## Constructors

- `BaseItemWidget(Editor.Widget parent)`

## Properties

- `System.Action<System.Object> ItemClicked`
  - Called when an item is clicked.
- `System.Action<System.Object> ItemSelected`
  - Called when an item is selected.
- `System.Action<System.Object> ItemDeselected`
  - Called when an item is no longer selected.
- `System.Action<System.Object> ItemHoverEnter`
  - Called when an item is hovered by the user's cursor.
- `System.Action<System.Object> ItemHoverLeave`
  - Called when an item is no longer hovered by the user's cursor.
- `System.Action<System.Object> ItemContextMenu`
  - Called when an item is right clicked.
- `System.Action<System.Object> ItemActivated`
  - Called when an item is double left clicked.
- `System.Action<Editor.VirtualWidget> ItemPaint`
  - Used to overwrite an item's style
- `System.Func<System.Object,System.Boolean> ItemDrag`
  - Called to see whether or not we can drag a specific item.
- `System.Func<System.Object> SelectionOverride`
  - Can override an item's selection here.
- `System.Action BodyContextMenu`
  - Called when right clicking on the item's parent.
- `System.Action<System.Object[]> OnBeforeSelection`
  - Called before selection is changed on selection. When multiple items are affected this will only be called once.
- `System.Action<System.Object[]> OnBeforeDeselection`
  - Called before selection is changed on deselection. When multiple items are affected this will only be called once.
- `System.Action<System.Object[]> ItemsSelected`
  - Multiple items have been selected
- `System.Action<System.Object[]> ItemsDeselected`
  - Multiple items have been deselected
- `System.Action<System.Object[]> OnSelectionChanged`
  - Called when selection has changed. When multiple items are affected this will only be called once.
- `System.Boolean ToggleSelect`
  - If set, selecting an item will not deselect all already selected items, clicking a selected item will deselect it.
- `Editor.BaseItemWidget.DragDropTarget BodyDropTarget`
  - What shall we do if they drag something in and it's not over an item?
- `System.Single DragDropTargetClosestThreshold`
  - Gets or sets the maximum distance, in pixels, at which a target is considered close enough for drag-and-drop when in BodyDropTarget.Closest mode.
operations.
- `System.Boolean ProvidesDebugMode`
- `Sandbox.UI.Margin Margin`
- `Sandbox.Rect CanvasRect`
  - The inner of LocalRect with Margin
- `System.Collections.Generic.IEnumerable<System.Object> Items`
- `System.Single TimeMsPaint`
- `Editor.BaseItemWidget.ItemDragEvent CurrentItemDragEvent`
- `System.Single timeMsRebuild`
- `System.Boolean MultiSelect`
  - Whether to allow selecting multiple items at once.
- `Sandbox.SelectionSystem Selection`
- `System.Collections.Generic.IEnumerable<System.Object> SelectedItems`
  - Selected items.

## Fields

- `System.Collections.Generic.List<System.Object> _items`
- `System.Collections.Generic.HashSet<Editor.VirtualWidget> ItemLayouts`

## Methods

### Instance methods

- `System.Void SetItems(System.Collections.Generic.IEnumerable<System.Object> items)`
- `System.Void AddItems(System.Collections.Generic.IEnumerable<System.Object> items)`
- `T AddItem(T item)`
  - Add given item to this widget.
- `System.Void RemoveItem(System.Object item)`
  - Remove given item from this widget.
- `virtual System.Void Clear()`
  - Remove all items.
- `virtual System.Void Dirty(System.Object dirtyObject)`
- `virtual System.Void OnLayoutChanged()`
- `virtual System.Void OnScrollChanged()`
- `virtual System.Void OnResize()`
- `virtual System.Void OnPaint()`
- `virtual System.Void PaintItemDebug(Editor.VirtualWidget item)`
- `virtual System.Void PaintItem(Editor.VirtualWidget item)`
- `virtual System.Void OnMouseMove(Editor.MouseEvent e)`
- `Editor.VirtualWidget GetItemAt(Vector2 localPosition)`
  - Get the virtual item at this local position.
- `virtual System.Void OnHoverChanged(System.Object oldHover, System.Object newHover)`
  - Hover has changed, neither of these objects are guaranteed to be non null.
- `virtual System.String GetTooltip(System.Object obj)`
  - Called to retrieve a tooltip for given item.
- `virtual System.Void OnMousePress(Editor.MouseEvent e)`
- `virtual System.Boolean OnItemPressed(Editor.VirtualWidget pressedItem, Editor.MouseEvent e)`
  - Allows over-riding mouse press on an item, without click or selection.
Return true to allow default behavior.
- `virtual System.Void OnItemContextMenu(Editor.VirtualWidget pressedItem, Editor.MouseEvent e)`
  - The item has been right clicked
- `virtual System.Void OnDragLeave()`
- `virtual Editor.VirtualWidget GetDragItem(Editor.Widget.DragEvent ev)`
  - Get the virtual item to use as a drop target for a given drag event
- `virtual System.Void OnDragHover(Editor.Widget.DragEvent ev)`
- `virtual Editor.DropAction OnBodyDragDrop(Editor.BaseItemWidget.ItemDragEvent ev)`
  - Called when a drag drop is being dropped onto the canvas
- `virtual System.Void OnDragDrop(Editor.Widget.DragEvent ev)`
- `Editor.VirtualWidget FindVirtualWidget(System.Object obj)`
  - Given an object, try to find the virtual widget. This can of course return null if the item isn't visible
- `virtual Editor.DropAction OnItemDrag(Editor.BaseItemWidget.ItemDragEvent e)`
  - Called when a dragged item is being hovered over this widget.
This is the place to make drag and drop previews.
- `virtual System.Void OnDragHoverItem(Editor.Widget.DragEvent ev, Editor.VirtualWidget item)`
  - Called when a dragged item is being hovered over this widget.
This is the place to make drag and drop previews.
- `virtual System.Void OnDropOnItem(Editor.Widget.DragEvent ev, Editor.VirtualWidget item)`
  - Called when an item is drag and dropped onto this widget.
- `virtual System.Void OnDragStart()`
- `virtual System.Boolean OnDragItem(Editor.VirtualWidget item)`
  - Called when we start to drag an item.
- `virtual System.Void OnMouseReleased(Editor.MouseEvent e)`
- `virtual System.Void OnItemActivated(System.Object item)`
- `virtual System.Void OnDoubleClick(Editor.MouseEvent e)`
- `virtual System.Boolean SelectMoveColumn(System.Int32 positions)`
- `virtual System.Boolean SelectMoveRow(System.Int32 positions)`
- `virtual System.Void OnKeyPress(Editor.KeyEvent e)`
- `virtual System.Void OnKeyPressOnItem(Editor.KeyEvent e, System.Object item)`
  - A key has been pressed on this selected item.
- `System.Int32 ItemIndex(System.Object item)`
  - Returns the index of given item.
- `System.Object GetAtIndex(System.Int32 i)`
  - Returns the item at given index, or null.
- `virtual System.Void ScrollTo(System.Object target)`
  - Ensure that given item is in view, scrolling to it if necessary.
- `virtual System.Void ScrollTo(System.Single targetPosition, System.Single height)`
  - Ensure that given position is in view, scrolling to it if necessary.
  - `targetPosition`: Target vertical position to make sure is in view.
  - `height`: Height of a potential item/element we want to make sure is in view.
- `System.Void UpdateIfDirty()`
- `virtual System.Void Rebuild()`
  - Rebuild the panel layout.
- `virtual System.Void OnDestroyed()`
- `virtual System.Void OnSelectionAdded(System.Object item)`
- `virtual System.Object ResolveObject(System.Object obj)`
  - For derived classes where the object is wrapped in another class (i.e. TreeView)
- `virtual System.Boolean IsSelected(System.Object obj)`
  - Return true if this item is selected.
- `System.Void SelectItem(System.Object obj, System.Boolean add, System.Boolean skipEvents)`
  - Select given item.
  - `obj`: Item to select.
  - `add`: Whether to add the item to selection, or replace current selection.
  - `skipEvents`: Do not invoke events.
- `System.Void SelectItems(System.Collections.Generic.IEnumerable<System.Object> items, System.Boolean add, System.Boolean skipEvents)`
- `System.Void UnselectItem(System.Object obj, System.Boolean skipEvents)`
  - Unselect given item.
  - `obj`: Item to deselect.
  - `skipEvents`: Do not invoke events.
- `System.Void UnselectAll(System.Boolean skipEvents)`
  - Unselects all items that are currently selected (if any)
  - `skipEvents`: Do not invoke events.
- `virtual System.Void SetSelected(System.Object obj, System.Boolean state, System.Boolean skipEvents)`
  - Set the selection state of an item.
  - `obj`: Item to set selection state of.
  - `state`: Whether the item should be selected or not.
  - `skipEvents`: Do not invoke `Editor.BaseItemWidget.ItemSelected` and `Editor.BaseItemWidget.ItemDeselected`.
- `System.Boolean SelectMove(System.Int32 i)`
  - Move the selection pointer by this many positions.
- `virtual System.Void SelectTo(System.Object item, System.Boolean skipEvents)`
  - Select everything between the current selection pointer and this one.
- `System.Void SelectAll(System.Boolean skipEvents)`
- `virtual System.Void SelectItemStartingWith(System.String text)`
- `virtual System.Collections.Generic.IEnumerable<System.Object> FindItemsThatStartWith(System.String text)`
- `virtual System.Void OnShortcutPressed(Editor.KeyEvent e)`
