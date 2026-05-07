# Sandbox.SkinnedModelRenderer

Renders a skinned model in the world. A skinned model is any model with bones/animations.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.ModelRenderer`

## Constructors

- `SkinnedModelRenderer()`

## Properties

- `System.Boolean CreateBoneObjects`
- `Sandbox.SkinnedModelRenderer BoneMergeTarget`
- `System.Boolean UseAnimGraph`
  - Usually used for turning off animation on ragdolls.
- `Sandbox.AnimationGraph AnimationGraph`
  - Override animgraph, otherwise uses animgraph of the model.
- `Sandbox.SkinnedModelRenderer.SequenceAccessor Sequence`
  - Allows playback of sequences directly, rather than using an animation graph.
Requires `Sandbox.SkinnedModelRenderer.UseAnimGraph` disabled if the scene model has one.
- `System.Single PlaybackRate`
  - Control playback rate of animgraph or current sequence.
- `Sandbox.SceneModel SceneModel`
- `Transform RootMotion`
- `System.Boolean PlayAnimationsInEditorScene`
  - If true then animations will play while in an editor scene.
- `System.Action<Sandbox.SceneModel.FootstepEvent> OnFootstepEvent`
  - Called when a footstep event happens
- `System.Action<Sandbox.SceneModel.GenericEvent> OnGenericEvent`
  - Called when a generic animation event happens
- `System.Action<Sandbox.SceneModel.SoundEvent> OnSoundEvent`
  - Called when a sound event happens
- `System.Action<Sandbox.SceneModel.AnimTagEvent> OnAnimTagEvent`
  - Called when an anim tag event happens
- `Sandbox.SkinnedModelRenderer.MorphAccessor Morphs`
  - Access to the morphs for this model
- `System.Boolean ShouldShowMorphsEditor`
- `Sandbox.SkinnedModelRenderer.ParameterAccessor Parameters`
  - Access to the animgraph parameters for this model
- `System.Boolean ShouldShowParametersEditor`
- `System.Boolean ShouldShowSequenceEditor`

## Methods

### Instance methods

- `Sandbox.GameObject GetBoneObject(System.Int32 index)`
  - Get the GameObject of a specific bone.
- `Sandbox.GameObject GetBoneObject(System.String boneName)`
  - Find a bone's GameObject by bone name.
- `virtual Sandbox.GameObject GetBoneObject(Sandbox.BoneCollection.Bone bone)`
- `System.Boolean TryGetBoneTransform(System.String boneName, Transform tx)`
  - Try to get the final worldspace bone transform.
- `System.Boolean TryGetBoneTransform(Sandbox.BoneCollection.Bone bone, Transform tx)`
  - Try to get the final worldspace bone transform.
- `System.Boolean TryGetBoneTransformLocal(System.String boneName, Transform tx)`
- `System.Boolean TryGetBoneTransformLocal(Sandbox.BoneCollection.Bone bone, Transform tx)`
- `System.Boolean TryGetBoneTransformAnimation(Sandbox.BoneCollection.Bone bone, Transform tx)`
  - Try to get the worldspace bone transform after animation but before physics and procedural bones.
- `System.Void SetBoneTransform(Sandbox.BoneCollection.Bone bone, Transform transform)`
- `System.Void ClearPhysicsBones()`
- `Transform[] GetBoneTransforms(System.Boolean world)`
  - Allocate an array of bone transforms in either world space or parent space.
- `Sandbox.SkinnedModelRenderer.BoneVelocity[] GetBoneVelocities()`
  - Allocate an array of bone velocities in world space
- `Sandbox.SkinnedModelRenderer.BoneVelocity GetBoneVelocity(System.Int32 boneIndex)`
  - Retrieve the bone's velocities based on previous and current position
- `System.Void PostAnimationUpdate()`
- `System.Nullable<Transform> GetAttachment(System.String name, System.Boolean worldSpace)`
- `System.Void Set(System.String v, Vector3 value)`
- `System.Void Set(System.String v, System.Int32 value)`
- `System.Void Set(System.String v, System.Single value)`
- `System.Void Set(System.String v, System.Boolean value)`
- `System.Void Set(System.String v, Rotation value)`
- `System.Void ClearParameters()`
  - Remove any stored parameters
- `System.Boolean GetBool(System.String v)`
- `System.Int32 GetInt(System.String v)`
- `System.Single GetFloat(System.String v)`
- `Vector3 GetVector(System.String v)`
- `Rotation GetRotation(System.String v)`
- `System.Void SetLookDirection(System.String name, Vector3 eyeDirectionWorld)`
  - Converts value to vector local to this entity's eyepos and passes it to SetAnimVector
- `System.Void SetLookDirection(System.String name, Vector3 eyeDirectionWorld, System.Single weight)`
  - Converts value to vector local to this entity's eyepos and passes it to SetAnimVector. 
This also sets {name}_weight to the weight value.
- `System.Void SetIk(System.String name, Transform tx)`
  - Sets an IK parameter. This sets 3 variables that should be set in the animgraph:
1. ik.{name}.enabled
2. ik.{name}.position
3. ik.{name}.rotation
- `System.Void ClearIk(System.String name)`
  - This sets ik.{name}.enabled to false.
