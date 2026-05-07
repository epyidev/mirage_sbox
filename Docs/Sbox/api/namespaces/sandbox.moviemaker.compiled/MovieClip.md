# Sandbox.MovieMaker.Compiled.MovieClip

An immutable compiled `Sandbox.MovieMaker.IMovieClip` designed to be serialized.

- **Kind:** sealed class
- **Namespace:** `Sandbox.MovieMaker.Compiled`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static Sandbox.MovieMaker.Compiled.MovieClip Empty`
  - A clip with no tracks.
- `System.Collections.Immutable.ImmutableArray<Sandbox.MovieMaker.Compiled.ICompiledTrack> Tracks`
- `Sandbox.MovieMaker.MovieTime Duration`

## Methods

### Static methods

- `static Sandbox.MovieMaker.Compiled.MovieClip FromTracks(Sandbox.MovieMaker.Compiled.ICompiledTrack[] tracks)`
- `static Sandbox.MovieMaker.Compiled.MovieClip FromTracks(System.Collections.Generic.IEnumerable<Sandbox.MovieMaker.Compiled.ICompiledTrack> tracks)`
- `static Sandbox.MovieMaker.Compiled.CompiledReferenceTrack<Sandbox.GameObject> RootGameObject(System.String name, System.Nullable<System.Guid> id, Sandbox.MovieMaker.TrackMetadata metadata)`
- `static Sandbox.MovieMaker.Compiled.ICompiledReferenceTrack RootComponent(System.Type type, System.Nullable<System.Guid> id)`
- `static Sandbox.MovieMaker.Compiled.CompiledReferenceTrack<T> RootComponent(System.Nullable<System.Guid> id)`

### Instance methods

- `Sandbox.MovieMaker.Compiled.ICompiledReferenceTrack GetTrack(System.Guid trackId)`
- `Sandbox.MovieMaker.IMovieResource ToResource()`
