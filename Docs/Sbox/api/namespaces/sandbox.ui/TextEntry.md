# Sandbox.UI.TextEntry

- **Kind:** class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Base Library`
- **Base:** `Sandbox.UI.BaseControl`

## Constructors

- `TextEntry()`

## Properties

- `System.Func<System.String,System.Object[]> AutoComplete`
- `System.Boolean SupportsMultiEdit`
- `System.Action<System.String> OnTextEdited`
- `Sandbox.UI.Label Label`
- `System.Boolean Disabled`
- `System.String Text`
- `System.String Value`
- `System.Int32 TextLength`
- `System.Int32 CaretPosition`
- `System.Boolean AllowEmojiReplace`
- `System.Boolean AcceptsImeInput`
- `System.String NumberFormat`
- `System.Boolean Multiline`
- `System.Nullable<System.Single> MinValue`
- `System.Nullable<System.Single> MaxValue`
- `System.String Placeholder`
- `Sandbox.UI.Label PrefixLabel`
- `System.String Prefix`
- `Sandbox.UI.Label SuffixLabel`
- `System.String Suffix`
- `Color SelectionColor`
- `System.Int32 HistoryMaxItems`
- `System.String HistoryCookie`
- `Sandbox.UI.IconPanel IconPanel`
- `System.String Icon`
- `System.Boolean HasClearButton`
- `System.Nullable<System.Int32> MinLength`
- `System.Nullable<System.Int32> MaxLength`
- `System.String CharacterRegex`
- `System.String StringRegex`
- `System.Boolean Numeric`
- `System.Boolean HasValidationErrors`

## Fields

- `Sandbox.RealTimeSince TimeSinceNotInFocus`

## Methods

### Instance methods

- `System.Void UpdateAutoComplete()`
- `System.Void UpdateAutoComplete(System.Object[] options)`
- `virtual System.Void DestroyAutoComplete()`
- `virtual System.Void AutoCompleteSelectionChanged()`
- `virtual System.Void AutoCompleteCancel()`
- `virtual System.Void OnPaste(System.String text)`
- `virtual System.String GetClipboardValue(System.Boolean cut)`
- `virtual System.Void OnButtonEvent(Sandbox.UI.ButtonEvent e)`
- `virtual System.Void OnEscape(Sandbox.UI.PanelEvent e)`
- `virtual System.Void OnButtonTyped(Sandbox.UI.ButtonEvent e)`
- `virtual System.Void OnMouseDown(Sandbox.UI.MousePanelEvent e)`
- `virtual System.Void OnMouseUp(Sandbox.UI.MousePanelEvent e)`
- `virtual System.Void OnMouseMove(Sandbox.UI.MousePanelEvent e)`
- `virtual System.Void OnFocus(Sandbox.UI.PanelEvent e)`
- `virtual System.Void OnBlur(Sandbox.UI.PanelEvent e)`
- `virtual System.Void OnDoubleClick(Sandbox.UI.MousePanelEvent e)`
- `virtual System.Void OnKeyTyped(System.Char k)`
- `virtual System.Void OnDraw()`
- `virtual System.Void OnValueChanged()`
- `virtual System.Void Tick()`
- `virtual System.Void SetProperty(System.String name, System.String value)`
- `virtual System.String FixNumeric()`
- `virtual System.Void OnDragSelect(Sandbox.UI.SelectionEvent e)`
- `virtual System.Void OnEvent(Sandbox.UI.PanelEvent e)`
- `virtual System.Boolean IsPanelEmpty()`
- `System.Void AddToHistory(System.String str)`
- `System.Void ClearHistory()`
- `System.Void UpdateValidation()`
- `virtual System.Boolean CanEnterCharacter(System.Char c)`
