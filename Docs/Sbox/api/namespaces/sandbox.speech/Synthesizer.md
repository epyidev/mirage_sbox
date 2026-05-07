# Sandbox.Speech.Synthesizer

A speech synthesis stream. Lets you write text into speech and output it to a `Sandbox.SoundHandle`.

- **Kind:** sealed class
- **Namespace:** `Sandbox.Speech`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `Synthesizer()`

## Properties

- `System.Collections.ObjectModel.ReadOnlyCollection<Sandbox.Speech.Synthesizer.InstalledVoice> InstalledVoices`
  - Gets a list of currently installed voices on the user's system.
- `System.String CurrentVoice`
  - Gets the current voice being used by `Sandbox.Speech.Synthesizer.SpeechSynthesizer`.

## Methods

### Instance methods

- `virtual System.Void Dispose()`
- `Sandbox.Speech.Synthesizer TrySetVoice(System.String voiceName)`
  - Tries to set the voice to a matching voice name installed on the user's system.
- `Sandbox.Speech.Synthesizer TrySetVoice(System.String gender, System.String age)`
  - Tries to set the voice matching gender and age criteria.
- `Sandbox.Speech.Synthesizer WithText(System.String input)`
  - Adds some text to the speech.
- `Sandbox.Speech.Synthesizer OnVisemeReached(System.Action<System.Int32,System.TimeSpan> action)`
- `Sandbox.Speech.Synthesizer WithRate(System.Int32 rate)`
  - Sets the playback rate of the synthesizer.
- `Sandbox.Speech.Synthesizer WithBreak()`
  - Adds a break to the speech.
- `Sandbox.SoundHandle Play()`
  - Takes info from `Sandbox.Speech.Synthesizer.Builder` and creates a `System.Speech.Synthesis.SpeechSynthesizer`, outputting to a stream object.
Using `Sandbox.Speech.Synthesizer.AudioStreamHelpers` we then read all the PCM samples, and write it to a SoundStream.
This means it'll work like any other sound.
