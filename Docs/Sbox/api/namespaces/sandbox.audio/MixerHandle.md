# Sandbox.Audio.MixerHandle

A handle to a Mixer

- **Kind:** struct
- **Namespace:** `Sandbox.Audio`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.String Name`
- `System.Guid Id`

## Methods

### Static methods

- `static System.Object JsonRead(System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert)`
- `static System.Void JsonWrite(System.Object value, System.Text.Json.Utf8JsonWriter writer)`
- `static System.Object[] GetDropdownSelection()`

### Instance methods

- `Sandbox.Audio.Mixer Get(Sandbox.Audio.Mixer fallback)`
- `Sandbox.Audio.Mixer GetOrDefault()`
