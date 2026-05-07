# Sandbox.MovieMaker.Compiled.CompiledActionBlock

Unused, will describe starting / stopping an action in the scene.

- **Kind:** sealed class
- **Namespace:** `Sandbox.MovieMaker.Compiled`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `CompiledActionBlock(Sandbox.MovieMaker.MovieTimeRange TimeRange)`
  - Unused, will describe starting / stopping an action in the scene.
  - `TimeRange`: Start and end time of this block.

## Properties

- `Sandbox.MovieMaker.MovieTimeRange TimeRange`
  - Start and end time of this block.

## Methods

### Instance methods

- `virtual Sandbox.MovieMaker.Compiled.ICompiledBlock Shift(Sandbox.MovieMaker.MovieTime offset)`
- `virtual Sandbox.MovieMaker.Compiled.ICompiledBlock Clamp(Sandbox.MovieMaker.MovieTimeRange range)`
- `Sandbox.MovieMaker.Compiled.CompiledActionBlock <Clone>$()`
- `System.Void Deconstruct(Sandbox.MovieMaker.MovieTimeRange TimeRange)`
