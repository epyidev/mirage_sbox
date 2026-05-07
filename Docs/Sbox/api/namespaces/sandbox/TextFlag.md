# Sandbox.TextFlag

Flags dictating position of text (and other elements).
Default alignment on each axis is Top, Left.
Values for each axis can be combined into a single value, conflicting values have undefined behavior.

- **Kind:** enum
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Enum`

## Values

- `None`
- `Left` - Align to the left on the X axis.
- `Right` - Align to the right on the X axis.
- `CenterHorizontally` - Align in the center on the X axis.
- `Justify`
- `Absolute`
- `Top` - Anchor to the top on the Y axis.
- `Bottom` - Anchor to the bottom on the Y axis.
- `CenterVertically` - Align in the center on the Y axis.
- `LeftTop` - Anchor to the top left corner.
- `LeftCenter` - Anchor to the left side, center vertically.
- `LeftBottom` - Anchor to the bottom left corner.
- `CenterTop` - Anchor to the top side, center horizontally.
- `Center` - Align in the center on both axises.
- `CenterBottom` - Anchor to the bottom side, center horizontally.
- `RightTop` - Anchor to the top right corner.
- `RightCenter` - Anchor to the right side, center vertically.
- `RightBottom` - Anchor to the bottom right corner.
- `SingleLine` - Limit the text to a single line. Used in `Graphics.DrawText` and `Graphics.MeasureText`.
- `DontClip` - Do not cutoff text beyond its bounds. Used in `Graphics.DrawText` and `Graphics.MeasureText`.
- `WordWrap`
- `WrapAnywhere`
