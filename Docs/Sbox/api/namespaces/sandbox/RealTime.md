# Sandbox.RealTime

Access to time.

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Properties

- `static System.Single Now`
  - The time since the game startup, in seconds.
- `static System.Double NowDouble`
  - The time since the game startup as a double, in seconds.
- `static System.Double GlobalNow`
  - The number of a seconds since a set point in time. This value should match between servers and clients. If they have their timezone set correctly.
- `static System.Single Delta`
  - The time delta (in seconds) between the last frame and the current (for all intents and purposes)
- `static System.Single SmoothDelta`
  - Like Delta but smoothed to avoid large disparities between deltas
