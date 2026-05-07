# Sandbox.PrefabScene

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Scene`

## Properties

- `Sandbox.PrefabScene.VariableCollection Variables`
  - A list of variables and their targets for this prefab scene

## Methods

### Static methods

- `static System.Void JsonWrite(System.Object value, System.Text.Json.Utf8JsonWriter writer)`

### Instance methods

- `virtual System.Boolean Load(Sandbox.GameResource resource)`
- `Sandbox.PrefabFile ToPrefabFile()`
- `virtual System.Text.Json.Nodes.JsonObject Serialize(Sandbox.GameObject.SerializeOptions options)`
- `virtual System.Void Deserialize(System.Text.Json.Nodes.JsonObject node, Sandbox.GameObject.DeserializeOptions options)`
