# Namespace `Sandbox.UI`

121 types.

## Classes

- [`Align`](./Align.md) - Possible values for `align-items` CSS property.
- [`BackdropDrawDescriptor`](./BackdropDrawDescriptor.md)
- [`BackgroundRepeat`](./BackgroundRepeat.md) - Possible values for `background-repeat` CSS property.
- [`BaseControl`](./BaseControl.md)
- [`BasePopup`](./BasePopup.md) - A panel that gets deleted automatically when clicked away from
- [`BaseStyles`](./BaseStyles.md) - Auto generated container class for majority of CSS properties available.
- [`BaseVirtualPanel`](./BaseVirtualPanel.md) - Base class for virtualized, scrollable panels that only create item panels when visible.
- [`BorderImageFill`](./BorderImageFill.md) - State of `fill` setting of `border-image-slice` (`border-image`) CSS property.
- [`BorderImageRepeat`](./BorderImageRepeat.md) - Possible values for `border-image-repeat` (`border-image`) CSS property.
- [`Box`](./Box.md) - Represents position and size of a `Sandbox.UI.Panel` on the screen.
- [`BoxDrawDescriptor`](./BoxDrawDescriptor.md)
- [`Button`](./Button.md)
- [`ButtonEvent`](./ButtonEvent.md) - Keyboard (and mouse) key press `Sandbox.UI.PanelEvent`.
- [`ButtonGroup`](./ButtonGroup.md)
- [`Checkbox`](./Checkbox.md)
- [`ColorAlphaControl`](./ColorAlphaControl.md)
- [`ColorControl`](./ColorControl.md)
- [`ColorHueControl`](./ColorHueControl.md)
- [`ColorPickerControl`](./ColorPickerControl.md)
- [`ColorSaturationValueControl`](./ColorSaturationValueControl.md)
- [`ControlSheet`](./ControlSheet.md)
- [`ControlSheetGroup`](./ControlSheetGroup.md)
- [`ControlSheetGroupHeader`](./ControlSheetGroupHeader.md)
- [`ControlSheetRow`](./ControlSheetRow.md)
- [`CopyEvent`](./CopyEvent.md)
- [`CutEvent`](./CutEvent.md)
- [`DisplayMode`](./DisplayMode.md) - Possible values for `display` CSS property.
- [`DragEvent`](./DragEvent.md)
- [`DropDown`](./DropDown.md)
- [`EnumControl`](./EnumControl.md)
- [`EscapeEvent`](./EscapeEvent.md)
- [`Field`](./Field.md)
- [`FieldControl`](./FieldControl.md)
- [`FlexDirection`](./FlexDirection.md) - Possible values for `flex-direction` CSS property.
- [`FontSmooth`](./FontSmooth.md) - Possible values for `font-smooth` CSS property.
- [`FontStyle`](./FontStyle.md) - Possible values for `font-style` CSS property.
- [`FontVariantNumeric`](./FontVariantNumeric.md) - Possible values for `font-variant-numeric` CSS property.
- [`Form`](./Form.md)
- [`IconPanel`](./IconPanel.md)
- [`Image`](./Image.md) - A generic box that displays a given texture within itself.
- [`ImageRendering`](./ImageRendering.md) - Possible values for `image-rendering` CSS property.
- [`InputFocus`](./InputFocus.md) - Handles input focus for `Sandbox.UI.Panel`s.
- [`Justify`](./Justify.md) - Possible values for `justify-content` CSS property.
- [`KeyFrames`](./KeyFrames.md) - Represents a CSS `@keyframes` rule.
- [`Label`](./Label.md) - A generic text label. Can be made editable.
- [`LayoutCascade`](./LayoutCascade.md)
- [`Length`](./Length.md) - A variable unit based length. ie, could be a percentage or a pixel length. This is commonly used to express the size of things in UI space, usually coming from style sheets.
- [`LengthUnit`](./LengthUnit.md) - Possible units for various CSS properties that require length, used by `Sandbox.UI.Length` struct.
- [`LoaderFullScreen`](./LoaderFullScreen.md)
- [`Margin`](./Margin.md) - Represents a <see cref="T:Sandbox.Rect">Rect</see> where each side is the thickness of an edge/padding/margin/border, rather than positions.
- [`MaskMode`](./MaskMode.md) - Possible values for `mask-mode` CSS property.
- [`MaskScope`](./MaskScope.md) - Possible values for `mask-scope` CSS property.
- [`MenuPanel`](./MenuPanel.md)
- [`MixinDefinition`](./MixinDefinition.md) - Represents a parsed @mixin definition that can be included elsewhere.
- [`MixinParameter`](./MixinParameter.md) - A single parameter in a mixin definition.
- [`MousePanelEvent`](./MousePanelEvent.md) - Mouse related `Sandbox.UI.PanelEvent`.
- [`NumberEntry`](./NumberEntry.md)
- [`ObjectFit`](./ObjectFit.md)
- [`Option`](./Option.md)
- [`OutlineDrawDescriptor`](./OutlineDrawDescriptor.md)
- [`OverflowMode`](./OverflowMode.md) - Possible values for the "overflow" CSS rule, dictating what to do with content that is outside of a panels bounds.
- [`PackageCard`](./PackageCard.md)
- [`PackageFilterFacet`](./PackageFilterFacet.md)
- [`PackageFilterOrder`](./PackageFilterOrder.md)
- [`PackageFilters`](./PackageFilters.md)
- [`PackageList`](./PackageList.md)
- [`Panel`](./Panel.md) - A simple User Interface panel. Can be styled with <a href="https://en.wikipedia.org/wiki/CSS">CSS</a>.
- [`PanelEvent`](./PanelEvent.md) - Base `Sandbox.UI.Panel` event.<br />
- [`PanelInputType`](./PanelInputType.md)
- [`PanelRenderTreeBuilder`](./PanelRenderTreeBuilder.md) - This is a tree renderer for panels. If we ever use razor on other ui we'll want to make a copy of
- [`PanelStyle`](./PanelStyle.md)
- [`PanelTransform`](./PanelTransform.md)
- [`PasteEvent`](./PasteEvent.md)
- [`PointerEvents`](./PointerEvents.md) - Possible values for `pointer-events` CSS property.
- [`Popup`](./Popup.md)
- [`PopupButton`](./PopupButton.md)
- [`PositionMode`](./PositionMode.md) - Possible values for `position` CSS property.
- [`PseudoClass`](./PseudoClass.md) - List of CSS pseudo-classes used by the styling system for hover, active, etc.
- [`RenderState`](./RenderState.md) - Describes panel's position and size for rendering operations.
- [`RootPanel`](./RootPanel.md) - A root panel. Serves as a container for other panels, handles things such as rendering.
- [`ScenePanel`](./ScenePanel.md) - Allows to render a scene world onto a panel.
- [`SelectionEvent`](./SelectionEvent.md)
- [`Shadow`](./Shadow.md) - Shadow style settings
- [`ShadowDrawDescriptor`](./ShadowDrawDescriptor.md)
- [`ShadowList`](./ShadowList.md) - A list of shadows
- [`SliderControl`](./SliderControl.md)
- [`SplitContainer`](./SplitContainer.md)
- [`StyleBlock`](./StyleBlock.md) - A CSS rule - ie ".chin { width: 100%; height: 100%; }"
- [`Styles`](./Styles.md) - Represents all supported CSS properties and their currently assigned values.
- [`StyleSelector`](./StyleSelector.md) - A CSS selector like "Panel.button.red:hover .text"
- [`StyleSheet`](./StyleSheet.md)
- [`StyleSheetCollection`](./StyleSheetCollection.md) - A collection of `Sandbox.UI.StyleSheet` objects applied directly to a panel.
- [`SvgPanel`](./SvgPanel.md) - A generic panel that draws an SVG scaled to size
- [`SwitchControl`](./SwitchControl.md)
- [`TextAlign`](./TextAlign.md) - Possible values for `text-align` CSS property.
- [`TextDecoration`](./TextDecoration.md) - Possible values for `text-decoration` CSS property.
- [`TextDecorationStyle`](./TextDecorationStyle.md) - Possible values for `text-decoration-style` CSS property.
- [`TextEntry`](./TextEntry.md)
- [`TextOverflow`](./TextOverflow.md) - Possible values for `text-overflow` CSS property.
- [`TextSkipInk`](./TextSkipInk.md) - Possible values for `text-decoration-skip-ink` CSS property.
- [`TextTransform`](./TextTransform.md) - Possible values for `text-transform` CSS property.
- [`TransitionDesc`](./TransitionDesc.md) - Describes transition of a single CSS property, a.k.a. the values of a `transition` CSS property.
- [`TransitionList`](./TransitionList.md) - A list of CSS properties that should transition when changed.
- [`Transitions`](./Transitions.md) - Handles the storage, progression and application of CSS transitions for a single `Sandbox.UI.Panel`.
- [`VectorControl`](./VectorControl.md)
- [`VirtualGrid`](./VirtualGrid.md) - A virtualized, scrollable grid panel that only creates item panels when visible.
- [`VirtualList`](./VirtualList.md) - A virtualized, scrollable list panel that only creates item panels when visible.
- [`WebPanel`](./WebPanel.md) - A panel that displays an interactive web page.
- [`WhiteSpace`](./WhiteSpace.md) - Possible values for `white-space` CSS property.
- [`WordBreak`](./WordBreak.md) - Possible values for `word-break` CSS property.
- [`WorldInput`](./WorldInput.md)
- [`WorldPanel`](./WorldPanel.md) - An interactive 2D panel rendered in the 3D world.
- [`Wrap`](./Wrap.md) - Possible values for `flex-wrap` CSS property.

