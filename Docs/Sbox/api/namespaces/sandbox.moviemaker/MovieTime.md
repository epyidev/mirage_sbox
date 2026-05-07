# Sandbox.MovieMaker.MovieTime

Represents a duration of time in a movie. Uses fixed point so precision is consistent at any absolute time.
Defaults to `Sandbox.MovieMaker.MovieTime.Zero`.

- **Kind:** struct
- **Namespace:** `Sandbox.MovieMaker`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static Sandbox.MovieMaker.MovieTime Zero`
- `static Sandbox.MovieMaker.MovieTime Epsilon`
- `static Sandbox.MovieMaker.MovieTime MinValue`
- `static Sandbox.MovieMaker.MovieTime MaxValue`
- `static System.Collections.Generic.IReadOnlyList<System.Int32> SupportedFrameRates`
  - Frame rates `&lt;= 120` that can be perfectly represented by `Sandbox.MovieMaker.MovieTime.TickRate`, in ascending order.
Venturing outside these rates will lead to some frames being slightly different durations than others.
- `System.Int32 Ticks`
- `System.Boolean IsZero`
- `System.Boolean IsPositive`
- `System.Boolean IsNegative`
- `System.Double TotalSeconds`
- `Sandbox.MovieMaker.MovieTime Absolute`

## Fields

- `static System.Int32 TickRate`
  - How many `Sandbox.MovieMaker.MovieTime.Ticks` per second. This value should nicely divide into
common frame rates.

## Methods

### Static methods

- `static Sandbox.MovieMaker.MovieTime FromTicks(System.Int32 ticks)`
- `static Sandbox.MovieMaker.MovieTime FromSeconds(System.Double time)`
- `static Sandbox.MovieMaker.MovieTime FromFrames(System.Int32 frameCount, System.Int32 frameRate)`
- `static Sandbox.MovieMaker.MovieTime Max(Sandbox.MovieMaker.MovieTime a, Sandbox.MovieMaker.MovieTime b)`
- `static Sandbox.MovieMaker.MovieTime Min(Sandbox.MovieMaker.MovieTime a, Sandbox.MovieMaker.MovieTime b)`
- `static Sandbox.MovieMaker.MovieTime Distance(Sandbox.MovieMaker.MovieTime a, Sandbox.MovieMaker.MovieTime b)`
- `static Sandbox.MovieMaker.MovieTime Lerp(Sandbox.MovieMaker.MovieTime a, Sandbox.MovieMaker.MovieTime b, System.Double fraction)`

### Instance methods

- `Sandbox.MovieMaker.MovieTime Clamp(System.Nullable<Sandbox.MovieMaker.MovieTimeRange> range)`
- `Sandbox.MovieMaker.MovieTime Floor(Sandbox.MovieMaker.MovieTime gridInterval)`
- `Sandbox.MovieMaker.MovieTime Round(Sandbox.MovieMaker.MovieTime gridInterval)`
- `System.Int32 GetFrameIndex(System.Int32 frameRate)`
  - Given a `frameRate`, how many frames have passed before reaching
this time.
- `System.Int32 GetFrameIndex(System.Int32 frameRate, Sandbox.MovieMaker.MovieTime remainder)`
  - Given a `frameRate`, how many frames have passed before reaching
this time, and how far into the current frame are we.
- `System.Int32 GetFrameIndex(Sandbox.MovieMaker.MovieTime frameInterval)`
- `System.Int32 GetFrameIndex(Sandbox.MovieMaker.MovieTime frameInterval, Sandbox.MovieMaker.MovieTime remainder)`
- `System.Int32 GetFrameCount(System.Int32 frameRate)`
  - Given a `frameRate`, how many frames would need to be allocated
to represent every moment of time up until now. This is always at least `1`,
and will be `1` more than `Sandbox.MovieMaker.MovieTime.GetFrameIndex(System.Int32)` unless this time
is exactly on a frame boundary.
- `System.Single GetFraction(Sandbox.MovieMaker.MovieTime time)`
- `virtual System.Int32 CompareTo(Sandbox.MovieMaker.MovieTime other)`
