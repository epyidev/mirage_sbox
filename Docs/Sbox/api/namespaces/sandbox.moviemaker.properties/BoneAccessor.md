# Sandbox.MovieMaker.Properties.BoneAccessor

Pseudo-property on a `Sandbox.SkinnedModelRenderer` that has a sub-property for each bone.
Stores movie-driven transforms for each bone during playback, and applies them when
`Sandbox.MovieMaker.Properties.MovieBoneAnimatorSystem` performs `Sandbox.GameObjectSystem.Stage.UpdateBones`.

- **Kind:** sealed class
- **Namespace:** `Sandbox.MovieMaker.Properties`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `BoneAccessor(Sandbox.SkinnedModelRenderer renderer)`

## Properties

- `Sandbox.SkinnedModelRenderer Renderer`
  - Renderer this accessor was created for.

## Methods

### Instance methods

- `System.Boolean HasBone(System.String name)`
  - Helper to see if the renderer's model has a bone with the given `name`.
- `Transform GetParentSpace(System.Int32 index)`
  - Gets the current movie-driven parent-space transform of the given bone. If the bone
isn't controlled by a movie, just returns the current parent-space transform.
- `System.Void SetParentSpace(System.Int32 index, Transform value)`
  - Sets the current movie-driven parent-space transform of the given bone.
- `System.Void ClearOverrides()`
  - Clears any movie-driven bone transforms for this renderer.
- `System.Void ApplyOverrides()`
  - Applies any movie-driven bone transforms. Called during `Sandbox.GameObjectSystem.Stage.UpdateBones`.