## Static classes

- [`Clipboard`](./Clipboard.md)
- [`Emoji`](./Emoji.md) - Helper class for working with Unicode emoji.
- [`LengthUnitExtension`](./LengthUnitExtension.md)

## Attributes

- [`CascadingParameterAttribute`](./CascadingParameterAttribute.md) - A panel's property will be inherited from its parent.
- [`PanelEventAttribute`](./PanelEventAttribute.md) - Add an event listener to a `Sandbox.UI.Panel` event with the given name.<br />
- [`StyleSheetAttribute`](./StyleSheetAttribute.md) - Will automatically apply the named stylesheet to the Panel.

## Interfaces

- [`IStyleBlock`](./IStyleBlock.md) - A CSS rule - ie ".chin { width: 100%; height: 100%; }"
- [`IStyleTarget`](./IStyleTarget.md) - Everything the style system needs to work out a style

## Structs

- [`BackdropDrawDescriptor`](./BackdropDrawDescriptor.md)
- [`BoxDrawDescriptor`](./BoxDrawDescriptor.md)
- [`LayoutCascade`](./LayoutCascade.md)
- [`Length`](./Length.md) - A variable unit based length. ie, could be a percentage or a pixel length. This is commonly used to express the size of things in UI space, usually coming from style sheets.
- [`Margin`](./Margin.md) - Represents a <see cref="T:Sandbox.Rect">Rect</see> where each side is the thickness of an edge/padding/margin/border, rather than positions.
- [`MixinParameter`](./MixinParameter.md) - A single parameter in a mixin definition.
- [`OutlineDrawDescriptor`](./OutlineDrawDescriptor.md)
- [`PanelTransform`](./PanelTransform.md)
- [`RenderState`](./RenderState.md) - Describes panel's position and size for rendering operations.
- [`Shadow`](./Shadow.md) - Shadow style settings
- [`ShadowDrawDescriptor`](./ShadowDrawDescriptor.md)
- [`StyleSheetCollection`](./StyleSheetCollection.md) - A collection of `Sandbox.UI.StyleSheet` objects applied directly to a panel.
- [`TransitionDesc`](./TransitionDesc.md) - Describes transition of a single CSS property, a.k.a. the values of a `transition` CSS property.

