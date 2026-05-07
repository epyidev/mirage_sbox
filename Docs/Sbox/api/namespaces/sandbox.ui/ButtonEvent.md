# Sandbox.UI.ButtonEvent

Keyboard (and mouse) key press `Sandbox.UI.PanelEvent`.

- **Kind:** class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `ButtonEvent(Sandbox.UI.ButtonEvent original)`

## Properties

- `System.Type EqualityContract`
- `System.String Button`
  - The button that triggered the event.
- `System.Boolean Pressed`
  - Whether the button was pressed in, or release.
- `System.Int32 VirtualKey`
- `Sandbox.KeyboardModifiers KeyboardModifiers`
  - The keyboard modifier keys that were held down at the moment the event triggered.
- `System.Boolean HasShift`
  - Whether `Shift` key was being held down at the time of the event.
- `System.Boolean HasCtrl`
  - Whether `Control` key was being held down at the time of the event.
- `System.Boolean HasAlt`
  - Whether `Alt` key was being held down at the time of the event.
- `System.Boolean StopPropagation`
  - Set to `true` to prevent the event from propagating to the parent panel.

## Methods

### Instance methods

- `virtual System.Boolean PrintMembers(System.Text.StringBuilder builder)`
- `virtual Sandbox.UI.ButtonEvent <Clone>$()`
