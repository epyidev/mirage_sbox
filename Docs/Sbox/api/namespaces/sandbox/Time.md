# Sandbox.Time

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `Time()`

## Properties

- `static System.Single Now`
  - The time since the game startup.
- `static System.Single Delta`
  - The delta between the last frame and the current (for all intents and purposes).
- `static System.Double NowDouble`
  - The time since the game startup as a double.

## Methods

### Static methods

- `static System.IDisposable Scope(System.Double now, System.Double delta)`