## Enums

- [`Align`](./Align.md) - Possible values for `align-items` CSS property.
- [`BackgroundRepeat`](./BackgroundRepeat.md) - Possible values for `background-repeat` CSS property.
- [`BorderImageFill`](./BorderImageFill.md) - State of `fill` setting of `border-image-slice` (`border-image`) CSS property.
- [`BorderImageRepeat`](./BorderImageRepeat.md) - Possible values for `border-image-repeat` (`border-image`) CSS property.
- [`DisplayMode`](./DisplayMode.md) - Possible values for `display` CSS property.
- [`FlexDirection`](./FlexDirection.md) - Possible values for `flex-direction` CSS property.
- [`FontSmooth`](./FontSmooth.md) - Possible values for `font-smooth` CSS property.
- [`FontStyle`](./FontStyle.md) - Possible values for `font-style` CSS property.
- [`FontVariantNumeric`](./FontVariantNumeric.md) - Possible values for `font-variant-numeric` CSS property.
- [`ImageRendering`](./ImageRendering.md) - Possible values for `image-rendering` CSS property.
- [`Justify`](./Justify.md) - Possible values for `justify-content` CSS property.
- [`LengthUnit`](./LengthUnit.md) - Possible units for various CSS properties that require length, used by `Sandbox.UI.Length` struct.
- [`MaskMode`](./MaskMode.md) - Possible values for `mask-mode` CSS property.
- [`MaskScope`](./MaskScope.md) - Possible values for `mask-scope` CSS property.
- [`ObjectFit`](./ObjectFit.md)
- [`OverflowMode`](./OverflowMode.md) - Possible values for the "overflow" CSS rule, dictating what to do with content that is outside of a panels bounds.
- [`PanelInputType`](./PanelInputType.md)
- [`PointerEvents`](./PointerEvents.md) - Possible values for `pointer-events` CSS property.
- [`PositionMode`](./PositionMode.md) - Possible values for `position` CSS property.
- [`PseudoClass`](./PseudoClass.md) - List of CSS pseudo-classes used by the styling system for hover, active, etc.
- [`TextAlign`](./TextAlign.md) - Possible values for `text-align` CSS property.
- [`TextDecoration`](./TextDecoration.md) - Possible values for `text-decoration` CSS property.
- [`TextDecorationStyle`](./TextDecorationStyle.md) - Possible values for `text-decoration-style` CSS property.
- [`TextOverflow`](./TextOverflow.md) - Possible values for `text-overflow` CSS property.
- [`TextSkipInk`](./TextSkipInk.md) - Possible values for `text-decoration-skip-ink` CSS property.
- [`TextTransform`](./TextTransform.md) - Possible values for `text-transform` CSS property.
- [`WhiteSpace`](./WhiteSpace.md) - Possible values for `white-space` CSS property.
- [`WordBreak`](./WordBreak.md) - Possible values for `word-break` CSS property.
- [`Wrap`](./Wrap.md) - Possible values for `flex-wrap` CSS property.
