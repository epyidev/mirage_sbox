# Editor.TextAreaControlWidget

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.ControlWidget`

## Constructors

- `TextAreaControlWidget(Sandbox.SerializedProperty property)`

## Properties

- `System.Boolean IsControlActive`
- `System.Boolean SupportsMultiEdit`
- `System.Boolean ReadOnly`

## Fields

- `Editor.TextEdit TextEdit`

## Methods

### Instance methods

- `virtual System.Void DoLayout()`
- `virtual System.Void OnMultipleDifferentValues(System.Boolean state)`
  - Change text to pink if we're editing multiple values, and they differ
- `virtual System.Void OnValueChanged()`
- `virtual System.String ValueToString()`
- `virtual System.Object StringToValue(System.String text)`
