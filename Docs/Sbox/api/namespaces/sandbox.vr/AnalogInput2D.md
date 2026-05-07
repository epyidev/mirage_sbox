# Sandbox.VR.AnalogInput2D

Represents a two-dimensional VR analog input action (e.g. joysticks)

- **Kind:** struct
- **Namespace:** `Sandbox.VR`
- **Assembly:** `Sandbox.Engine`

## Properties

- `Vector2 Value`
  - The current value of this input, with both axes ranging from 0 to 1.
- `Vector2 Delta`
  - How much `Sandbox.VR.AnalogInput2D.Value` has changed since the last update, with both axes ranging from 0 to 1.
- `System.Boolean Active`
  - Whether or not this action is currently accessible (if false, then `Sandbox.VR.AnalogInput2D.Value` will always be 0 and will never change).
