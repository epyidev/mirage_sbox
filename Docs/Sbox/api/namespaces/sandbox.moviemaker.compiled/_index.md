# Namespace `Sandbox.MovieMaker.Compiled`

17 types.

## Classes

- [`CompiledActionBlock`](./CompiledActionBlock.md) - Unused, will describe starting / stopping an action in the scene.
- [`CompiledActionTrack`](./CompiledActionTrack.md)
- [`CompiledConstantBlock<T>`](./CompiledConstantBlock-T.md) - This block has a single constant value for the whole duration.
- [`CompiledPropertyTrack<T>`](./CompiledPropertyTrack-T.md)
- [`CompiledReferenceTrack<T>`](./CompiledReferenceTrack-T.md)
- [`CompiledSampleBlock<T>`](./CompiledSampleBlock-T.md) - This block contains an array of values sampled at uniform intervals.
- [`MovieClip`](./MovieClip.md) - An immutable compiled `Sandbox.MovieMaker.IMovieClip` designed to be serialized.

## Static classes

- [`CompiledClipExtensions`](./CompiledClipExtensions.md) - Helper methods for working with `Sandbox.MovieMaker.Compiled.MovieClip`, `Sandbox.MovieMaker.Compiled.ICompiledTrack`, or `Sandbox.MovieMaker.Compiled.ICompiledBlock`.

## Interfaces

- [`ICompiledBlock`](./ICompiledBlock.md) - A block of time where something happens in an `Sandbox.MovieMaker.Compiled.ICompiledTrack`.
- [`ICompiledBlockTrack`](./ICompiledBlockTrack.md)
- [`ICompiledConstantBlock`](./ICompiledConstantBlock.md) - This block has a single constant value for the whole duration.
- [`ICompiledPropertyBlock`](./ICompiledPropertyBlock.md) - Interface for blocks describing a property changing value over time.
- [`ICompiledPropertyBlock<T>`](./ICompiledPropertyBlock-T.md) - Interface for blocks describing a property changing value over time.
- [`ICompiledPropertyTrack`](./ICompiledPropertyTrack.md)
- [`ICompiledReferenceTrack`](./ICompiledReferenceTrack.md)
- [`ICompiledSampleBlock`](./ICompiledSampleBlock.md) - This block contains an array of values sampled at uniform intervals.
- [`ICompiledTrack`](./ICompiledTrack.md)
