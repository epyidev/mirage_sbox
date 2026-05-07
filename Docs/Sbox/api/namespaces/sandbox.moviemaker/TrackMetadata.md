# Sandbox.MovieMaker.TrackMetadata

Additional information used when editing or animating reference tracks.

- **Kind:** sealed class
- **Namespace:** `Sandbox.MovieMaker`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `TrackMetadata(System.Nullable<System.Guid> ReferenceId, System.String PrefabSource)`

## Properties

- `System.Nullable<System.Guid> ReferenceId`
  - ID of the `Sandbox.Component` or `Sandbox.GameObject` this track was created to target.
- `System.String PrefabSource`
  - For `Sandbox.GameObject` tracks, the prefab path that the original target object was instantiated from.

## Methods

### Instance methods

- `Sandbox.MovieMaker.TrackMetadata <Clone>$()`
- `System.Void Deconstruct(System.Nullable<System.Guid> ReferenceId, System.String PrefabSource)`
