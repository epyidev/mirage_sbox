# Sandbox.SceneModel

A model scene object that supports animations and can be rendered within a `Sandbox.SceneWorld`.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.SceneObject`

## Constructors

- `SceneModel(Sandbox.SceneWorld sceneWorld, System.String model, Transform transform)`
- `SceneModel(Sandbox.SceneWorld sceneWorld, Sandbox.Model model, Transform transform)`

## Properties

- `Sandbox.AnimationGraph AnimationGraph`
- `System.Single PlaybackRate`
- `System.Boolean UseAnimGraph`
  - Allows the scene model to not use the anim graph so it can play sequences directly
- `Transform RootMotion`
  - Get the calculated motion from animgraph since last frame
- `Sandbox.AnimationSequence CurrentSequence`
  - Allows playback of sequences directly, rather than using an animation graph.
Requires `Sandbox.SceneModel.UseAnimGraph` disabled if the scene model has one.
- `Sandbox.MorphCollection Morphs`
  - Access this sceneobject's morph collection. Morphs are generally used in the model to control
the face, for things like emotions and lip sync.
- `Sandbox.AnimGraphDirectPlayback DirectPlayback`
  - Access this sceneobject's direct playback. Direct playback is used to control the direct playback node in an animgraph
to play sequences directly in code
- `System.Action<Sandbox.SceneModel.FootstepEvent> OnFootstepEvent`
  - Called when a footstep event happens
- `System.Action<Sandbox.SceneModel.GenericEvent> OnGenericEvent`
  - Called when a generic event happens
- `System.Action<Sandbox.SceneModel.SoundEvent> OnSoundEvent`
  - Called when a sound event happens
- `System.Action<Sandbox.SceneModel.AnimTagEvent> OnAnimTagEvent`
  - Called when a anim tag event happens

## Methods

### Instance methods

- `System.Void SetBoneOverride(System.Int32 boneIndex, Transform transform)`
  - Manually override the final bone transform.
  - `transform`: Local coordinates based on the SceneModel's transform
- `System.Void ClearBoneOverrides()`
  - Clears all bone transform overrides.
- `System.Boolean HasBoneOverrides()`
  - Whether any bone transforms have been overridden.
- `System.Void GetBoneVelocity(System.Int32 boneIndex, Vector3 linear, Vector3 angular)`
  - Calculates the velocity from the previous and current bone transforms.
- `System.Void SetAnimGraph(System.String name)`
  - Override the anim graph this scene model uses
- `System.Void SetBoneWorldTransform(System.Int32 boneIndex, Transform transform)`
  - Sets the world space bone transform of a bone by its index.
  - `boneIndex`: Bone index to set transform of.
- `Transform GetBoneWorldTransform(System.Int32 boneIndex)`
  - Returns the world space transform of a bone by its index.
  - `boneIndex`: Index of the bone to calculate transform of.
  - returns: The world space transform, or an identity transform on failure.
- `Transform GetBoneWorldTransform(System.String boneName)`
  - Returns the world space transform of a bone by its name.
  - `boneName`: Name of the bone to calculate transform of.
  - returns: The world space transform, or an identity transform on failure.
- `Transform GetBoneLocalTransform(System.Int32 boneIndex)`
  - Returns the local space transform of a bone by its index.
  - `boneIndex`: Index of the bone to calculate transform of.
  - returns: The local space transform, or an identity transform on failure.
- `Transform GetBoneLocalTransform(System.String boneName)`
  - Returns the local space transform of a bone by its name.
  - `boneName`: Name of the bone to calculate transform of.
  - returns: The local space transform, or an identity transform on failure.
- `System.Void SetMaterialGroup(System.String name)`
  - Set material group to replace materials of the model as set up in ModelDoc.
- `System.Void SetBodyGroup(System.String name, System.Int32 value)`
  - Set which body group to use.
- `System.Nullable<Transform> GetAttachment(System.String name, System.Boolean worldspace)`
  - Get attachment transform by name.
  - `name`: Name of the attachment to calculate transform of.
  - `worldspace`: Whether the transform should be in world space (relative to the scene world), or local space (relative to the scene object)
- `System.Void RunPendingEvents()`
- `System.Void DispatchTagEvents()`
- `System.Void SetAnimParameter(System.String name, System.Boolean value)`
  - Sets a boolean animation graph parameter by name.
- `System.Void SetAnimParameter(System.String name, System.Single value)`
  - Sets a float animation graph parameter by name.
- `System.Void SetAnimParameter(System.String name, Vector3 value)`
  - Sets a vector animation graph parameter by name.
- `System.Void SetAnimParameter(System.String name, System.Int32 value)`
  - Sets a integer animation graph parameter by name.
- `System.Void SetAnimParameter(System.String name, Rotation value)`
  - Sets a rotation animation graph parameter by name.
- `System.Void ResetAnimParameters()`
  - Reset all animgraph parameters to their default values.
- `Rotation GetRotation(System.String name)`
  - Get an animated parameter
- `Vector3 GetVector3(System.String name)`
  - Get an animated parameter
- `System.Boolean GetBool(System.String name)`
  - Get an animated parameter
- `System.Single GetFloat(System.String name)`
  - Get an animated parameter
- `System.Int32 GetInt(System.String name)`
  - Get an animated parameter
- `System.Void Update(System.Single delta)`
  - Update this animation. Delta is the time you want to advance, usually RealTime.Delta
- `System.Void UpdateToBindPose()`
  - Update all of the bones to the bind pose
- `System.Void MergeBones(Sandbox.SceneModel parent)`
  - Update our bones to match the target's bones. This is a manual bone merge.
- `Transform GetParentSpaceBone(System.Int32 i)`
  - Returns the parent space transform of a bone by its index.
  - `i`: Index of the bone to calculate transform of.
  - returns: The parent space transform, or an identity transform on failure.
