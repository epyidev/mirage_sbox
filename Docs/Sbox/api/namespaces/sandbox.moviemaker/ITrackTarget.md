# Sandbox.MovieMaker.ITrackTarget

Something in the scene that is being controlled by an `Sandbox.MovieMaker.ITrack`.
            This could be a `Sandbox.GameObject` or `Sandbox.Component` reference, or a property contained
            within another `Sandbox.MovieMaker.ITrackTarget`.



These targets are created using `Sandbox.MovieMaker.TrackBinder.Get(Sandbox.MovieMaker.ITrack)`.



If `Sandbox.MovieMaker.ITrackTarget.IsBound` is true, this target is connected to a live instance of something in the scene,
            so accessing it will affect that connected instance.

- **Kind:** interface
- **Namespace:** `Sandbox.MovieMaker`
- **Assembly:** `Sandbox.Engine`

## Properties

- `Sandbox.MovieMaker.TrackBinder Binder`
  - The binder that created this target.
- `System.String Name`
  - Name of this target, for debugging and editing.
- `System.Type TargetType`
  - Value type of this target.
- `System.Boolean IsBound`
  - If true, this target is connected to a real object in the scene, so can be accessed.
- `System.Boolean IsActive`
  - If true, the target is bound and active in the scene hierarchy.
- `System.Object Value`
  - If bound, the current value of this target in the scene.
- `Sandbox.MovieMaker.ITrackTarget Parent`
  - Component / game object / property that contains this target, if from a nested track.
