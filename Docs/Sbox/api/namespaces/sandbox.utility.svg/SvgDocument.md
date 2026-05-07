# Sandbox.Utility.Svg.SvgDocument

Helper class for reading Scalable Vector Graphics files.

- **Kind:** class
- **Namespace:** `Sandbox.Utility.Svg`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Collections.Generic.IReadOnlyList<Sandbox.Utility.Svg.SvgPath> Paths`
  - List of all shapes in the document.

## Methods

### Static methods

- `static Sandbox.Utility.Svg.SvgDocument FromString(System.String contents)`
  - Reads an SVG document from the given string, returning a list of path elements
describing the shapes in the image.
  - `contents`: SVG document contents.
