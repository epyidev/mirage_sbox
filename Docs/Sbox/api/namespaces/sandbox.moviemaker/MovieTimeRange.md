# Sandbox.MovieMaker.MovieTimeRange

Represents a segment of time, given by `Sandbox.MovieMaker.MovieTimeRange.Start` and `Sandbox.MovieMaker.MovieTimeRange.End` times.

- **Kind:** struct
- **Namespace:** `Sandbox.MovieMaker`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `MovieTimeRange(Sandbox.MovieMaker.MovieTime Start, Sandbox.MovieMaker.MovieTime End)`
  - Represents a segment of time, given by `Sandbox.MovieMaker.MovieTimeRange.Start` and `Sandbox.MovieMaker.MovieTimeRange.End` times.
  - `Start`: Minimum time in the range.
  - `End`: Maximum time in the range.

## Properties

- `Sandbox.MovieMaker.MovieTime Start`
  - Minimum time in the range.
- `Sandbox.MovieMaker.MovieTime End`
  - Maximum time in the range.
- `Sandbox.MovieMaker.MovieTime Duration`
- `Sandbox.MovieMaker.MovieTime Center`
- `System.Boolean IsEmpty`

## Methods

### Instance methods

- `System.Nullable<Sandbox.MovieMaker.MovieTimeRange> Intersect(Sandbox.MovieMaker.MovieTimeRange other)`
- `Sandbox.MovieMaker.MovieTimeRange Union(System.Nullable<Sandbox.MovieMaker.MovieTimeRange> other)`
- `Sandbox.MovieMaker.MovieTimeRange Clamp(System.Nullable<Sandbox.MovieMaker.MovieTimeRange> range)`
- `Sandbox.MovieMaker.MovieTimeRange ClampStart(System.Nullable<Sandbox.MovieMaker.MovieTime> start)`
- `Sandbox.MovieMaker.MovieTimeRange ClampEnd(System.Nullable<Sandbox.MovieMaker.MovieTime> end)`
- `Sandbox.MovieMaker.MovieTimeRange Grow(Sandbox.MovieMaker.MovieTime startEndDelta)`
- `Sandbox.MovieMaker.MovieTimeRange Grow(Sandbox.MovieMaker.MovieTime startDelta, Sandbox.MovieMaker.MovieTime endDelta)`
- `System.Boolean Contains(Sandbox.MovieMaker.MovieTime time)`
- `System.Boolean Contains(Sandbox.MovieMaker.MovieTimeRange timeRange)`
- `System.Single GetFraction(Sandbox.MovieMaker.MovieTime time)`
- `System.Collections.Generic.IEnumerable<Sandbox.MovieMaker.MovieTime> GetSampleTimes(System.Int32 sampleRate)`
- `System.Collections.Generic.IEnumerable<Sandbox.MovieMaker.MovieTime> GetSampleTimes(Sandbox.MovieMaker.MovieTime firstSampleTime, System.Int32 sampleCount, System.Int32 sampleRate)`
- `System.Void Deconstruct(Sandbox.MovieMaker.MovieTime Start, Sandbox.MovieMaker.MovieTime End)`
