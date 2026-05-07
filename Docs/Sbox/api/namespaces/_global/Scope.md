# Sandbox.TextRendering.Scope

Defines a scope of text, all using the same style.

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.TextRendering`

## Constructors

- `Scope(System.String text, Color color, System.Single size, System.String font, System.Int32 weight)`

## Properties

- `static Sandbox.TextRendering.Scope Default`

## Fields

- `System.String Text`
- `Color TextColor`
- `System.String FontName`
- `System.Single FontSize`
- `System.Int32 FontWeight`
- `System.Boolean FontItalic`
- `Sandbox.UI.FontVariantNumeric FontVariantNumeric`
- `System.Single LineHeight`
- `System.Single LetterSpacing`
- `System.Single WordSpacing`
- `Sandbox.Rendering.FilterMode FilterMode`
- `Sandbox.UI.FontSmooth FontSmooth`
- `Sandbox.TextRendering.Outline Outline`
- `Sandbox.TextRendering.Shadow Shadow`
- `Sandbox.TextRendering.Outline OutlineUnder`
- `Sandbox.TextRendering.Shadow ShadowUnder`

## Methods

### Instance methods

- `Vector2 Measure()`
  - Measures the rendered size of the text in this `Sandbox.TextRendering.Scope` using its current style settings. This is non trivial
but the underlying style is cached, so if you end up drawing it, it'll re-use the cached data anyway.
  - returns: A `Vector2` representing the width and height, in pixels, of the rendered text.
