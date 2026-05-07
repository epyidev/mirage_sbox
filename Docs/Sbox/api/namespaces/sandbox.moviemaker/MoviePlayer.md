# Sandbox.MovieMaker.MoviePlayer

Plays a `Sandbox.MovieMaker.IMovieClip` in a `Sandbox.Scene` to animate properties over time.

- **Kind:** sealed class
- **Namespace:** `Sandbox.MovieMaker`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `MoviePlayer()`

## Properties

- `Sandbox.MovieMaker.TrackBinder Binder`
  - Maps `Sandbox.MovieMaker.ITrack`s to game objects, components, and property `Sandbox.MovieMaker.ITrackTarget`s in the scene.
- `Sandbox.MovieMaker.IMovieResource Resource`
  - Contains a `Sandbox.MovieMaker.IMovieClip` to play. Can be a `Sandbox.MovieMaker.MovieResource` or `Sandbox.MovieMaker.EmbeddedMovieResource`.
- `Sandbox.MovieMaker.IMovieClip Clip`
- `System.Boolean IsPlaying`
- `System.Boolean IsLooping`
- `System.Boolean CreateTargets`
  - If true, creates any missing `Sandbox.GameObject`s and `Sandbox.Component`s for the
current movie to target.
- `System.Single TimeScale`
- `Sandbox.MovieMaker.MovieTime Position`
- `System.Single PositionSeconds`

## Methods

### Instance methods

- `System.Void Play()`
  - Play the current movie from the start.
- `System.Void Play(Sandbox.MovieMaker.MovieResource movie)`
  - Play the specified movie from the start.
  - `movie`: Movie resource to play.
- `System.Void Play(Sandbox.MovieMaker.IMovieClip clip)`
  - Play the specified clip from the start.
  - `clip`: Movie clip to play.
- `System.Void UpdateTargets()`
  - Forces the creation of any missing `Sandbox.GameObject`s or `Sandbox.Component`s for the current `Sandbox.MovieMaker.MoviePlayer.Clip` to target.
