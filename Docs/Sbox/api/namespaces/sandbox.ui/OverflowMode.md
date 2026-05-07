# Sandbox.UI.OverflowMode

Possible values for the "overflow" CSS rule, dictating what to do with content that is outside of a panels bounds.

- **Kind:** enum
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Enum`

## Values

- `Visible` - Overflowing content is visible at all times.
- `Hidden` - Overflowing contents are hidden at all times.
- `Scroll` - Overflowing contents are hidden, but can be scrolled to.
- `Clip` - Overflowing contents are clipped, but unlike `Sandbox.UI.OverflowMode.Hidden`, does not create a scroll container and does not affect layout.
- `ClipWhole` - Child elements that extend outside the panel's bounds are hidden entirely, rather than pixel-clipped.
Does not create a scroll container and does not affect layout.
