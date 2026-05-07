# Namespace `Sandbox.MovieMaker.Properties`

9 types.

## Classes

- [`BindingReference<T>`](./BindingReference-T.md) - Used by movie property tracks with `Sandbox.GameObject` or `Sandbox.Component` value
- [`BoneAccessor`](./BoneAccessor.md) - Pseudo-property on a `Sandbox.SkinnedModelRenderer` that has a sub-property for each bone.
- [`MovieBoneAnimatorSystem`](./MovieBoneAnimatorSystem.md) - Coordinates playing bone animations from `Sandbox.MovieMaker.MoviePlayer`s. Holds a `Sandbox.MovieMaker.Properties.BoneAccessor`
- [`Unknown`](./Unknown.md) - Dummy type for `Sandbox.MovieMaker.Properties.ITrackPropertyFactory`1` to return if it matches

## Static classes

- [`BindingReference`](./BindingReference.md) - Helper methods for working with `Sandbox.MovieMaker.Properties.BindingReference`1`.
- [`TrackProperty`](./TrackProperty.md)

## Interfaces

- [`ITrackPropertyFactory`](./ITrackPropertyFactory.md) - Used by `Sandbox.MovieMaker.TrackBinder` to create `Sandbox.MovieMaker.ITrackProperty` instances that allow `Sandbox.MovieMaker.ITrack`s
- [`ITrackPropertyFactory<TParent,TValue>`](./ITrackPropertyFactory-TParent,TValue.md) - An `Sandbox.MovieMaker.Properties.ITrackPropertyFactory` that only creates properties nested inside a particular `TParent`
- [`ITrackPropertyFactory<TParent>`](./ITrackPropertyFactory-TParent.md) - An `Sandbox.MovieMaker.Properties.ITrackPropertyFactory` that only creates properties nested inside a particular `TParent`

## Structs

- [`BindingReference<T>`](./BindingReference-T.md) - Used by movie property tracks with `Sandbox.GameObject` or `Sandbox.Component` value
