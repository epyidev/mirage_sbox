# Namespace `Sandbox.Audio`

17 types.

## Classes

- [`AudioChannel`](./AudioChannel.md) - Represents an audio channel, between 0 and 7. This is used to index into buffers.
- [`AudioMeter`](./AudioMeter.md) - Allows the capture and monitor of an audio source
- [`AudioProcessor`](./AudioProcessor.md) - Takes a bunch of samples and processes them. It's common for these to be chained together.
- [`AudioProcessor<T>`](./AudioProcessor-T.md) - Audio processor that allows per listener state.
- [`DelayProcessor`](./DelayProcessor.md)
- [`DspPresetHandle`](./DspPresetHandle.md) - A handle to a DspPreset
- [`DspProcessor`](./DspProcessor.md)
- [`HighPassProcessor`](./HighPassProcessor.md) - Just a test - don't count on this sticking around
- [`LowPassProcessor`](./LowPassProcessor.md) - Just a test - don't count on this sticking around
- [`MixBuffer`](./MixBuffer.md) - Contains 512 samples of audio data, this is used when mixing a single channel
- [`Mixer`](./Mixer.md) - Takes a bunch of sound, changes its volumes, mixes it together, outputs it
- [`MixerHandle`](./MixerHandle.md) - A handle to a Mixer
- [`MixerSettings`](./MixerSettings.md)
- [`MultiChannelBuffer`](./MultiChannelBuffer.md) - Holds up to 8 mix buffers, which usually represent output speakers.
- [`PerChannel<T>`](./PerChannel-T.md) - Stores a variable per channel
- [`PitchProcessor`](./PitchProcessor.md)

## Attributes

- [`AudioDistanceFloatAttribute`](./AudioDistanceFloatAttribute.md)

## Structs

- [`AudioChannel`](./AudioChannel.md) - Represents an audio channel, between 0 and 7. This is used to index into buffers.
- [`DspPresetHandle`](./DspPresetHandle.md) - A handle to a DspPreset
- [`MixerHandle`](./MixerHandle.md) - A handle to a Mixer
- [`PerChannel<T>`](./PerChannel-T.md) - Stores a variable per channel
