# Sandbox.MovieMaker.Properties.MovieBoneAnimatorSystem

Coordinates playing bone animations from `Sandbox.MovieMaker.MoviePlayer`s. Holds a `Sandbox.MovieMaker.Properties.BoneAccessor`
for `Sandbox.SkinnedModelRenderer`s in the scene, which store any movie-controlled bone transforms.

- **Kind:** sealed class
- **Namespace:** `Sandbox.MovieMaker.Properties`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.GameObjectSystem<T>`

## Constructors

- `MovieBoneAnimatorSystem(Sandbox.Scene scene)`

## Methods

### Instance methods

- `System.Void UpdateBones()`
  - Applies any active movie-driven bone transformations.
- `System.Void ClearBones(Sandbox.SkinnedModelRenderer renderer)`
  - Clears all movie-driven bone transformations for the given `renderer`.
- `Transform GetParentSpaceBone(Sandbox.SkinnedModelRenderer renderer, System.Int32 index)`
  - Gets the current movie-driven parent-space transform for the given bone. If this
bone isn't currently being controlled by a movie, returns its current transform.
- `System.Void SetParentSpaceBone(Sandbox.SkinnedModelRenderer renderer, System.Int32 index, Transform transform)`
  - Sets the current movie-driven parent-space transform for the given bone.
