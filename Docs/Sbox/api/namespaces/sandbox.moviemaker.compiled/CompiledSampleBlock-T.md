# Sandbox.MovieMaker.Compiled.CompiledSampleBlock<T>

This block contains an array of values sampled at uniform intervals.

- **Kind:** sealed class
- **Namespace:** `Sandbox.MovieMaker.Compiled`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `CompiledSampleBlock<T>(Sandbox.MovieMaker.MovieTimeRange TimeRange, Sandbox.MovieMaker.MovieTime Offset, System.Int32 SampleRate, System.Collections.Immutable.ImmutableArray<T> Samples)`

## Properties

- `Sandbox.MovieMaker.MovieTimeRange TimeRange`
  - Start and end time of this block.
- `Sandbox.MovieMaker.MovieTime Offset`
  - Time offset of the first sample.
- `System.Int32 SampleRate`
  - How many samples per second.
- `System.Collections.Immutable.ImmutableArray<T> Samples`

## Methods

### Instance methods

- `virtual T GetValue(Sandbox.MovieMaker.MovieTime time)`
- `virtual Sandbox.MovieMaker.Compiled.ICompiledPropertyBlock<T> Shift(Sandbox.MovieMaker.MovieTime offset)`
- `virtual Sandbox.MovieMaker.Compiled.ICompiledPropertyBlock<T> Clamp(Sandbox.MovieMaker.MovieTimeRange range)`
- `Sandbox.MovieMaker.Compiled.ICompiledPropertyBlock<T> Reduce()`
  - Returns a property block with only sample data within `Sandbox.MovieMaker.Compiled.CompiledSampleBlock`1.TimeRange`.
Returns the current instance if it represents an irreducible block.
If only one sample is needed, will return a `Sandbox.MovieMaker.Compiled.CompiledConstantBlock`1`.
- `Sandbox.MovieMaker.Compiled.CompiledSampleBlock<T> <Clone>$()`
- `System.Void Deconstruct(Sandbox.MovieMaker.MovieTimeRange TimeRange, Sandbox.MovieMaker.MovieTime Offset, System.Int32 SampleRate, System.Collections.Immutable.ImmutableArray<T> Samples)`
