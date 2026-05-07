# Sandbox.MovieMaker.IMovieTrackRecorder

Watches some object or property in the scene, capturing
its state whenever `Sandbox.MovieMaker.IMovieTrackRecorder.Capture` is called.

- **Kind:** interface
- **Namespace:** `Sandbox.MovieMaker`
- **Assembly:** `Sandbox.Engine`

## Properties

- `Sandbox.MovieMaker.ITrack Track`
  - Describes the track this recorder is recording to.
- `System.Collections.Generic.IEnumerable<Sandbox.MovieMaker.IPropertyBlock> Blocks`
  - Currently recorded data for this track.

## Methods

### Instance methods

- `virtual Sandbox.MovieMaker.IMovieTrackRecorder Property(System.String name)`
  - Gets or creates a recorder for the named sub-property.
  - `name`: Property name.
- `virtual System.Void Capture()`
  - Write the current state of the recorded object or property to the owning `Sandbox.MovieMaker.MovieRecorder`.
- `virtual System.Collections.Generic.IEnumerable<Sandbox.MovieMaker.Compiled.ICompiledTrack> Compile(Sandbox.MovieMaker.MovieTimeRange timeRange)`
  - Compiles captured values for this property and all sub-properties into tracks.
