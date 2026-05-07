# Sandbox.SoundEvent

A sound event. It can play a set of random sounds with optionally random settings such as volume and pitch.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.GameResource`

## Constructors

- `SoundEvent()`
- `SoundEvent(System.String soundName, System.Single volume)`

## Properties

- `System.Boolean UI`
  - Is this sound 2D?
- `RangedFloat Volume`
  - How loud the sound should be.
- `RangedFloat Pitch`
  - The base pitch of the sound.
- `System.Int32 Decibels`
  - How loud is this sound, affects how far away it can be heard
- `Sandbox.SoundEvent.SoundSelectionMode SelectionMode`
  - Selection strategy to use when picking from multiple sounds.
- `System.Collections.Generic.List<Sandbox.SoundFile> Sounds`
  - A random sound from the list will be selected to be played.
- `System.Boolean Occlusion`
  - Allow this sound to be occluded by geometry
- `System.Boolean Reflections`
  - Allow this sound to trace reflections, allowing it to be heard indirectly
- `System.Boolean AirAbsorption`
  - Allow this sound to be absorbed by air
- `System.Boolean Transmission`
  - Allow this sound to be transmitted through geometry
- `System.Single OcclusionRadius`
  - The radius of this sound's occlusion in inches.
- `System.Boolean DistanceAttenuation`
  - Should the sound fade out over distance
- `System.Single Distance`
  - How many units the sound can be heard from.
- `Sandbox.Curve Falloff`
  - The falloff curve for the sound.
- `Sandbox.Audio.MixerHandle DefaultMixer`
  - Default mixer to play this sound with if one isn't provided on play.
- `System.Int32 ResourceVersion`

## Methods

### Instance methods

- `virtual Sandbox.Bitmap CreateAssetTypeIcon(System.Int32 width, System.Int32 height)`
