# Sandbox.Soundscape

A soundscape is used for environmental ambiance of a map by playing a set of random sounds at given intervals.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.GameResource`

## Constructors

- `Soundscape()`

## Properties

- `RangedFloat MasterVolume`
  - All sound volumes in this soundscape will be scaled by this value.
- `System.Collections.Generic.List<Sandbox.Soundscape.LoopedSound> LoopedSounds`
  - Sounds that are played constantly on a loop.
- `System.Collections.Generic.List<Sandbox.Soundscape.StingSound> StingSounds`
  - Sounds that are played at intervals.

## Methods

### Instance methods

- `virtual Sandbox.Bitmap CreateAssetTypeIcon(System.Int32 width, System.Int32 height)`
