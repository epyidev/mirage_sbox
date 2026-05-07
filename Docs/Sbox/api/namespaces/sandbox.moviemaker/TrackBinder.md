# Sandbox.MovieMaker.TrackBinder

Controls which `Sandbox.MovieMaker.ITrackTarget`s from a scene are controlled by which `Sandbox.MovieMaker.ITrack` from a `Sandbox.MovieMaker.IMovieClip`.
Can be serialized to save which tracks are bound to which targets.

- **Kind:** sealed class
- **Namespace:** `Sandbox.MovieMaker`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `TrackBinder(Sandbox.Scene scene)`
  - Controls which `Sandbox.MovieMaker.ITrackTarget`s from a scene are controlled by which `Sandbox.MovieMaker.ITrack` from a `Sandbox.MovieMaker.IMovieClip`.
Can be serialized to save which tracks are bound to which targets.

## Properties

- `Sandbox.Scene Scene`
  - The scene this binder is targeting.
- `static Sandbox.MovieMaker.TrackBinder Default`
  - Gets the default binder for the active scene.

## Methods

### Instance methods

- `System.Void CreateTargets(Sandbox.MovieMaker.IMovieClip clip, System.Boolean replace, Sandbox.GameObject rootParent)`
  - Creates any missing `Sandbox.GameObject`s or `Sandbox.Component`s for the given `clip` to target.
- `System.Void CreateTargets(System.Collections.Generic.IEnumerable<Sandbox.MovieMaker.IReferenceTrack> tracks, System.Boolean replace, Sandbox.GameObject rootParent)`
- `System.Void DestroyTargets()`
  - Destroy any instances created by `Sandbox.MovieMaker.TrackBinder.CreateTargets(Sandbox.MovieMaker.IMovieClip,System.Boolean,Sandbox.GameObject)`.
- `System.Void Add(Sandbox.MovieMaker.IReferenceTrack track, Sandbox.IValid target)`
- `Sandbox.MovieMaker.ITrackTarget Get(Sandbox.MovieMaker.ITrack track)`
  - Gets or creates a target that maps to the given `track`.
The target might not be bound to anything in the scene yet, use `Sandbox.MovieMaker.ITrackTarget.IsBound` to check.
- `Sandbox.MovieMaker.ITrackReference Get(Sandbox.MovieMaker.IReferenceTrack track)`
- `Sandbox.MovieMaker.ITrackReference<T> Get(Sandbox.MovieMaker.IReferenceTrack<T> track)`
- `Sandbox.MovieMaker.ITrackProperty Get(Sandbox.MovieMaker.IPropertyTrack track)`
- `Sandbox.MovieMaker.ITrackProperty<T> Get(Sandbox.MovieMaker.IPropertyTrack<T> track)`
- `System.Collections.Generic.IEnumerable<Sandbox.MovieMaker.ITrackReference<T>> GetReferences(Sandbox.MovieMaker.IMovieClip clip)`
  - Get all reference targets for tracks in the given `clip`.
  - `clip`: Movie clip to find track bindings for.
- `System.Collections.Generic.IEnumerable<Sandbox.MovieMaker.ITrackProperty<T>> GetProperties(Sandbox.MovieMaker.IMovieClip clip)`
  - Get all property targets for tracks in the given `clip`.
  - `clip`: Movie clip to find track bindings for.
- `System.Collections.Generic.IEnumerable<T> GetComponents(Sandbox.MovieMaker.IMovieClip clip)`
  - Get all bound component references for tracks in the given `clip`.
  - `clip`: Movie clip to find track bindings for.
- `virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Guid,Sandbox.IValid>> GetEnumerator()`
- `System.Collections.Generic.IEnumerable<System.Guid> GetTrackIds(Sandbox.IValid gameObjectOrComponent)`
  - Finds track IDs currently explicitly bound to the given `gameObjectOrComponent`.
- `System.Nullable<System.Guid> GetTrackId(Sandbox.IValid gameObjectOrComponent)`
- `System.Boolean TryGetBinding(System.Guid trackId, Sandbox.IValid target)`
  - Returns true if there's an existing mapping for the given `trackId`,
and outputs that mapping as `target`. Note that `null`
is a valid binding, to force a track to map to nothing.
- `System.Boolean TryGetBinding(System.Guid trackId, T target)`
- `virtual System.Text.Json.Nodes.JsonNode Serialize()`
- `virtual System.Void Deserialize(System.Text.Json.Nodes.JsonNode node)`
