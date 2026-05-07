# Editor.TextEdit

A multi-line text entry. See `Editor.LineEdit` for a single line version.

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Widget`

## Constructors

- `TextEdit(Editor.Widget parent)`

## Properties

- `System.Boolean TextSelectable`
- `System.Boolean LinksClickable`
- `System.Boolean Editable`
- `Editor.ScrollBar VerticalScrollbar`
- `Editor.ScrollBar HorizontalScrollbar`
- `Editor.ScrollbarMode HorizontalScrollbarMode`
- `Editor.ScrollbarMode VerticalScrollbarMode`
- `System.String PlainText`
- `System.String Html`
- `System.String PlaceholderText`
- `System.Boolean CenterOnScroll`
- `System.Boolean BackgroundVisible`
- `System.Int32 MaximumBlockCount`
- `System.Single TabSize`
- `System.Boolean ReadOnly`
- `Editor.CursorShape Cursor`

## Fields

- `System.Action<System.String> TextChanged`

## Methods

### Instance methods

- `System.Void ScrollToBottom()`
- `System.Void AppendHtml(System.String html)`
- `System.Void AppendPlainText(System.String text)`
- `virtual System.Void Clear()`
- `System.Void SelectAll()`
- `System.Void CenterOnCursor()`
- `System.Void SetTextCursor(Editor.TextCursor cursor)`
- `Editor.TextCursor GetCursorAtPosition(Vector2 position)`
- `Editor.TextCursor GetTextCursor()`
- `Sandbox.Rect GetCursorRect(Editor.TextCursor cursor)`
- `System.String GetAnchorAt(Vector2 point)`
- `Editor.TextCursor GetCursorAtBlock(System.Int32 block)`
- `virtual System.Void OnTextChanged(System.String value)`
  - Called when text changed.
- `virtual System.Void OnFocus(Editor.FocusChangeReason reason)`
- `virtual System.Void OnBlur(Editor.FocusChangeReason reason)`
