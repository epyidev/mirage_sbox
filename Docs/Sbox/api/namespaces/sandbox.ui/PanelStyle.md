# Sandbox.UI.PanelStyle

- **Kind:** sealed class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.UI.Styles`

## Properties

- `System.Boolean HasBeforeElement`
  - This style has a ::before element available. This is signalling to the panel system that if we 
apply this style, we should also create a ::before element.
- `System.Boolean HasAfterElement`
  - This style has a ::after element available. This is signalling to the panel system that if we 
apply this style, we should also create a ::after element.

## Methods

### Instance methods

- `virtual System.Void Dirty()`
- `virtual System.Boolean Set(System.String property, System.String value)`
- `System.Void SetBackgroundImage(Sandbox.Texture texture)`
- `System.Void SetBackgroundImage(System.String image)`
- `System.Threading.Tasks.Task SetBackgroundImageAsync(System.String image)`
- `System.Void SetRect(Sandbox.Rect rect)`
