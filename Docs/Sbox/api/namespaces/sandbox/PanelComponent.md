# Sandbox.PanelComponent

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `PanelComponent()`

## Properties

- `Sandbox.UI.Panel Panel`
  - The panel. Can be null if the panel doesn't exist yet.

## Methods

### Instance methods

- `System.Boolean HasClass(System.String className)`
- `System.Void RemoveClass(System.String className)`
- `System.Void AddClass(System.String className)`
- `System.Void BindClass(System.String className, System.Func<System.Boolean> func)`
- `System.Void SetClass(System.String className, System.Boolean enabled)`
- `virtual System.Void OnStart()`
- `virtual System.Void OnParentChanged(Sandbox.GameObject oldParent, Sandbox.GameObject newParent)`
- `virtual System.Void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder v)`
  - Gets overridden by .razor file
- `virtual System.String GetRenderTreeChecksum()`
  - Gets overridden by .razor file
- `virtual System.Void OnTreeFirstBuilt()`
  - Called when the razor ui has been built.
- `virtual System.Void OnTreeBuilt()`
  - Called after the tree has been built. This can happen any time the contents change.
- `virtual System.Int32 BuildHash()`
  - When this has changes, we will re-render this panel. This is usually
implemented as a HashCode.Combine containing stuff that causes the
panel's content to change.
- `System.Void StateHasChanged()`
  - Should be called when you want the component to be re-rendered.
