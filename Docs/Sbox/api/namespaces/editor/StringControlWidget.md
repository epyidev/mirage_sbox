# Editor.StringControlWidget

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.ControlWidget`

## Constructors

- `StringControlWidget(Sandbox.SerializedProperty property)`

## Properties

- `System.Boolean IsControlActive`
- `System.Boolean SupportsMultiEdit`
- `Sandbox.TextFlag CellAlignment`
- `System.String RegexValidator`
  - Allow overriding the regex validator on `Editor.StringControlWidget.LineEdit`.
- `System.Boolean ReadOnly`

## Fields

- `Editor.LineEdit LineEdit`

## Methods

### Instance methods

- `virtual System.Void StartEditing()`
- `virtual System.Void DoLayout()`
- `virtual System.Void OnValueChanged()`
- `virtual System.Void OnMultipleDifferentValues(System.Boolean state)`
  - Change text to pink if we're editing multiple values, and they differ
- `virtual System.String ValueToString()`
- `virtual System.Object StringToValue(System.String text)`
- `virtual System.String ToClipboardString()`
- `virtual System.Void FromClipboardString(System.String clipboard)`
- `virtual System.Void OnDestroyed()`
