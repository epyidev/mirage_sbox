# Sandbox.MovieMaker.IMovieClip

A collection of `Sandbox.MovieMaker.ITrack`s describing properties changing over time and actions being invoked.

- **Kind:** interface
- **Namespace:** `Sandbox.MovieMaker`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Collections.Generic.IEnumerable<Sandbox.MovieMaker.ITrack> Tracks`
  - All tracks within the clip.
- `Sandbox.MovieMaker.MovieTime Duration`
  - How long this clip takes to fully play.

## Methods

### Instance methods

- `virtual Sandbox.MovieMaker.IReferenceTrack GetTrack(System.Guid trackId)`
  - Attempts to get a reference track with the given `trackId`.
  - returns: The matching track, or `null` if not found.
- `virtual System.Collections.Generic.IEnumerable<Sandbox.MovieMaker.ITrack> GetTracks(Sandbox.MovieMaker.MovieTime time)`
  - Get tracks that are active at the given `time`.
