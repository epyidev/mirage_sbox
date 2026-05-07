# Sandbox.TextRenderer

Renders text in the world

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Renderer`

## Constructors

- `TextRenderer()`

## Properties

- `Sandbox.TextRendering.Scope TextScope`
  - The text scope defines what text to render and it's visual properties (such as font, color, outline, etc.)
- `System.Single Scale`
  - The size of the text in the world. This is different from the font size, which is defined in the TextScope and determines resolution of the rendered text.
- `Sandbox.TextRenderer.HAlignment HorizontalAlignment`
  - The horizontal alignment of the text in the world.
- `Sandbox.TextRenderer.VAlignment VerticalAlignment`
  - The vertical alignment of the text in the world.
- `Sandbox.BlendMode BlendMode`
  - The blend mode of the text. This determines how the text is rendered over the world.
- `System.Single FogStrength`
  - The strength of the fog effect applied to the text. This determines how much the text blends with any fog in the scene.
- `Color Color`
  - The color of the text from the TextScope.
- `System.Single FontSize`
  - The font size of the text from the TextScope. This is different from the Scale, which determines how large the text appears in the world.
- `System.Int32 FontWeight`
- `System.String FontFamily`
- `System.String Text`
- `System.Int32 ComponentVersion`
