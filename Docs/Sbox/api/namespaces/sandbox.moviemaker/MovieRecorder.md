# Sandbox.MovieMaker.MovieRecorder

Records properties in a scene to tracks ready for use in a `Sandbox.MovieMaker.MoviePlayer`. You can use this for in-game demo recording
            of a whole scene, or only specific properties, configured using `Sandbox.MovieMaker.MovieRecorderOptions`.



You can manually call `Sandbox.MovieMaker.MovieRecorder.Advance(Sandbox.MovieMaker.MovieTime)` to move the recording time along, then `Sandbox.MovieMaker.MovieRecorder.Capture` to write all recorded properties
            to tracks. Alternatively, call `Sandbox.MovieMaker.MovieRecorder.Start` to automatically advance and capture every fixed update, and `Sandbox.MovieMaker.MovieRecorder.Stop` to finish recording.



Convert the recording to a `Sandbox.MovieMaker.Compiled.MovieClip` by calling `Sandbox.MovieMaker.MovieRecorder.ToClip`. This clip can then be
            played back immediately, or serialized to later use.

- **Kind:** sealed class
- **Namespace:** `Sandbox.MovieMaker`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `MovieRecorder(Sandbox.Scene scene, Sandbox.MovieMaker.MovieRecorderOptions options)`
  - Create a new `Sandbox.MovieMaker.MovieRecorder`, recording the given `scene` with the given `options`.
  - `scene`: Scene to record.
  - `options`: Optional configuration, defaults to `Sandbox.MovieMaker.MovieRecorderOptions.Default`.
- `MovieRecorder(Sandbox.MovieMaker.TrackBinder binder, Sandbox.MovieMaker.MovieRecorderOptions options)`
  - Create a new `Sandbox.MovieMaker.MovieRecorder` with the given `binder` and `options`.
  - `binder`: Binder to map tracks to objects in a scene.
  - `options`: Optional configuration, defaults to `Sandbox.MovieMaker.MovieRecorderOptions.Default`.

## Properties

- `Sandbox.MovieMaker.MovieRecorderOptions Options`
  - Configuration deciding which properties are captured, and at what sample rate.
- `Sandbox.MovieMaker.TrackBinder Binder`
  - Maps tracks to objects and properties in the scene.
- `Sandbox.Scene Scene`
  - Scene we're recording. Will match `Sandbox.MovieMaker.TrackBinder.Scene`.
- `Sandbox.MovieMaker.MovieTimeRange TimeRange`
  - Recorded time range, spanning from the first capture to the current value of `Sandbox.MovieMaker.MovieRecorder.Time`.
- `System.Collections.Generic.IEnumerable<Sandbox.MovieMaker.IMovieTrackRecorder> RecordedThisFrame`
  - Which `Sandbox.MovieMaker.IMovieTrackRecorder`s recorded anything during the last call to `Sandbox.MovieMaker.MovieRecorder.Capture`.
- `Sandbox.MovieMaker.MovieTime Time`
  - Current recording time, increased by calling `Sandbox.MovieMaker.MovieRecorder.Advance(Sandbox.MovieMaker.MovieTime)`.

## Methods

### Instance methods

- `Sandbox.MovieMaker.IMovieTrackRecorder GetTrackRecorder(Sandbox.GameObject gameObject)`
  - Gets a `Sandbox.MovieMaker.IMovieTrackRecorder` for the given `gameObject`, creating one if it doesn't
exist. If `Sandbox.MovieMaker.MovieRecorderOptions.Filters` reject this game object, returns null instead.
  - `gameObject`: Object in the scene to record.
- `Sandbox.MovieMaker.IMovieTrackRecorder GetTrackRecorder(Sandbox.IValid gameObjectOrComponent)`
- `Sandbox.MovieMaker.IMovieTrackRecorder GetTrackRecorder(Sandbox.Component component)`
  - Gets a `Sandbox.MovieMaker.IMovieTrackRecorder` for the given `component`, creating one if it doesn't
            exist. If `Sandbox.MovieMaker.MovieRecorderOptions.Filters` reject the component's game object, returns null instead.



Calling `Sandbox.MovieMaker.MovieRecorder.Capture` on the returned recorder will use `Sandbox.MovieMaker.IComponentCapturer`s to decide
            which properties to capture. These handlers are configured using `Sandbox.MovieMaker.MovieRecorderOptions.ComponentCapturers`.
  - `component`: Component in the scene to record.
- `Sandbox.MovieMaker.IMovieTrackRecorder GetTrackRecorder(Sandbox.MovieMaker.ITrack track)`
  - Gets a `Sandbox.MovieMaker.IMovieTrackRecorder` for the given `track`, creating one if it doesn't
exist. If `Sandbox.MovieMaker.MovieRecorderOptions.Filters` reject whatever game object the track is bound to,
returns null instead.
  - `track`: Track to record.
- `System.IDisposable Start()`
  - Starts recording the scene.
Stop recording by calling `Sandbox.MovieMaker.MovieRecorder.Stop`, or disposing the returned object.
Recording will automatically stop when the recorded scene is being destroyed.
- `System.Void Stop()`
  - Stop recording the scene. Does nothing if you haven't called `Sandbox.MovieMaker.MovieRecorder.Start`.
- `System.Void Advance(Sandbox.MovieMaker.MovieTime deltaTime)`
  - Moves recording ahead by the given `deltaTime`.
This will happen automatically if you've called `Sandbox.MovieMaker.MovieRecorder.Start`.
- `System.Void Capture()`
  - Runs all actions in `Sandbox.MovieMaker.MovieRecorderOptions.CaptureActions`.
This will happen automatically if you've called `Sandbox.MovieMaker.MovieRecorder.Start`.
- `Sandbox.MovieMaker.Compiled.MovieClip ToClip()`
  - Convert the current recording to a `Sandbox.MovieMaker.Compiled.MovieClip` that can be serialized or played back.
- `Sandbox.MovieMaker.Compiled.MovieClip ToClip(Sandbox.MovieMaker.MovieTimeRange timeRange)`
- `Sandbox.MovieMaker.IMovieResource ToResource()`
  - Convert the current recording to a `Sandbox.MovieMaker.IMovieResource` that can be saved as a .movie asset.
