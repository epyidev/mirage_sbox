# Sandbox.MovieMaker.Compiled.CompiledPropertyTrack<T>

- **Kind:** sealed class
- **Namespace:** `Sandbox.MovieMaker.Compiled`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `CompiledPropertyTrack<T>(System.String Name, Sandbox.MovieMaker.Compiled.ICompiledTrack Parent, System.Collections.Immutable.ImmutableArray<Sandbox.MovieMaker.Compiled.ICompiledPropertyBlock<T>> Blocks)`
- `CompiledPropertyTrack<T>(System.String name, Sandbox.MovieMaker.Compiled.ICompiledTrack parent, System.Collections.Generic.IEnumerable<Sandbox.MovieMaker.Compiled.ICompiledPropertyBlock> blocks)`

## Properties

- `System.String Name`
- `Sandbox.MovieMaker.Compiled.ICompiledTrack Parent`
- `System.Collections.Immutable.ImmutableArray<Sandbox.MovieMaker.Compiled.ICompiledPropertyBlock<T>> Blocks`

## Methods

### Instance methods

- `Sandbox.MovieMaker.Compiled.ICompiledPropertyBlock<T> GetBlock(Sandbox.MovieMaker.MovieTime time)`
- `virtual System.Boolean TryGetValue(Sandbox.MovieMaker.MovieTime time, T value)`
- `Sandbox.MovieMaker.Compiled.CompiledPropertyTrack<T> <Clone>$()`
- `System.Void Deconstruct(System.String Name, Sandbox.MovieMaker.Compiled.ICompiledTrack Parent, System.Collections.Immutable.ImmutableArray<Sandbox.MovieMaker.Compiled.ICompiledPropertyBlock<T>> Blocks)`
