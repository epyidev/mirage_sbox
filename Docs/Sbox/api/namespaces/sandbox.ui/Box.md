# Sandbox.UI.Box

Represents position and size of a `Sandbox.UI.Panel` on the screen.

- **Kind:** class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `Box()`

## Properties

- `System.Single Left`
  - Position of the left edge in screen coordinates.
- `System.Single Right`
  - Position of the right edge in screen coordinates.
- `System.Single Top`
  - Position of the top edge in screen coordinates.
- `System.Single Bottom`
  - Position of the bottom edge in screen coordinates.

## Fields

- `Sandbox.Rect RectOuter`
  - Position and size of the element on the screen, <b>including both - its padding AND margin</b>.
- `Sandbox.Rect RectInner`
  - Position and size of only the element's inner content on the screen, <i>without padding OR margin</i>.
- `Sandbox.UI.Margin Padding`
  - The size of padding.
- `Sandbox.UI.Margin Border`
  - The size of border.
- `Sandbox.UI.Margin Margin`
  - The size of border.
- `Sandbox.Rect Rect`
  - Position and size of the element on the screen, <b>including its padding</b>, <i>but not margin</i>.
- `Sandbox.Rect ClipRect`
  - `Sandbox.UI.Box.Rect` minus the border sizes.
            Used internally to "clip" (hide) everything outside of these bounds, if the panels `Sandbox.UI.OverflowMode` is not set to `Sandbox.UI.OverflowMode.Visible`.
