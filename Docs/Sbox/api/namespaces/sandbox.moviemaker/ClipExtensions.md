# Sandbox.MovieMaker.ClipExtensions

Helper methods for working with `Sandbox.MovieMaker.IMovieClip` and `Sandbox.MovieMaker.ITrack`.

- **Kind:** static class
- **Namespace:** `Sandbox.MovieMaker`
- **Assembly:** `Sandbox.Engine`

## Methods

### Static methods

- `static System.Int32 GetDepth(Sandbox.MovieMaker.ITrack track)`
  - How deeply are we nested? Root tracks have depth `0`.
- `static System.ValueTuple<Sandbox.MovieMaker.IReferenceTrack,System.Collections.Generic.IReadOnlyList<System.String>> GetPath(Sandbox.MovieMaker.ITrack track, System.Boolean full)`
- `static System.String GetPathString(Sandbox.MovieMaker.ITrack track, System.Boolean full)`
- `static Sandbox.MovieMaker.ITrack GetTrack(Sandbox.MovieMaker.IMovieClip clip, System.String[] path)`
  - Searches `clip` for a track with the given `path`,
starting from the root level of the clip.
- `static Sandbox.MovieMaker.Compiled.ICompiledTrack GetTrack(Sandbox.MovieMaker.Compiled.MovieClip clip, System.String[] path)`
- `static Sandbox.MovieMaker.IReferenceTrack<T> GetReference(Sandbox.MovieMaker.IMovieClip clip, System.String[] path)`
  - Searches `clip` for a track with the given `path`,
starting from the root level of the clip.
- `static Sandbox.MovieMaker.Compiled.CompiledReferenceTrack<T> GetReference(Sandbox.MovieMaker.Compiled.MovieClip clip, System.String[] path)`
- `static Sandbox.MovieMaker.IPropertyTrack<T> GetProperty(Sandbox.MovieMaker.IMovieClip clip, System.String[] path)`
  - Searches `clip` for a property track with the given `path`,
starting from the root level of the clip.
- `static Sandbox.MovieMaker.IPropertyTrack<T> GetProperty(Sandbox.MovieMaker.IMovieClip clip, System.Guid refTrackId, System.Collections.Generic.IReadOnlyList<System.String> path)`
- `static Sandbox.MovieMaker.Compiled.CompiledPropertyTrack<T> GetProperty(Sandbox.MovieMaker.Compiled.MovieClip clip, System.String[] path)`
- `static Sandbox.MovieMaker.Compiled.CompiledPropertyTrack<T> GetProperty(Sandbox.MovieMaker.Compiled.MovieClip clip, System.Guid refTrackId, System.Collections.Generic.IReadOnlyList<System.String> path)`
- `static Sandbox.MovieMaker.Compiled.CompiledPropertyTrack<Sandbox.MovieMaker.Properties.BindingReference<T>> GetReferenceProperty(Sandbox.MovieMaker.Compiled.MovieClip clip, System.String[] path)`
- `static System.Boolean Update(Sandbox.MovieMaker.IMovieClip clip, Sandbox.MovieMaker.MovieTime time, Sandbox.MovieMaker.TrackBinder binder)`
  - For each track in the given `clip` that we have a mapped property for,
set the property value to whatever value is stored in that track at the given `time`.
- `static System.Boolean Update(Sandbox.MovieMaker.IPropertyTrack track, Sandbox.MovieMaker.MovieTime time, Sandbox.MovieMaker.TrackBinder binder)`
  - If we have a mapped property for `track`, set the property value to whatever value
is stored in the track at the given `time`.
- `static System.Boolean Update(Sandbox.MovieMaker.IPropertyTrack<T> track, Sandbox.MovieMaker.MovieTime time, Sandbox.MovieMaker.TrackBinder binder)`
