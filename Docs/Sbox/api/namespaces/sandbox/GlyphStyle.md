# Sandbox.GlyphStyle

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Fields

- `static Sandbox.GlyphStyle Knockout`
  - Face buttons will have colored labels/outlines on a knocked out background
Rest of inputs will have white detail/borders on a knocked out background
- `static Sandbox.GlyphStyle Light`
  - Black detail/borders on a white background
- `static Sandbox.GlyphStyle Dark`
  - White detail/borders on a black background

## Methods

### Instance methods

- `Sandbox.GlyphStyle WithNeutralColorABXY()`
  - ABXY Buttons will match the base style color instead of their normal associated color
- `Sandbox.GlyphStyle WithSolidABXY()`
  - ABXY Buttons will have a solid fill
