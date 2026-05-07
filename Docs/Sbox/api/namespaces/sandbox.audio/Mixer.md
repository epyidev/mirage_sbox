# Sandbox.Audio.Mixer

Takes a bunch of sound, changes its volumes, mixes it together, outputs it

- **Kind:** class
- **Namespace:** `Sandbox.Audio`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Int32 ChildCount`
- `Sandbox.Audio.AudioMeter Meter`
  - Allows monitoring of the output of the mixer
- `System.Guid Id`
  - Unique identifier for this object, for lookup, deserialization etc
- `System.String Name`
  - The display name for this mixer
- `System.Single Volume`
  - Scale the volume of our output by this amount
- `System.Int32 MaxVoices`
  - The maximum amount of voices to play at one time on this mixer
- `System.Boolean OverrideOcclusion`
  - If true then this mixer will use custom occlusion tags. If false we'll use what our parent uses.
- `Sandbox.TagSet OcclusionTags`
  - The tags which occlude our physics
- `System.Single Spacializing`
  - When 0 the sound will come out of all speakers, when 1 it will be fully spacialized
- `System.Single DistanceAttenuation`
  - Sounds get quieter as they go further away
- `System.Single Occlusion`
  - How much these sounds can get occluded
- `System.Single AirAbsorption`
  - How much the air absorbs energy from the sound
- `System.Boolean Solo`
  - Should this be the only mixer that is heard?
- `System.Boolean Mute`
  - Is this mixer muted?
- `System.Boolean IsMaster`
  - The default mixer gets all sounds that don't have a mixer specifically assigned
- `static Sandbox.Audio.Mixer Master`
- `static Sandbox.Audio.Mixer Default`
- `System.Int32 ProcessorCount`
  - The amount of processors

## Methods

### Static methods

- `static System.Void ResetToDefault()`
- `static Sandbox.Audio.Mixer FindMixerByName(System.String name)`
- `static Sandbox.Audio.Mixer FindMixerByGuid(System.Guid guid)`

### Instance methods

- `Sandbox.Audio.Mixer AddChild()`
- `System.Void Destroy()`
- `Sandbox.Audio.Mixer[] GetChildren()`
- `System.Collections.Generic.IReadOnlySet<System.UInt32> GetOcclusionTags()`
  - Get an array of occlusion tags our sounds want to hit. May return null if there are none defined!
- `System.Void StopAll(System.Single fade)`
  - Stop all sound handles using this mixer
- `System.Void AddProcessor(Sandbox.Audio.AudioProcessor ap)`
  - Add a processor to the list
- `System.Void ClearProcessors()`
  - Add a processor to the list
- `System.Void RemoveProcessor(Sandbox.Audio.AudioProcessor ap)`
  - Add a processor to the list
- `Sandbox.Audio.AudioProcessor[] GetProcessors()`
  - Get the current processor list
- `T GetProcessor()`
  - Get the first processor of a specific type, or null if not found
- `System.Text.Json.Nodes.JsonObject Serialize()`
- `System.Void SetMasterOcclusionDefaults()`
- `System.Void Deserialize(System.Text.Json.Nodes.JsonObject js, Sandbox.Internal.TypeLibrary typeLibrary)`
