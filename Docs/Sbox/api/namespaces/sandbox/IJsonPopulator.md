# Sandbox.IJsonPopulator

Objects that need to be deserialized into can implement this interface
which allows them to be populated from a JSON object.

- **Kind:** interface
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Methods

### Instance methods

- `virtual System.Text.Json.Nodes.JsonNode Serialize()`
- `virtual System.Void Deserialize(System.Text.Json.Nodes.JsonNode node)`
