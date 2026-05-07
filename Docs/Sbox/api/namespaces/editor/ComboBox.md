# Editor.ComboBox

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Widget`

## Constructors

- `ComboBox(Editor.Widget parent)`

## Properties

- `System.String StateCookie`
- `Editor.LineEdit LineEdit`
- `System.String CurrentText`
- `System.Int32 CurrentIndex`
- `System.Int32 Count`
- `System.Boolean AllowDuplicates`
- `System.Int32 MaxVisibleItems`
- `System.Boolean Editable`
- `Editor.ComboBox.InsertMode Insertion`
- `System.Action OnReturn`
- `Editor.AutoComplete AutoComplete`

## Methods

### Instance methods

- `virtual System.Void RestoreFromStateCookie()`
- `virtual System.Void SaveToStateCookie()`
- `System.Nullable<System.Int32> FindIndex(System.String text)`
- `System.Boolean TrySelectNamed(System.String name)`
- `System.Void ClearText()`
- `System.Void Clear()`
- `virtual System.Void OnTextChanged()`
- `System.Void AddItem(System.String text, System.String icon, System.Action onSelected, System.String description, System.Boolean selected, System.Boolean enabled)`
- `System.Void InvokeSelected()`
- `virtual System.Void OnItemChanged()`
- `System.Void SetAutoComplete(System.Action<Editor.Menu,System.String> func)`
- `virtual System.Void OnBlur(Editor.FocusChangeReason reason)`
- `virtual System.Void OnKeyPress(Editor.KeyEvent e)`
