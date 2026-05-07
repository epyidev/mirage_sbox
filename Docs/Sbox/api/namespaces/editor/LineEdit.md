# Editor.LineEdit

A single line text entry. See `Editor.TextEdit` for multi line version.

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Widget`

## Constructors

- `LineEdit(Editor.Widget parent)`
- `LineEdit(System.String title, Editor.Widget parent)`

## Properties

- `System.String HistoryCookie`
- `Editor.Widget ForwardNavigationEvents`
  - Forward up, down and enter keys to this control. This is useful if you have a
search box that you want to also allow to navigate a list of items.
- `System.String Value`
  - Alias of `Editor.LineEdit.Text`, except disallows setting text when `Editor.Widget.IsFocused` is `true`.
- `System.String Text`
  - The text of this text entry.
- `System.String DisplayText`
- `System.String PlaceholderText`
  - The placeholder text, it will be displayed only when the text entry is empty.
Typically used to as a short description of the expected input, or as an example input.
- `System.Int32 MaxLength`
  - User entered text can never be longer than this many characters (not bytes).
- `System.Boolean HasSelectedText`
  - Whether the user has any text selected within this text entry.
- `System.Int32 SelectionStart`
  - Character at which the text selection begins, or -1 if there is no selection.
- `System.Int32 SelectionEnd`
  - Character at which the text selection ends, or -1 if there is no selection.
- `System.Boolean ClearButtonEnabled`
  - Show a button to clear the text input when it is not empty.
- `System.Boolean ReadOnly`
- `System.String SelectedText`
  - The selected text, if any.
- `System.Int32 CursorPosition`
  - Position of the text cursor, at which newly typed letters will be inserted.
- `Editor.AutoComplete AutoComplete`
- `System.Boolean AutoCompleteVisible`
  - Whether the <see cref="P:Editor.LineEdit.AutoComplete">auto complete</see>`Editor.Menu` is visible or not.
- `Sandbox.TextFlag Alignment`
- `System.String RegexValidator`
- `Sandbox.Rect CursorRect`
- `System.Boolean HistoryVisible`
  - True if history menu is visible
- `System.Int32 MaxHistoryItems`
  - if set &gt; 1 we will support history items (which you need to add using AddHistory)

## Methods

### Instance methods

- `virtual System.Void RestoreHistoryFromCookie()`
- `virtual System.Void SaveHistoryCookie()`
- `System.Void Clear()`
  - Clear the text.
- `System.Void SelectAll()`
  - Select all of the text.
- `System.Void SetSelection(System.Int32 start, System.Int32 length)`
  - Set the selected text region.
- `System.Void Deselect()`
  - De-select all of the text.
- `System.Void Undo()`
- `System.Void Redo()`
- `System.Void Cut()`
- `System.Void Copy()`
- `System.Void Paste()`
- `System.Void Insert(System.String val)`
- `System.Void SetValidator(System.String str)`
- `virtual System.Void OnTextChanged(System.String value)`
  - Called when the input text changes.
- `virtual System.Void OnTextEdited(System.String value)`
  - Called when the text was edited.
- `virtual System.Void OnReturnPressed()`
  - Called when the user presses the return (Enter) key.
- `virtual System.Void OnEditingFinished()`
  - The text entry lost keyboard focus.
- `System.Void SetAutoComplete(System.Action<Editor.Menu,System.String> func)`
- `virtual System.Void OnBlur(Editor.FocusChangeReason reason)`
- `virtual System.Void OnFocus(Editor.FocusChangeReason reason)`
- `virtual System.Boolean FocusNext()`
  - If we have our menus open, let use tab/shift tab to navigate instead of switching to next control
- `virtual System.Boolean FocusPrevious()`
  - If we have our menus open, let use tab/shift tab to navigate instead of switching to next control
- `virtual System.Void OnKeyPress(Editor.KeyEvent e)`
- `Editor.Option AddOptionToFront(Editor.Option option)`
- `Editor.Option AddOptionToEnd(Editor.Option option)`
- `System.Void AddHistory(System.String text)`
