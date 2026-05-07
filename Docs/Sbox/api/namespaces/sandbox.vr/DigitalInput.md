# Sandbox.VR.DigitalInput

Represents a VR digital input action (e.g. X button)

- **Kind:** struct
- **Namespace:** `Sandbox.VR`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Boolean IsPressed`
  - The current value of this input - true if pressed, false if not pressed.
- `System.Boolean WasPressed`
  - The previous value of this input - true if it was pressed, false if it was not pressed.
- `System.Boolean Delta`
  - How much `Sandbox.VR.DigitalInput.IsPressed` has changed since the last update.
- `System.Boolean Active`
  - Whether or not this action is currently accessible (if false, then `Sandbox.VR.DigitalInput.IsPressed` will always be false and will never change).
