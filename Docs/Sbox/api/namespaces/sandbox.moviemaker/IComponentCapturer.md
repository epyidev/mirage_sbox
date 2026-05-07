# Sandbox.MovieMaker.IComponentCapturer

When added to a `Sandbox.MovieMaker.MovieRecorderOptions`, handles how to capture the properties of
a particular component type.

- **Kind:** interface
- **Namespace:** `Sandbox.MovieMaker`
- **Assembly:** `Sandbox.Engine`

## Methods

### Instance methods

- `virtual System.Boolean SupportsType(System.Type componentType)`
  - Returns true if this recorder can handle the given `componentType`.
- `virtual System.Void Capture(Sandbox.MovieMaker.IMovieTrackRecorder recorder, Sandbox.Component component)`
  - Handle capturing the properties of the given `component` instance.
Find properties to capture using `Sandbox.MovieMaker.IMovieTrackRecorder.Property(System.String)`, then call `Sandbox.MovieMaker.IMovieTrackRecorder.Capture` on them.
