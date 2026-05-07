# Sandbox.Json

A convenience JSON helper that handles `Sandbox.Resource` types for you.

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Methods

### Static methods

- `static System.Object Deserialize(System.String source, System.Type t)`
  - Try to deserialize given source to given type.
- `static T Deserialize(System.String source)`
  - Try to deserialize given source to given type.
- `static T Deserialize(System.Text.Json.Utf8JsonReader reader)`
  - Deserialize from a Utf8JsonReader to given type, using our engine specific options.
- `static System.Object Deserialize(System.Text.Json.Utf8JsonReader reader, System.Type t)`
  - Deserialize from a Utf8JsonReader to given type, using our engine specific options.
- `static System.Boolean TryDeserialize(System.String source, System.Type t, System.Object obj)`
  - Try to deserialize given source to given type. Return true if it was a success
- `static System.Boolean TryDeserialize(System.String source, T obj)`
  - Try to deserialize given source to given type. Return true if it was a success
- `static System.String Serialize(System.Object source)`
  - Serialize an object.
- `static System.Void Serialize(System.Text.Json.Utf8JsonWriter writer, T target)`
  - Serialize to a Utf8JsonWriter using our engine specific options.
- `static System.Void Serialize(System.Text.Json.Utf8JsonWriter writer, System.Object target, System.Type inputType)`
  - Serialize to a Utf8JsonWriter using our engine specific options.
- `static System.Text.Json.Nodes.JsonObject ParseToJsonObject(System.String json)`
  - Parse some Json to a JsonObject
- `static System.Text.Json.Nodes.JsonObject ParseToJsonObject(System.Text.Json.Utf8JsonReader reader)`
  - Parse some Json to a JsonNode
- `static System.Text.Json.Nodes.JsonNode ToNode(System.Object obj)`
  - Serialize a single object to a JsonNode
- `static System.Text.Json.Nodes.JsonNode ToNode(System.Object obj, System.Type type)`
  - Serialize a single object to a JsonNode with the given expected type
- `static System.Object FromNode(System.Text.Json.Nodes.JsonNode node, System.Type type)`
  - Deserialize a single object to a type
- `static T FromNode(System.Text.Json.Nodes.JsonNode node)`
  - Deserialize a single object to a type
- `static System.Text.Json.Nodes.JsonNode WalkJsonTree(System.Text.Json.Nodes.JsonNode node, System.Func<System.String,System.Text.Json.Nodes.JsonValue,System.Text.Json.Nodes.JsonNode> onValue, System.Func<System.String,System.Text.Json.Nodes.JsonObject,System.Text.Json.Nodes.JsonObject> onObject)`
- `static Sandbox.Json.Patch CalculateDifferences(System.Text.Json.Nodes.JsonObject oldRoot, System.Text.Json.Nodes.JsonObject newRoot, System.Collections.Generic.HashSet<Sandbox.Json.TrackedObjectDefinition> definitions)`
- `static System.Text.Json.Nodes.JsonObject ApplyPatch(System.Text.Json.Nodes.JsonObject sourceRoot, Sandbox.Json.Patch patch, System.Collections.Generic.HashSet<Sandbox.Json.TrackedObjectDefinition> definitions)`
