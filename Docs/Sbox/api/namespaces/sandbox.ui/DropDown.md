# Sandbox.UI.DropDown

- **Kind:** class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Base Library`
- **Base:** `Sandbox.UI.PopupButton`

## Constructors

- `DropDown()`
- `DropDown(Sandbox.UI.Panel parent)`

## Properties

- `System.Action<System.String> ValueChanged`
- `System.Func<System.Collections.Generic.List<Sandbox.UI.Option>> BuildOptions`
- `System.Collections.Generic.List<Sandbox.UI.Option> Options`
- `System.Object Value`
- `Sandbox.UI.Option Selected`

## Fields

- `Sandbox.UI.IconPanel DropdownIndicator`

## Methods

### Instance methods

- `virtual System.Void OnEscape(Sandbox.UI.PanelEvent e)`
- `virtual System.Void Open()`
- `virtual System.Void Select(Sandbox.UI.Option option, System.Boolean triggerChange)`
- `virtual System.Void Select(System.String value, System.Boolean triggerChange)`
- `virtual System.Void OnParametersSet()`
