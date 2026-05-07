# Editor.Dialog

A wrapper to more easily create dialog windows.

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.Widget`

## Constructors

- `Dialog(Editor.Widget parent, System.Boolean initAsDialog)`

## Properties

- `Editor.Window Window`
  - The created parent window for this dialog.

## Methods

### Static methods

- `static System.Void AskStringFolder(System.Action<System.String> OnSuccess, System.String question, System.String okay, System.String cancel, System.String initialName)`
- `static System.Void AskStringFile(System.Action<System.String> OnSuccess, System.String question, System.String okay, System.String cancel, System.String initialName)`
- `static System.Void AskString(System.Action<System.String> OnSuccess, System.String question, System.String okay, System.String cancel, System.String initialName, System.String title, System.Int32 minLength)`
- `static System.Void AskConfirm(System.Action OnSuccess, System.String question, System.String title, System.String okay, System.String cancel)`
  - Ask for a confirmation
- `static System.Void AskConfirm(System.Action OnSuccess, System.Action OnCancel, System.String question, System.String title, System.String okay, System.String cancel)`
  - Ask for a confirmation

### Instance methods

- `virtual System.Void Close()`
- `virtual System.Void Show()`
- `virtual System.Void Hide()`
