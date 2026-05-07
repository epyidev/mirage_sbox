# Sandbox.UI.SplitContainer

- **Kind:** class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Base Library`
- **Base:** `Sandbox.UI.Panel`

## Constructors

- `SplitContainer()`

## Properties

- `Sandbox.UI.Panel Left`
- `Sandbox.UI.Panel Right`
- `Sandbox.UI.Panel Splitter`
- `System.Boolean IsDragging`
- `System.Boolean Vertical`
- `System.String FractionCookie`

## Fields

- `System.Single MinimumFractionLeft`
- `System.Single MinimumFractionRight`

## Methods

### Instance methods

- `virtual System.Void OnMouseMove(Sandbox.UI.MousePanelEvent e)`
- `virtual System.Void UpdateSplitFraction(System.Single f)`
- `virtual System.Void OnTemplateSlot(Sandbox.Html.INode element, System.String slotName, Sandbox.UI.Panel panel)`
- `virtual System.Void SetProperty(System.String name, System.String value)`
