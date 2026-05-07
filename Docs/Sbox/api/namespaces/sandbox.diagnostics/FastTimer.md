# Sandbox.Diagnostics.FastTimer

A lightweight, high-resolution timer for performance measurement.
More efficient than `System.Diagnostics.Stopwatch` with a simpler API.

- **Kind:** struct
- **Namespace:** `Sandbox.Diagnostics`
- **Assembly:** `Sandbox.System`

## Properties

- `System.Int64 StartTick`
  - Gets the timestamp when the timer was started.
- `System.Int64 ElapsedTicks`
  - Gets the number of ticks elapsed since the timer was started.
- `System.Double ElapsedMicroSeconds`
  - Gets the number of microseconds elapsed since the timer was started.
- `System.Double ElapsedMilliSeconds`
  - Gets the number of milliseconds elapsed since the timer was started.
- `System.Double ElapsedSeconds`
  - Gets the number of seconds elapsed since the timer was started.
- `System.TimeSpan Elapsed`
  - Gets the time elapsed since the timer was started as a TimeSpan.

## Methods

### Static methods

- `static Sandbox.Diagnostics.FastTimer StartNew()`
  - Creates and starts a new FastTimer.
  - returns: A started FastTimer

### Instance methods

- `System.Void Start()`
  - Starts or restarts the timer.
