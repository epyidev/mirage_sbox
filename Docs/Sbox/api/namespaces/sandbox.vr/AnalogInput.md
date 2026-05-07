# Sandbox.VR.AnalogInput

Represents a VR analog input action (e.g. trigger)

- **Kind:** struct
- **Namespace:** `Sandbox.VR`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Single Value`
  - The current value of this input, from 0 to 1.
- `System.Single Delta`
  - How much `Sandbox.VR.AnalogInput.Value` has changed since the last update, from 0 to 1.
- `System.Boolean Active`
  - Whether or not this action is currently accessible (if false, then `Sandbox.VR.AnalogInput.Value` will always be 0 and will never change).
