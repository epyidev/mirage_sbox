# Sandbox.MovieMaker.Compiled.CompiledClipExtensions

Helper methods for working with `Sandbox.MovieMaker.Compiled.MovieClip`, `Sandbox.MovieMaker.Compiled.ICompiledTrack`, or `Sandbox.MovieMaker.Compiled.ICompiledBlock`.

- **Kind:** static class
- **Namespace:** `Sandbox.MovieMaker.Compiled`
- **Assembly:** `Sandbox.Engine`

## Methods

### Static methods

- `static Sandbox.MovieMaker.Compiled.CompiledReferenceTrack<Sandbox.GameObject> GameObject(Sandbox.MovieMaker.Compiled.CompiledReferenceTrack<Sandbox.GameObject> track, System.String name, System.Nullable<System.Guid> id, Sandbox.MovieMaker.TrackMetadata metadata)`
- `static Sandbox.MovieMaker.Compiled.ICompiledReferenceTrack Component(Sandbox.MovieMaker.Compiled.CompiledReferenceTrack<Sandbox.GameObject> track, System.Type type, System.Nullable<System.Guid> id, Sandbox.MovieMaker.TrackMetadata metadata)`
- `static Sandbox.MovieMaker.Compiled.CompiledReferenceTrack<T> Component(Sandbox.MovieMaker.Compiled.CompiledReferenceTrack<Sandbox.GameObject> track, System.Nullable<System.Guid> id, Sandbox.MovieMaker.TrackMetadata metadata)`
- `static Sandbox.MovieMaker.Compiled.CompiledPropertyTrack<T> Property(Sandbox.MovieMaker.Compiled.ICompiledTrack track, System.String name, System.Collections.Generic.IEnumerable<Sandbox.MovieMaker.Compiled.ICompiledPropertyBlock<T>> blocks)`
- `static Sandbox.MovieMaker.Compiled.CompiledPropertyTrack<Sandbox.MovieMaker.Properties.BindingReference<T>> ReferenceProperty(Sandbox.MovieMaker.Compiled.ICompiledTrack track, System.String name, System.Collections.Generic.IEnumerable<Sandbox.MovieMaker.Compiled.ICompiledPropertyBlock<Sandbox.MovieMaker.Properties.BindingReference<T>>> blocks)`
- `static Sandbox.MovieMaker.Compiled.ICompiledPropertyTrack Property(Sandbox.MovieMaker.Compiled.ICompiledTrack track, System.String name, System.Type type, System.Collections.Generic.IEnumerable<Sandbox.MovieMaker.Compiled.ICompiledPropertyBlock> blocks)`
- `static Sandbox.MovieMaker.Compiled.CompiledPropertyTrack<TItem> Item(Sandbox.MovieMaker.Compiled.CompiledPropertyTrack<System.Collections.Generic.List<TItem>> track, System.Int32 index, System.Collections.Generic.IEnumerable<Sandbox.MovieMaker.Compiled.ICompiledPropertyBlock<TItem>> blocks)`
- `static Sandbox.MovieMaker.Compiled.ICompiledTrack Child(Sandbox.MovieMaker.Compiled.ICompiledTrack track, System.String name, System.Type type)`
  - Helper for creating a compiled child track with the given `name` and value `type`.



Some special cases if the parent track is a `Sandbox.GameObject` reference track:
            - `type` is `Sandbox.GameObject`Returns a game object reference track- `type` extends `Sandbox.Component`Returns a component reference track
            By default, returns a property track.
- `static Sandbox.MovieMaker.Compiled.CompiledPropertyTrack<T> WithConstant(Sandbox.MovieMaker.Compiled.CompiledPropertyTrack<T> track, Sandbox.MovieMaker.MovieTimeRange timeRange, T value)`
- `static Sandbox.MovieMaker.Compiled.CompiledPropertyTrack<T> WithSamples(Sandbox.MovieMaker.Compiled.CompiledPropertyTrack<T> track, Sandbox.MovieMaker.MovieTimeRange timeRange, System.Int32 sampleRate, System.Collections.Generic.IEnumerable<T> values)`
- `static T Sample(System.Collections.Generic.IReadOnlyList<T> samples, Sandbox.MovieMaker.MovieTime time, System.Int32 sampleRate, Sandbox.MovieMaker.IInterpolator<T> interpolator)`
