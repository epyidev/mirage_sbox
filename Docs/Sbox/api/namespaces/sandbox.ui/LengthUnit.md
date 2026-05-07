# Sandbox.UI.LengthUnit

Possible units for various CSS properties that require length, used by `Sandbox.UI.Length` struct.

- **Kind:** enum
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Enum`

## Values

- `Auto` - The layout engine will calculate and select a width for the specified element.
- `Pixels` - The length is in pixels.
- `Percentage` - The length is a percentage (0-100) of the parent's length. (typically)
- `ViewHeight` - The length is a percentage (0-100) of the viewport's height.
- `ViewWidth` - The length is a percentage (0-100) of the viewport's width.
- `ViewMin` - The length is a percentage (0-100) of the viewport's smallest side/edge.
- `ViewMax` - The length is a percentage (0-100) of the viewport's largest side/edge.
- `Start` - Start of the parent at the appropriate axis.
- `Cover` - For background images, cover the entire element with the image, stretcing and cropping as necessary.
- `Contain` - For background images, contain the image within the element bounds.
- `End` - End of the parent at the appropriate axis.
- `Center` - In the middle of the parent at the appropriate axis.
- `Undefined` - Similar to CSS 'unset', basically means we don't have a value; should only really be used under certain
circumstances (e.g. to handle background sizing properly).
- `Expression` - Represents a calc( ... ) expression
- `RootEm` - Font size of the root element.
- `Em` - Font size of the current element.
