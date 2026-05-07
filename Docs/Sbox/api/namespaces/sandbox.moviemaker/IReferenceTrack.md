# Sandbox.MovieMaker.IReferenceTrack

Maps to an `Sandbox.MovieMaker.ITrackReference` in a scene, which binds to a `Sandbox.GameObject`
or `Sandbox.Component`.

- **Kind:** interface
- **Namespace:** `Sandbox.MovieMaker`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Guid Id`
  - Identifier for this track. Must be unique in the containing `Sandbox.MovieMaker.IMovieClip`,
but different clips can share tracks as long as they have identical names, types,
and parent tracks.
- `Sandbox.MovieMaker.IReferenceTrack<Sandbox.GameObject> Parent`
- `Sandbox.MovieMaker.TrackMetadata Metadata`
  - Additional information used when editing or animating this track.
