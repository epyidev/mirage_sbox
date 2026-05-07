# Sandbox.UI.ButtonGroup

- **Kind:** class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Base Library`
- **Base:** `Sandbox.UI.Panel`

## Constructors

- `ButtonGroup()`

## Properties

- `System.Action<System.Object> ValueChanged`
- `System.Object Value`
- `System.Collections.Generic.List<Sandbox.UI.Option> Options`
- `System.String ButtonClass`
- `Sandbox.UI.Panel SelectedButton`

## Methods

### Instance methods

- `Sandbox.UI.Button AddButton(System.String value, System.Action action)`
- `Sandbox.UI.Button AddButtonActive(System.String value, System.Action<System.Boolean> action)`
- `virtual System.Void OnChildAdded(Sandbox.UI.Panel child)`
- `virtual System.Void OnParametersSet()`
- `virtual System.Void Tick()`
