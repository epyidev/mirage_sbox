# Sandbox.Metadata

A simple class for storing and retrieving metadata values.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `Metadata()`

## Methods

### Instance methods

- `System.Void SetValue(System.String key, System.Object value)`
  - Set a value with the specified key.
- `System.Boolean TryGetValue(System.String key, T outValue)`
  - Try to get a value of the specified type.
- `T GetValueOrDefault(System.String key, T defaultValue)`
  - Get the a value. If it's missing or the wrong type then use the default value.
