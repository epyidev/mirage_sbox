# Sandbox.IJsonConvert

Allows writing JsonConverter in a more compact way, without having to pre-register them.

- **Kind:** interface
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Methods

### Static methods

- `static virtual System.Object JsonRead(System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert)`
- `static virtual System.Void JsonWrite(System.Object value, System.Text.Json.Utf8JsonWriter writer)`
