# Sandbox.Utility.Svg.SvgPath

A shape in a `Sandbox.Utility.Svg.SvgDocument`, described as a vector path.

- **Kind:** class
- **Namespace:** `Sandbox.Utility.Svg`
- **Assembly:** `Sandbox.Engine`

## Properties

- `Sandbox.Utility.Svg.PathFillType FillType`
  - How to determine which sections of the path are filled.
- `System.Collections.Generic.IReadOnlyList<Sandbox.Utility.Svg.PathCommand> Commands`
  - Description of how the path is constructed out of basic elements.
- `System.Boolean IsEmpty`
  - If true, this path has no commands.
- `Sandbox.Rect Bounds`
  - Enclosing bounding box for this path.
- `System.Nullable<Color> StrokeColor`
  - Optional outline color for this path.
- `System.Nullable<Color> FillColor`
  - Optional fill color for this path.
