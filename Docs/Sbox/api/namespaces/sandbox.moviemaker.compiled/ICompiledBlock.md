# Sandbox.MovieMaker.Compiled.ICompiledBlock

A block of time where something happens in an `Sandbox.MovieMaker.Compiled.ICompiledTrack`.

- **Kind:** interface
- **Namespace:** `Sandbox.MovieMaker.Compiled`
- **Assembly:** `Sandbox.Engine`

## Methods

### Instance methods

- `virtual Sandbox.MovieMaker.Compiled.ICompiledBlock Shift(Sandbox.MovieMaker.MovieTime offset)`
  - Move this block by the given time `offset`.
- `virtual Sandbox.MovieMaker.Compiled.ICompiledBlock Clamp(Sandbox.MovieMaker.MovieTimeRange range)`
  - Trim this block down to the given `range`.
  - `range`: Time range to clamp to.
