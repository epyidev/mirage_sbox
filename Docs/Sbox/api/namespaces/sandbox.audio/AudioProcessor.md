# Sandbox.Audio.AudioProcessor

Takes a bunch of samples and processes them. It's common for these to be chained together.
It's also common for the processor to store state between calls.

- **Kind:** abstract class
- **Namespace:** `Sandbox.Audio`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `AudioProcessor()`

## Properties

- `System.Boolean Enabled`
  - Is this processor active?
- `System.Single Mix`
  - Should we fade the influence of this processor in?
- `Transform Listener`
  - The listener's position in this frame.

## Methods

### Instance methods

- `virtual System.Void ProcessSingleChannel(Sandbox.Audio.AudioChannel channel, System.Span<System.Single> input)`
- `System.Text.Json.Nodes.JsonObject Serialize()`
- `System.Void Deserialize(System.Text.Json.Nodes.JsonObject node)`
- `virtual System.Void OnDestroy()`
