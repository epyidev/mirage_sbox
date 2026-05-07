# Sandbox.HighlightOutline

This component should be added to stuff you want to be outlined. You will also need to 
add the Highlight component to the camera you want to render the outlines.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `HighlightOutline()`

## Properties

- `Sandbox.Material Material`
  - If defined, the glow will use this material rather than a generated one.
- `Color Color`
  - The colour of the glow outline
- `Color ObscuredColor`
  - The colour of the glow when the mesh is obscured by something closer.
- `Color InsideColor`
  - Color of the inside of the glow
- `Color InsideObscuredColor`
  - Color of the inside of the glow when the mesh is obscured by something closer.
- `System.Single Width`
  - The width of the line of the glow
- `System.Boolean OverrideTargets`
  - Specify targets of the outline manually
- `System.Collections.Generic.List<Sandbox.Renderer> Targets`
  - Specify targets of the outline manually

## Methods

### Instance methods

- `System.Collections.Generic.IEnumerable<Sandbox.Renderer> GetOutlineTargets()`
  - Get a list of targets that we want to draw the outline around
