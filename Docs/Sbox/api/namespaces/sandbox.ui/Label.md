# Sandbox.UI.Label

A generic text label. Can be made editable.

- **Kind:** class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.UI.Panel`

## Constructors

- `Label()`
- `Label(System.String text, System.String classname)`

## Properties

- `System.Boolean ShouldDrawSelection`
- `System.Boolean Selectable`
  - Can be selected
- `System.Boolean Tokenize`
  - If true and the text starts with #, it will be treated as a language token.
- `System.Int32 SelectionStart`
- `System.Int32 SelectionEnd`
- `Color SelectionColor`
  - The color used for text selection highlight
- `System.String Text`
  - Text to display on the label.
- `System.Boolean IsRich`
  - Set to true if this is rich text. This means it can support some inline html elements.
- `System.Int32 CaretPosition`
  - Position of the text cursor/caret within the text, at which newly typed characters are inserted.
- `System.Int32 TextLength`
  - Amount of characters in the text of the text entry. Not bytes.
- `System.Boolean Multiline`
  - Enables multi-line support for editing purposes.

## Fields

- `System.Globalization.StringInfo StringInfo`
  - Information about the `Sandbox.UI.Label.Text` on a per-element scale. It handles multi-character Unicode units (graphemes) correctly.

## Methods

### Instance methods

- `virtual System.Void OnDeleted()`
- `virtual System.Void SetProperty(System.String name, System.String value)`
- `virtual System.Void SetContent(System.String value)`
- `System.Void CaretSantity()`
  - Ensure the text caret and selection are in sane positions, that is, not outside of the text bounds.
- `System.String GetSelectedText()`
  - Returns the selected text.
- `virtual System.String GetClipboardValue(System.Boolean cut)`
- `Sandbox.Rect GetCaretRect(System.Int32 i)`
- `virtual System.Void FinalLayout(Vector2 offset)`
- `virtual System.Void OnDraw()`
- `System.Int32 GetLetterAt(Vector2 pos)`
- `System.Int32 GetLetterAtScreenPosition(Vector2 pos)`
- `System.Boolean HasSelection()`
- `virtual System.Void LanguageChanged()`
  - When the language changes, if we're token based we need to update to the new phrase.
- `virtual System.Void OnMouseMove(Sandbox.UI.MousePanelEvent e)`
- `virtual System.Void OnClick(Sandbox.UI.MousePanelEvent e)`
- `System.Void ReplaceSelection(System.String str)`
  - Replace the currently selected text with given text.
- `System.Void SetSelection(System.Int32 start, System.Int32 end)`
  - Sets the text selection.
- `System.Void SetCaretPosition(System.Int32 pos, System.Boolean select)`
  - Set the text caret position to the given index.
  - `pos`: Where to move the text caret to within the text.
  - `select`: Whether to also add the characters we passed by to the selection.
- `System.Void ScrollToCaret()`
  - Put the caret within the visible region.
- `System.Void MoveToWordBoundaryLeft(System.Boolean select)`
  - Move the text caret to the closest word start or end to the left of current position.<br />
This simulates holding Control key while pressing left arrow key.
  - `select`: Whether to also add the characters we passed by to the selection.
- `System.Void MoveToWordBoundaryRight(System.Boolean select)`
  - Move the text caret to the closest word start or end to the right of current position.<br />
This simulates holding Control key while pressing right arrow key.
  - `select`: Whether to also add the characters we passed by to the selection.
- `System.Void MoveCaretPos(System.Int32 delta, System.Boolean select)`
  - Move the text caret by given amount.
  - `delta`: How many characters to the right to move. Negative values move left.
  - `select`: Whether to also add the characters we passed by to the selection.
- `System.Void InsertText(System.String text, System.Int32 pos, System.Nullable<System.Int32> endpos)`
- `virtual System.Void RemoveText(System.Int32 start, System.Int32 count)`
  - Remove given amount of characters from the label at given `start` position.
- `System.Void MoveToLineStart(System.Boolean select)`
  - Move the text caret to the start of the current line.
  - `select`: Whether to also add the characters we passed by to the selection.
- `System.Void MoveToLineEnd(System.Boolean select)`
  - Move the text caret to the end of the current line.
  - `select`: Whether to also add the characters we passed by to the selection.
- `System.Void MoveCaretLine(System.Int32 offset_line, System.Boolean select)`
  - Move the text caret to next or previous line.
  - `offset_line`: How many lines to offset. Negative values move up.
  - `select`: Whether to also add the characters we passed by to the selection.
- `System.Void SelectWord(System.Int32 wordPos)`
  - Select a work at given word position.
- `System.Collections.Generic.List<System.Int32> GetWordBoundaryIndices()`
  - Returns a list of positions in the text of each side of each word within the `Sandbox.UI.Label.Text`.<br />
This is used for Control + Arrow Key navigation.
