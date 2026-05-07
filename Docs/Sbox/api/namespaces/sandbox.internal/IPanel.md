# Sandbox.Internal.IPanel

- **Kind:** interface
- **Namespace:** `Sandbox.Internal`
- **Assembly:** `Sandbox.Engine`

## Properties

- `Sandbox.Internal.IPanel Parent`
- `System.Collections.Generic.IEnumerable<Sandbox.Internal.IPanel> Children`
- `System.Int32 ChildrenCount`
- `System.String ElementName`
- `System.String Id`
  - The Id of the element ( id="foo" )
- `System.String SourceFile`
  - If the panel created by razor, this is the file in which it was defined
- `System.Int32 SourceLine`
  - If the panel was created by razor, this is the line in which it was defined
- `System.Boolean IsMainMenu`
- `System.Boolean IsGame`
- `System.Boolean IsVisible`
- `System.Boolean IsVisibleSelf`
- `System.Boolean WantsPointerEvents`
  - If true then this panel (or its ancestor) has pointer-events: all
- `System.String Classes`
- `Sandbox.Rect Rect`
- `Sandbox.Rect InnerRect`
- `Sandbox.Rect OuterRect`
- `System.Nullable<Matrix> GlobalMatrix`
- `System.Boolean HasTooltip`
- `Sandbox.UI.PseudoClass PseudoClass`
  - Procedural classes such as :hover and :active
- `Sandbox.UI.PanelInputType ButtonInput`
- `System.Collections.Generic.IEnumerable<Sandbox.UI.IStyleBlock> ActiveStyleBlocks`
  - Get all style blocks active on this panel

## Methods

### Instance methods

- `virtual Sandbox.Internal.IPanel GetPanelAt(Vector2 point, System.Boolean visibleOnly, System.Boolean needPointerEvents)`
- `virtual System.Boolean IsAncestor(Sandbox.Internal.IPanel panel)`
- `virtual Sandbox.Internal.IPanel CreateTooltip()`
- `virtual System.Void UpdateTooltip(Sandbox.Internal.IPanel tooltipPanel)`
- `virtual System.Void Delete(System.Boolean immediate)`
- `virtual System.Void SetAbsolutePosition(Sandbox.TextFlag alignment, Vector2 position, System.Single offset)`
  - Set the panel's absolute position. This wouldn't be needed if we could expose the styles. Which we should
do.
