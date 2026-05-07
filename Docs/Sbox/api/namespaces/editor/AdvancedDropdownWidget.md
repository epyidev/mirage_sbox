# Editor.AdvancedDropdownWidget

A generic sliding hierarchical selector widget.
Build a tree of `Editor.AdvancedDropdownItem` and hand it to this widget.

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Widget`

## Constructors

- `AdvancedDropdownWidget(Editor.Widget parent)`

## Properties

- `System.Action<System.Object> OnSelect`
  - Called when a leaf item is selected. Receives the item's `Editor.AdvancedDropdownItem.Value`.
- `System.Action OnFinished`
  - Called after selection to allow the host to close/cleanup.
- `System.String SearchPlaceholderText`
  - Placeholder text shown in the search bar.
- `System.String RootTitle`
  - Title shown in the root panel header.
- `Vector2 ContentSize`
  - Fixed size of the content area (below the search bar).
- `Editor.AdvancedDropdownItem RootItem`
  - The root of the item tree. Populated by `Editor.AdvancedDropdownWidget.OnBuildItems` or set directly.
- `System.Action<Editor.AdvancedDropdownItem> OnBuildItems`
  - Called to (re)build the item tree. Receives `Editor.AdvancedDropdownWidget.RootItem` after it has been cleared.
- `System.Func<Editor.AdvancedDropdownItem,System.String[],System.Int32> SearchScorer`
  - Optional custom search scorer. Receives an item and the search words, returns a score (0 = no match).
If null, the default scorer matches against Title and Description.
- `Editor.Widget FilterWidget`
  - Optional filter widget placed next to the search bar (e.g. a settings button).
- `System.Boolean IsTextInputActive`
  - For subclasses that have a text input inside the panel (e.g. a name field) -
set to true to prevent Left arrow key from popping the panel.
- `Editor.Widget Main`
- `System.Boolean IsSearching`
  - Whether the user is currently searching.
- `Editor.LineEdit Search`

## Methods

### Instance methods

- `System.Void Rebuild()`
  - Rebuild the item tree and reset to the root panel.
- `System.Void PushPanel(Editor.AdvancedDropdownWidget.AdvancedDropdownPanel panel)`
  - Push a new panel onto the stack (navigate deeper into a category).
- `System.Void PopPanel()`
  - Pop the current panel (navigate back).
- `virtual System.Void BuildPanel(Editor.AdvancedDropdownWidget.AdvancedDropdownPanel panel)`
  - Build a panel's content from the item tree. Override to customize.
- `virtual System.Void OnBuildSearchResults(Editor.AdvancedDropdownWidget.AdvancedDropdownPanel panel, System.String searchText)`
  - Called after search results are populated. Override to add extra entries (e.g. "New Component" button).
- `virtual System.Void OnPaint()`
- `virtual System.Void OnKeyRelease(Editor.KeyEvent e)`
