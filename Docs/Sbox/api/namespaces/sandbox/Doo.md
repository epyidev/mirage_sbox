# Sandbox.Doo

A visual scripting task composed of executable blocks.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `Doo()`

## Properties

- `System.Collections.Generic.List<Sandbox.Doo.Block> Body`
  - The top-level list of blocks that make up this task.

## Methods

### Static methods

- `static System.Object JsonRead(System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert)`
  - Deserializes a Doo from JSON.
- `static System.Void JsonWrite(System.Object value, System.Text.Json.Utf8JsonWriter writer)`
  - Serializes a Doo to JSON.

### Instance methods

- `System.String GetLabel()`
  - Returns a short display label describing this Doo's contents.
- `System.Boolean IsEmpty()`
  - Returns true if this Doo has no blocks.
- `System.Boolean DeleteBlock(Sandbox.Doo.Block value)`
  - Find and delete this block from the Doo tree.
- `System.Boolean InsertBefore(Sandbox.Doo.Block target, Sandbox.Doo.Block blockToInsert)`
  - Insert a block before the target block.
- `System.Boolean InsertAfter(Sandbox.Doo.Block target, Sandbox.Doo.Block blockToInsert)`
  - Insert a block after the target block.
- `System.Void AddChild(Sandbox.Doo.Block parent, Sandbox.Doo.Block blockToInsert)`
  - Add a block as a child of the target block's body.
