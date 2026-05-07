# Sandbox.UI.Button

- **Kind:** class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Base Library`
- **Base:** `Sandbox.UI.Panel`

## Constructors

- `Button()`
- `Button(System.String text, System.Action action)`
- `Button(System.String text, System.String icon)`
- `Button(System.String text, System.String icon, System.Action onClick)`
- `Button(System.String text, System.String icon, System.String className, System.Action onClick)`

## Properties

- `System.String Href`
- `System.Object Value`
- `Microsoft.AspNetCore.Components.RenderFragment HoverMenu`
- `System.Boolean Disabled`
- `System.Boolean Active`
- `System.String Text`
- `System.String Help`
- `System.String Icon`

## Fields

- `Sandbox.UI.Label TextLabel`
- `Sandbox.UI.IconPanel IconPanel`
- `Sandbox.UI.Label HelpLabel`
- `Sandbox.UI.Panel RightColumn`

## Methods

### Instance methods

- `System.Void DeleteText()`
- `System.Void DeleteIcon()`
- `virtual System.Void SetText(System.String text)`
- `System.Void Click()`
- `virtual System.Void SetProperty(System.String name, System.String value)`
- `virtual System.Void SetContent(System.String value)`
- `virtual System.Void Tick()`
- `System.Void UpdateActiveState()`
- `virtual System.Void OnMouseDown(Sandbox.UI.MousePanelEvent e)`
- `virtual System.Void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder tree)`
- `virtual System.Int32 BuildHash()`
- `virtual System.String GetRenderTreeChecksum()`
