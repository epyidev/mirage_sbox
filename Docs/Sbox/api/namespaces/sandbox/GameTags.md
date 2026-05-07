# Sandbox.GameTags

Entity Tags are strings you can set and check for on any entity. Internally
these strings are tokenized and networked so they're also available clientside.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.ITagSet`

## Methods

### Instance methods

- `virtual System.Collections.Generic.IEnumerable<System.String> TryGetAll()`
  - Returns all the tags this object has.
- `System.Collections.Generic.IEnumerable<System.String> TryGetAll(System.Boolean includeAncestors)`
  - Returns all the tags this object has.
- `virtual System.Boolean Has(System.String tag)`
  - Returns true if this object (or its parents) has given tag.
- `System.Boolean Has(System.String tag, System.Boolean includeAncestors)`
  - Returns true if this object has given tag.
- `System.Boolean HasAny(System.Collections.Generic.HashSet<System.String> tagList)`
- `virtual System.Void Add(System.String tag)`
  - Try to add the tag to this object.
- `System.Void Add(System.String[] tags)`
  - Adds multiple tags. Calls <see cref="M:Sandbox.GameTags.Add(System.String)">EntityTags.Add</see> for each tag.
- `virtual System.Void Remove(System.String tag)`
  - Try to remove the tag from this entity.
- `virtual System.Void RemoveAll()`
  - Remove all tags
- `System.Void Flush()`
- `virtual System.Collections.Generic.IReadOnlySet<System.UInt32> GetTokens()`
  - Returns a list of ints, representing the tags. These are used internally by the engine.
- `virtual System.Collections.Generic.IEnumerable<System.String> GetSuggested()`
  - Get all potential suggested tags that someone might want to add to this set.
