# Sandbox.Doo.Block

Base class for all executable blocks within a Doo.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Doo`

## Constructors

- `Block()`

## Properties

- `System.Collections.Generic.List<Sandbox.Doo.Block> Body`
  - Optional list of child blocks nested inside this block.

## Methods

### Instance methods

- `virtual System.String GetNodeString()`
  - Returns a human-readable string describing this block for display in the editor.
- `virtual System.Boolean HasBody()`
  - Returns true if this can have child nodes
- `virtual System.Void Reset()`
  - Reset this block to some sensible defaults. This is called when 
the block is first added, so this is a good opportunity to set up default 
values for properties.
- `virtual System.Void CollectArguments(System.Collections.Generic.HashSet<System.String> arguments)`
