# Sandbox.Physics.CollisionRules

This is a JSON serializable description of the physics's collision rules. This allows us to send it
to the engine - and store it in a string table (which is networked to the client). You shouldn't really
ever have to mess with this, it's just used internally.

- **Kind:** class
- **Namespace:** `Sandbox.Physics`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.ConfigData`

## Constructors

- `CollisionRules()`

## Properties

- `System.Int32 Version`
- `System.Collections.Generic.Dictionary<System.String,Sandbox.Physics.CollisionRules.Result> Defaults`
  - If no pair matching is found, this is what we'll use
- `System.Collections.Generic.Dictionary<Sandbox.Physics.CollisionRules.Pair,Sandbox.Physics.CollisionRules.Result> Pairs`
  - What happens when a pair collides
- `System.Collections.Generic.IEnumerable<System.String> Tags`
  - All tags with either an entry in `Sandbox.Physics.CollisionRules.Defaults` or `Sandbox.Physics.CollisionRules.Pairs`.
- `System.Text.Json.Nodes.JsonNode SerializedPairs`
  - Gets or sets `Sandbox.Physics.CollisionRules.Pairs` in its serialized form for JSON.

## Methods

### Instance methods

- `Sandbox.Physics.CollisionRules.Result GetCollisionRule(System.String left, System.String right)`
  - Gets the specific collision rule for a pair of tags.
- `System.Void Clean()`
  - Remove duplicates etc
- `virtual System.Void OnValidate()`
