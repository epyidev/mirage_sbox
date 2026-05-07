# Sandbox.Curve

Describes a curve, which can have multiple key frames.

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Constructors

- `Curve(System.Collections.Immutable.ImmutableArray<Sandbox.Curve.Frame> frames)`
- `Curve(System.Collections.Generic.IEnumerable<Sandbox.Curve.Frame> frames)`
- `Curve(Sandbox.Curve.Frame[] frames)`
- `Curve()`

## Properties

- `Vector2 TimeRange`
  - The range of this curve. This affects looping.
- `Vector2 ValueRange`
  - The value range. This should affect nothing but what it looks like in the editor.
- `System.Int32 Length`
  - Amount of key frames or points on the curve.
- `Sandbox.Curve.Frame Item`

## Fields

- `static Sandbox.Curve Linear`
  - A curve that linearly interpolates from 0 to 1
- `static Sandbox.Curve Ease`
  - A curve that eases from 0 to 1
- `static Sandbox.Curve EaseIn`
  - A curve that eases in from 0 to 1
- `static Sandbox.Curve EaseOut`
  - A curve that eases out from 0 to 1
- `System.Collections.Immutable.ImmutableArray<Sandbox.Curve.Frame> Frames`
  - A list of keyframes or points on the curve.

## Methods

### Instance methods

- `Sandbox.Curve WithFrames(System.Collections.Immutable.ImmutableList<Sandbox.Curve.Frame> frames)`
- `Sandbox.Curve WithFrames(System.Collections.Immutable.ImmutableArray<Sandbox.Curve.Frame> frames)`
- `Sandbox.Curve WithFrames(System.Collections.Generic.IEnumerable<Sandbox.Curve.Frame> frames)`
- `Sandbox.Curve Reverse()`
  - Make a copy of this curve that is reversed (If input eases from 0 to 1 then output will ease from 1 to 0)
- `System.Int32 AddPoint(System.Single x, System.Single y)`
  - Add a new keyframe at given position to this curve.
  - `x`: Position of the keyframe on the X axis.
  - `y`: Position of the keyframe on the Y axis.
  - returns: The position of newly added keyframe in the `Sandbox.Curve.Frames` list.
- `System.Int32 AddPoint(Sandbox.Curve.Frame keyframe)`
  - Add given keyframe to this curve.
  - `keyframe`: The keyframe to add.
  - returns: The position of newly added keyframe in the `Sandbox.Curve.Frames` list.
- `System.Void RemoveAtTime(System.Single time, System.Single within)`
  - Remove all of the frames at the current time
- `System.Void Sort()`
  - Make sure we're all sorted by time
- `System.Boolean AddOrReplacePoint(Sandbox.Curve.Frame keyframe)`
  - Add given keyframe to this curve.
  - returns: True if we added a new point. False if we just edited an existing point.
- `System.Single Evaluate(System.Single time, System.Boolean angles)`
  - Returns the value on the curve at given time position.
  - `time`: The time point (x axis) at which
  - `angles`: Is this an angle?
  - returns: The absolute value at given time. (y axis)
- `System.Single Evaluate(System.Single time)`
  - Returns the value on the curve at given time position.
  - `time`: The time point (x axis) at which
  - returns: The absolute value at given time. (y axis)
- `System.Single EvaluateDelta(System.Single time)`
  - Like evaluate but takes a normalized time between 0 and 1 and returns a normalized value between 0 and 1
- `System.Single EvaluateDelta(System.Single time, System.Boolean angles)`
  - Like evaluate but takes a normalized time between 0 and 1 and returns a normalized value between 0 and 1
- `System.Void Fix()`
  - If the curve is broken in some way, we can fix it here.
Ensures correct time and value ranges, and that the curve has at least one point.
- `System.Void UpdateValueRange(Vector2 newRange, System.Boolean retainValues)`
- `System.Void UpdateTimeRange(Vector2 newRange, System.Boolean retainTimes)`
