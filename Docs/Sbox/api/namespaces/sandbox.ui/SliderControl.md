# Sandbox.UI.SliderControl

- **Kind:** class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Base Library`
- **Base:** `Sandbox.UI.BaseControl`

## Constructors

- `SliderControl()`
- `SliderControl(System.Single min, System.Single max, System.Single step)`

## Properties

- `System.Boolean SupportsMultiEdit`
- `System.Action<System.Single> OnValueChanged`
- `System.Single Max`
- `System.Single Min`
- `System.Single Step`
- `System.Boolean ShowRange`
- `System.Boolean ShowValueTooltip`
- `System.Boolean ShowTextEntry`
- `System.String NumberFormat`
- `System.Single Value`

## Methods

### Instance methods

- `virtual System.Void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)`
- `virtual System.Void Rebuild()`
- `virtual System.Single ScreenPosToValue(Vector2 pos)`
- `virtual System.Void OnMouseMove(Sandbox.UI.MousePanelEvent e)`
- `virtual System.Void OnMouseDown(Sandbox.UI.MousePanelEvent e)`
- `virtual System.Void OnMiddleClick(Sandbox.UI.MousePanelEvent e)`
