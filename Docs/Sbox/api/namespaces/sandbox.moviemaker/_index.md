# Namespace `Sandbox.MovieMaker`

39 types.

## Classes

- [`ComponentCapturer<T>`](./ComponentCapturer-T.md) - Generic helper implementation of `Sandbox.MovieMaker.IComponentCapturer`.
- [`EmbeddedMovieResource`](./EmbeddedMovieResource.md) - An `Sandbox.MovieMaker.IMovieClip` embedded in a property.
- [`MoviePlayer`](./MoviePlayer.md) - Plays a `Sandbox.MovieMaker.IMovieClip` in a `Sandbox.Scene` to animate properties over time.
- [`MovieRecorder`](./MovieRecorder.md) - Records properties in a scene to tracks ready for use in a `Sandbox.MovieMaker.MoviePlayer`. You can use this for in-game demo recording
- [`MovieRecorderAction`](./MovieRecorderAction.md) - Called each time `Sandbox.MovieMaker.MovieRecorder.Capture` is invoked.
- [`MovieRecorderFilter`](./MovieRecorderFilter.md) - Returns `null` if the passed `gameObject` shouldn't be recorded.
- [`MovieRecorderOptions`](./MovieRecorderOptions.md) - Configures a `Sandbox.MovieMaker.MovieRecorder`, deciding how often it captures and which properties
- [`MovieResource`](./MovieResource.md) - A movie clip created with the MoviePlayer component.
- [`MovieTime`](./MovieTime.md) - Represents a duration of time in a movie. Uses fixed point so precision is consistent at any absolute time.
- [`MovieTimeRange`](./MovieTimeRange.md) - Represents a segment of time, given by `Sandbox.MovieMaker.MovieTimeRange.Start` and `Sandbox.MovieMaker.MovieTimeRange.End` times.
- [`TrackBinder`](./TrackBinder.md) - Controls which `Sandbox.MovieMaker.ITrackTarget`s from a scene are controlled by which `Sandbox.MovieMaker.ITrack` from a `Sandbox.MovieMaker.IMovieClip`.
- [`TrackMetadata`](./TrackMetadata.md) - Additional information used when editing or animating reference tracks.

## Static classes

- [`ClipExtensions`](./ClipExtensions.md) - Helper methods for working with `Sandbox.MovieMaker.IMovieClip` and `Sandbox.MovieMaker.ITrack`.
- [`Interpolator`](./Interpolator.md) - Helper for accessing `Sandbox.MovieMaker.IInterpolator`1` implementations,

## Attributes

- [`DefaultMovieRecorderOptionsAttribute`](./DefaultMovieRecorderOptionsAttribute.md) - Call this static method when building `Sandbox.MovieMaker.MovieRecorderOptions.Default`. The method

## Interfaces

- [`IActionTrack`](./IActionTrack.md) - Unused, will describe running actions in the scene.
- [`IComponentCapturer`](./IComponentCapturer.md) - When added to a `Sandbox.MovieMaker.MovieRecorderOptions`, handles how to capture the properties of
- [`IDynamicBlock`](./IDynamicBlock.md) - A `Sandbox.MovieMaker.ITrackBlock` that can change dynamically, usually for previewing edits / live recordings.
- [`IInterpolator<T>`](./IInterpolator-T.md) - Interpolates between two values of the same type.
- [`IMovieClip`](./IMovieClip.md) - A collection of `Sandbox.MovieMaker.ITrack`s describing properties changing over time and actions being invoked.
- [`IMovieProject`](./IMovieProject.md) - An editor-only movie project that can be compiled into a `Sandbox.MovieMaker.Compiled.MovieClip`.
- [`IMovieResource`](./IMovieResource.md) - A container for a `Sandbox.MovieMaker.Compiled.MovieClip`, including optional `Sandbox.MovieMaker.IMovieResource.EditorData`.
- [`IMovieTrackRecorder`](./IMovieTrackRecorder.md) - Watches some object or property in the scene, capturing
- [`IPropertyBlock`](./IPropertyBlock.md) - A `Sandbox.MovieMaker.IPropertySignal` with a defined start and end time.
- [`IPropertyBlock<T>`](./IPropertyBlock-T.md) - A `Sandbox.MovieMaker.IPropertySignal`1` with a defined start and end time.
- [`IPropertySignal`](./IPropertySignal.md) - Describes a value that changes over time.
- [`IPropertySignal<T>`](./IPropertySignal-T.md)
- [`IPropertyTrack`](./IPropertyTrack.md) - Controls an `Sandbox.MovieMaker.ITrackProperty` in the scene. Defines what value that property should have
- [`IPropertyTrack<T>`](./IPropertyTrack-T.md)
- [`IReferenceTrack`](./IReferenceTrack.md) - Maps to an `Sandbox.MovieMaker.ITrackReference` in a scene, which binds to a `Sandbox.GameObject`
- [`IReferenceTrack<T>`](./IReferenceTrack-T.md)
- [`ITrack`](./ITrack.md) - Maps to a `Sandbox.MovieMaker.ITrackTarget` in a scene, and describes how it changes over time.
- [`ITrackBlock`](./ITrackBlock.md) - A time region where something happens in a movie track.
- [`ITrackProperty`](./ITrackProperty.md) - A target referencing a member property or field of another target.
- [`ITrackProperty<T>`](./ITrackProperty-T.md)
- [`ITrackReference`](./ITrackReference.md) - A target referencing a `Sandbox.GameObject` or `Sandbox.Component` in the scene.
- [`ITrackReference<T>`](./ITrackReference-T.md)
- [`ITrackTarget`](./ITrackTarget.md) - Something in the scene that is being controlled by an `Sandbox.MovieMaker.ITrack`.
- [`ITrackTarget<T>`](./ITrackTarget-T.md)

## Structs

- [`MovieTime`](./MovieTime.md) - Represents a duration of time in a movie. Uses fixed point so precision is consistent at any absolute time.
- [`MovieTimeRange`](./MovieTimeRange.md) - Represents a segment of time, given by `Sandbox.MovieMaker.MovieTimeRange.Start` and `Sandbox.MovieMaker.MovieTimeRange.End` times.
