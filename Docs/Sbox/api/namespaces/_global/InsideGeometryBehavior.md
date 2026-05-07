# Sandbox.IndirectLightVolume.InsideGeometryBehavior

Behavior when a probe is detected inside geometry.
Relocation moves the probe out of geometry to reduce artifacts, while Deactivate simply disables the occluded probe, sealing leaks entirely.

- **Kind:** enum
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Enum`
- **Declaring type:** `Sandbox.IndirectLightVolume`

## Values

- `Deactivate` - Probe is deactivated and won't contribute to lighting.
- `Relocate` - Probe is relocated to escape the geometry.
