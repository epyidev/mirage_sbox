# Sandbox.TagSet

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.ITagSet`

## Constructors

- `TagSet()`
- `TagSet(System.Collections.Generic.IEnumerable<System.String> tags)`

## Properties

- `System.Boolean IsEmpty`

## Methods

### Instance methods

- `virtual System.Void Add(System.String tag)`
- `virtual System.Collections.Generic.IEnumerable<System.String> TryGetAll()`
- `virtual System.Boolean Has(System.String tag)`
- `virtual System.Void Remove(System.String tag)`
- `virtual System.Void RemoveAll()`
- `virtual System.Collections.Generic.IReadOnlySet<System.UInt32> GetTokens()`
  - Returns a list of ints, representing the tags. These are used internally by the engine.
