# Sandbox.Variant

A Variant is a type that can hold any value, and also keeps track of the type of the value it holds.
It's useful for cases where you want to store a value of an unknown type, or when you want to 
serialize/deserialize values of various types in a generic way.

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `Variant(System.Object o, System.Type t)`

## Properties

- `System.Type Type`
  - The type of the value currently stored in the Variant. This is automatically set when you assign a value to the Variant.
- `System.Object Value`
  - Gets or sets the value associated with this instance.

## Methods

### Static methods

- `static System.Object JsonRead(System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert)`
- `static System.Void JsonWrite(System.Object value, System.Text.Json.Utf8JsonWriter writer)`

### Instance methods

- `T Get()`
