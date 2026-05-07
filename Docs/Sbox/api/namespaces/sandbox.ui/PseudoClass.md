# Sandbox.UI.PseudoClass

List of CSS pseudo-classes used by the styling system for hover, active, etc.
This acts as a bit-flag.

- **Kind:** enum
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Enum`

## Values

- `None` - No pseudo-class.
- `Unknown` - Unused.
- `Hover` - `:hover` - Any element with the mouse cursor hovering over it.
- `Active` - `:active` - A button that is being pressed down.
- `Focus` - `:focus` - An element with input focus.
- `Intro` - `:intro` - Present on all elements for their first frame. Useful to start CSS transitions on creation.
- `Outro` - `:outro` - The element has been marked for deletion, and will be deleted once all CSS transitions on it has stopped.<br />
            Transitions can be started here to gracefully remove the element visually.
- `Empty` - `:empty` - Any element that has no children.
- `FirstChild` - `:first-child` - The element is the first element among a group of sibling elements.
- `LastChild` - `:last-child` - The element is the last element among a group of sibling elements.
- `OnlyChild` - `:only-child` - The element is the only child of their parent element.
- `Before` - `:before` - Creates an element on the parent element
- `After` - `:after` - Creates an element on the parent element
