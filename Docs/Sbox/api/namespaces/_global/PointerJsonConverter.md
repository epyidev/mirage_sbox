# Sandbox.Json.PointerJsonConverter

Custom JSON converter for the Pointer class that serializes a Pointer as a string
and deserializes a string back into a Pointer using the Parse method.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Text.Json.Serialization.JsonConverter<Sandbox.Json/Pointer>`
- **Declaring type:** `Sandbox.Json`

## Constructors

- `PointerJsonConverter()`

## Methods

### Instance methods

- `virtual Sandbox.Json.Pointer Read(System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)`
- `virtual System.Void Write(System.Text.Json.Utf8JsonWriter writer, Sandbox.Json.Pointer value, System.Text.Json.JsonSerializerOptions options)`
