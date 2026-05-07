# Sandbox.AnimationSequence

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `AnimationSequence()`

## Properties

- `System.Single Duration`
  - The duration of the currently playing sequence (seconds)
- `System.Boolean IsFinished`
  - Get whether the current animation sequence has finished
- `System.String Name`
  - The name of the currently playing animation sequence
- `System.Single TimeNormalized`
  - The normalized (between 0 and 1) elapsed time of the currently playing
animation sequence
- `System.Single Time`
  - The elapsed time of the currently playing animation sequence (seconds)
- `System.Collections.Generic.IReadOnlyList<System.String> SequenceNames`
  - The list of sequences that can be used
