# Sandbox.Tonemapping.TonemappingMode

Options to select a tonemapping algorithm to use for color grading.

- **Kind:** enum
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Enum`
- **Declaring type:** `Sandbox.Tonemapping`

## Values

- `HableFilmic` - John Hable's filmic tonemapping algorithm.
Matches the default curve Source 2 uses based on Uncharted 2.
- `ACES` - The most realistic tonemapper at handling bright light, desaturating light as it becomes brighter.
This is slightly more expensive than other options.
- `ReinhardJodie` - Reinhard's tonemapper, which is a simple and fast tonemapper.
- `Linear` - Linear tonemapper, only applies autoexposure.
- `AgX` - Similar to ACES - very realistic, but handles lower and higher brightness ranges better.
Uses the Punchy AgX look.
