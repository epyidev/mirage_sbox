# Sandbox.UI.InputFocus

Handles input focus for `Sandbox.UI.Panel`s.

- **Kind:** class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `InputFocus()`

## Properties

- `static Sandbox.UI.Panel Current`
  - The panel that currently has input focus.
- `static Sandbox.UI.Panel Next`
  - The panel that will have the input focus next.

## Methods

### Static methods

- `static System.Boolean Set(Sandbox.UI.Panel panel)`
  - Set the focus to this panel (or its nearest ancestor with AcceptsFocus).
Note that `Sandbox.UI.InputFocus.Current` won't change until the next frame.
- `static System.Boolean Clear(Sandbox.UI.Panel panel)`
  - Clear focus away from this panel.
- `static System.Boolean Clear()`
  - Clear keyboard focus
