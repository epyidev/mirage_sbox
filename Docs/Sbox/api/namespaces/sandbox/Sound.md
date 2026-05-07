# Sandbox.Sound

Single source for creating sounds

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static Transform Listener`
  - Sound listener of the active scene.
- `static System.Single MasterVolume`
  - The user's preference for their master volume.
- `static System.String[] DspNames`
  - Get a list of available DSP names
- `static System.Int32 VoiceSampleRate`
  - The sample rate for voice data

## Methods

### Static methods

- `static System.Void SetEffect(System.String name, System.Single value, System.Single velocity, System.Single fadeOut)`
- `static System.Void Preload(System.String eventName)`
  - Precaches sound files associated with given sound event by name.
This helps avoid stutters on first load of each sound file.
- `static System.Void UncompressVoiceData(System.Byte[] buffer, System.Action<System.Memory<System.Int16>> ondata)`
- `static Sandbox.SoundHandle Play(System.String eventName, System.Single fadeInTime)`
- `static Sandbox.SoundHandle Play(Sandbox.SoundEvent soundEvent, System.Single fadeInTime)`
- `static Sandbox.SoundHandle Play(Sandbox.SoundEvent soundEvent, Vector3 position, System.Single fadeInTime)`
  - Play a sound and set its position
- `static Sandbox.SoundHandle Play(System.String eventName, Vector3 position, System.Single fadeInTime)`
  - Play a sound and set its position
- `static Sandbox.SoundHandle Play(System.String eventName, Sandbox.Audio.Mixer mixer)`
  - Play a sound and set its mixer
- `static Sandbox.SoundHandle Play(Sandbox.SoundEvent soundEvent, Sandbox.Audio.Mixer mixer)`
  - Play a sound and set its mixer
- `static Sandbox.SoundHandle PlayFile(Sandbox.SoundFile soundFile, System.Single volume, System.Single pitch, System.Single decibels, System.Single delay, System.Single fadeInTime)`
- `static Sandbox.SoundHandle PlayFile(Sandbox.SoundFile soundFile, System.Single volume, System.Single pitch, System.Single delay, System.Single fadeInTime)`
- `static System.Void StopAll(System.Single fade)`
