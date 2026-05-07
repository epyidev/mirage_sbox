# Sandbox.MovieMaker.MovieRecorderOptions

Configures a `Sandbox.MovieMaker.MovieRecorder`, deciding how often it captures and which properties
should be recorded.

- **Kind:** sealed class
- **Namespace:** `Sandbox.MovieMaker`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `MovieRecorderOptions(System.Int32 SampleRate, System.Nullable<Sandbox.MovieMaker.MovieTime> BufferDuration)`

## Properties

- `System.Int32 SampleRate`
  - How often to capture the value of recorded properties.
- `System.Nullable<Sandbox.MovieMaker.MovieTime> BufferDuration`
  - Keep only the most recent samples in memory, with this duration. If `null`,
samples won't be discarded and the recording will keep growing in size until stopped.
- `static Sandbox.MovieMaker.MovieRecorderOptions Default`
  - Default options, using `Sandbox.MovieMaker.MovieRecorderOptions.WithDefaultCaptureActions` and `Sandbox.MovieMaker.MovieRecorderOptions.WithDefaultComponentCapturers`.
- `System.Collections.Immutable.ImmutableArray<Sandbox.MovieMaker.MovieRecorderFilter> Filters`
  - Decide which objects are allowed to be recorded. Called the first time a `Sandbox.GameObject` is passed to
`Sandbox.MovieMaker.MovieRecorder.GetTrackRecorder(Sandbox.GameObject)`, which will return `null` if any
delegate in this list returns `false`.
- `System.Collections.Immutable.ImmutableArray<Sandbox.MovieMaker.MovieRecorderAction> CaptureActions`
  - Delegates called each time `Sandbox.MovieMaker.MovieRecorder.Capture` is invoked, to control which objects should be recorded.
These actions will call `Sandbox.MovieMaker.IMovieTrackRecorder.Capture` on one or more track recorders.
- `System.Collections.Immutable.ImmutableArray<Sandbox.MovieMaker.IComponentCapturer> ComponentCapturers`
  - When `Sandbox.MovieMaker.IMovieTrackRecorder.Capture` is called on a component track, any instances in this list that
match the component type will be used to decide which properties on that component should be recorded.

## Fields

- `static System.Int32 DefaultSampleRate`
  - Default value for `Sandbox.MovieMaker.MovieRecorderOptions.SampleRate`.

## Methods

### Instance methods

- `Sandbox.MovieMaker.MovieRecorderOptions WithFilter(Sandbox.MovieMaker.MovieRecorderFilter filter)`
- `Sandbox.MovieMaker.MovieRecorderOptions WithCaptureAction(Sandbox.MovieMaker.MovieRecorderAction action)`
- `Sandbox.MovieMaker.MovieRecorderOptions WithComponentCapturer()`
- `Sandbox.MovieMaker.MovieRecorderOptions WithComponentCapturer(Sandbox.MovieMaker.IComponentCapturer recorder)`
- `Sandbox.MovieMaker.MovieRecorderOptions WithCaptureAll(System.Func<T,System.Boolean> condition)`
- `Sandbox.MovieMaker.MovieRecorderOptions WithDefaultComponentCapturers()`
- `Sandbox.MovieMaker.MovieRecorderOptions WithDefaultCaptureActions()`
- `Sandbox.MovieMaker.MovieRecorderOptions WithCaptureGameObject(Sandbox.GameObject gameObject)`
- `Sandbox.MovieMaker.MovieRecorderOptions WithCaptureComponent(Sandbox.Component component)`
- `Sandbox.MovieMaker.MovieRecorderOptions <Clone>$()`
- `System.Void Deconstruct(System.Int32 SampleRate, System.Nullable<Sandbox.MovieMaker.MovieTime> BufferDuration)`
