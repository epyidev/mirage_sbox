# Facepunch.ActionGraphs.TypeConverter

- **Kind:** sealed class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`
- **Base:** `System.Text.Json.Serialization.JsonConverter<System.Type>`

## Constructors

- `TypeConverter(Facepunch.ActionGraphs.ITypeLoader typeLoader)`

## Properties

- `Facepunch.ActionGraphs.ITypeLoader TypeLoader`

## Methods

### Instance methods

- `virtual System.Type Read(System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)`
- `virtual System.Void Write(System.Text.Json.Utf8JsonWriter writer, System.Type value, System.Text.Json.JsonSerializerOptions options)`
