# Sandbox.SoundHandle

A handle to a sound that is currently playing. You can use this to control the sound's position, volume, pitch etc.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `Vector3 Position`
  - Position of the sound.
- `Rotation Rotation`
  - The direction the sound is facing
- `Transform Transform`
  - This sound's transform
- `System.Single Volume`
  - Volume of the sound.
- `System.String Name`
  - A debug name to help identify the sound
- `System.Single SpacialBlend`
  - How 3d the sound should be. 0 means no 3d, 1 means fully
- `System.Single Distance`
  - How many units the sound can be heard from.
- `Sandbox.Curve Falloff`
  - The falloff curve for the sound.
- `Sandbox.Curve Fadeout`
  - The fadeout curve for when the sound stops.
- `Sandbox.Curve Fadein`
  - The fadein curve for when the sound starts.
- `System.Single Decibels`
- `System.Single Pitch`
  - Pitch of the sound.
- `System.Boolean IsPlaying`
  - Whether the sound is currently playing or not.
- `System.Boolean Paused`
  - Whether the sound is currently paused or not.
- `System.Boolean Finished`
  - Sound is done
- `System.Boolean Reflections`
  - Enable the sound reflecting off surfaces
- `System.Boolean Occlusion`
  - Allow this sound to be occluded by geometry etc
- `System.Single OcclusionRadius`
  - The radius of this sound's occlusion, allow for partial occlusion
- `System.Boolean DistanceAttenuation`
  - Should the sound fade out over distance
- `System.Boolean AirAbsorption`
  - Should the sound get absorbed by air, so it sounds different at distance
- `System.Boolean Transmission`
  - Should the sound transmit through walls, doors etc
- `Sandbox.Audio.Mixer TargetMixer`
  - Which mixer do we want to write to
- `System.Int32 SampleRate`
  - How many samples per second?
- `System.Boolean IsStopped`
  - True if the sound has been stopped
- `System.Single ElapsedTime`
- `System.Single Time`
  - The current time of the playing sound in seconds.
Note: for some formats seeking may be expensive, and some may not support it at all.
- `System.Boolean ListenLocal`
  - Place the listener at 0,0,0 facing 1,0,0.
- `System.Boolean Loopback`
  - If true, then this sound won't be played unless voice_loopback is 1. The assumption is that it's the 
local user's voice. Amplitude and visme data will still be available!
- `System.Single Amplitude`
  - Measure of audio loudness.
- `System.Boolean IsValid`
- `System.Boolean FollowParent`
  - Update our position every frame relative to our parent
- `Transform LocalTransform`
  - If we're following a parent, our position will be this relative to them.
- `Sandbox.GameObject Parent`
  - If set with a parent and <cref name="FollowParent" /> is true, we will update our position to match the parent's world position. You can use <cref name="LocalTransform" /> to set an offset from the parent's position.
Setting a parent also allows you to use GameObject.StopAllSounds on the parent to stop all sounds that are following it.
This is set automatically when calling <cref name="GameObject.PlaySound" /> on a GameObject, but you can set it manually if you want to change the parent of an existing sound handle.
- `Sandbox.SoundHandle.LipSyncAccessor LipSync`
  - Access lipsync processing.

## Methods

### Static methods

- `static System.Void GetActive(System.Collections.Generic.List<Sandbox.SoundHandle> handles)`

### Instance methods

- `System.Void Stop(System.Single fadeTime)`
- `virtual System.Void Finalize()`
- `virtual System.Void Dispose()`
- `System.Void Update()`
  - Called to push changes to a sound immediately, rather than waiting for the next tick.
You should call this if you make changes to a sound.
- `System.Void ClearParent()`
  - Clear our parent - stop following
- `System.Void SetParent(Sandbox.GameObject obj)`
  - Tell the SoundHandle to follow this GameObject's position
