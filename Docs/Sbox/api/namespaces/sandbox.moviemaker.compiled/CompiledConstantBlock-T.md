# Sandbox.MovieMaker.Compiled.CompiledConstantBlock<T>

This block has a single constant value for the whole duration.
Useful for value types that can't be interpolated, and change infrequently.

- **Kind:** sealed class
- **Namespace:** `Sandbox.MovieMaker.Compiled`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `CompiledConstantBlock<T>(Sandbox.MovieMaker.MovieTimeRange TimeRange, System.Text.Json.Nodes.JsonNode Serialized)`
  - This block has a single constant value for the whole duration.
Useful for value types that can't be interpolated, and change infrequently.
  - `TimeRange`: Start and end time of this block.
  - `Serialized`: Json-serialized constant value.
- `CompiledConstantBlock<T>(Sandbox.MovieMaker.MovieTimeRange timeRange, T value)`

## Properties

- `Sandbox.MovieMaker.MovieTimeRange TimeRange`
  - Start and end time of this block.
- `System.Text.Json.Nodes.JsonNode Serialized`

## Methods

### Instance methods

- `virtual T GetValue(Sandbox.MovieMaker.MovieTime time)`
- `virtual Sandbox.MovieMaker.Compiled.ICompiledPropertyBlock<T> Shift(Sandbox.MovieMaker.MovieTime offset)`
- `virtual Sandbox.MovieMaker.Compiled.ICompiledPropertyBlock<T> Clamp(Sandbox.MovieMaker.MovieTimeRange range)`
- `Sandbox.MovieMaker.Compiled.CompiledConstantBlock<T> <Clone>$()`
- `System.Void Deconstruct(Sandbox.MovieMaker.MovieTimeRange TimeRange, System.Text.Json.Nodes.JsonNode Serialized)`
