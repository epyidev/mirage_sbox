# Sandbox.BaseSoundComponent

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `BaseSoundComponent()`

## Properties

- `Sandbox.Audio.MixerHandle TargetMixer`
  - The mixer we want this sound to play through
- `Sandbox.SoundEvent SoundEvent`
- `System.Boolean PlayOnStart`
- `System.Boolean StopOnNew`
- `System.Boolean SoundOverride`
- `System.Single Volume`
- `System.Single Pitch`
- `System.Boolean Force2d`
- `System.Boolean Repeat`
- `System.Single MinRepeatTime`
- `System.Single MaxRepeatTime`
- `System.Boolean DistanceAttenuationOverride`
- `System.Boolean DistanceAttenuation`
- `System.Single Distance`
- `Sandbox.Curve Falloff`
- `System.Boolean OcclusionOverride`
- `System.Boolean Occlusion`
- `System.Single OcclusionRadius`
- `System.Boolean ReflectionOverride`
- `System.Boolean Reflections`

## Fields

- `Sandbox.SoundHandle SoundHandle`

## Methods

### Instance methods

- `virtual System.Void StartSound()`
- `virtual System.Void StopSound()`
- `System.Void ApplyOverrides(Sandbox.SoundHandle h)`
- `System.Void TestSound()`
