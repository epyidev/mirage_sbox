# Sandbox.UI.PositionMode

Possible values for `position` CSS property.

- **Kind:** enum
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Enum`

## Values

- `Static` - Default, the `top`, `right`, `bottom`, `left`, and `z-index` properties have no effect.
- `Relative` - Enables `top`, `right`, `bottom`, `left`, and `z-index` to offset the element from its
would-be position with `Sandbox.UI.PositionMode.Static`.
- `Absolute` - Same as `Sandbox.UI.PositionMode.Relative`, but the elements size does not affect other elements at all.
