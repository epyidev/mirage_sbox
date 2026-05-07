# Sandbox.AnimGraphDirectPlayback

For communicating with a Direct Playback Anim Node, which allows code to tell it to play a given sequence

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `AnimGraphDirectPlayback()`

## Properties

- `System.Single StartTime`
  - Set the time at which the currently playing sequence should have had a cycle of zero.
This will adjust the current cycle of the sequence to match.
- `System.Single TimeNormalized`
  - Get the cycle of the currently playing sequence.  Will return 0 if no sequence is playing.
- `System.Single Duration`
  - The duration of the currently playing sequence (seconds)
- `System.Single Time`
  - The elapsed time of the currently playing animation sequence (seconds)
- `System.String Name`
  - Returns the currently playing sequence.
- `System.Int32 AnimationCount`
  - Get the number of animations that can be used.
- `System.Collections.Generic.IEnumerable<System.String> Animations`
  - Get the list of animations that can be used.
- `System.Collections.Generic.IReadOnlyList<System.String> Sequences`
  - Get the list of sequences that can be used.

## Methods

### Instance methods

- `virtual System.Void Play(System.String name)`
  - Play the given sequence until it ends, then blend back.
Calling this function with a new sequence while another one is playing will immediately start blending from the old one to the new one.
- `virtual System.Void Play(System.String name, Vector3 target, System.Single heading, System.Single interpTime)`
  - Same as the other Play function, but also sets a target position and heading for the sequence.
Over interpTime seconds, the entity's root motion will be augmented to move it to target and rotate it to heading.
- `virtual System.Void Cancel()`
  - Stop playing the override sequence.
