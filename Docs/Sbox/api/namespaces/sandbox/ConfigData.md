# Sandbox.ConfigData

Project configuration data is derived from this class

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `ConfigData()`

## Properties

- `System.Guid Guid`
- `System.Int32 Version`

## Methods

### Instance methods

- `System.Text.Json.Nodes.JsonObject Serialize()`
- `System.Void Deserialize(System.String json)`
- `virtual System.Void OnValidate()`
  - Called after deserialization, and before serialization. A place to error check and make sure everything is fine.
