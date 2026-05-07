# Sandbox.ITagSet

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `ITagSet()`

## Methods

### Instance methods

- `virtual System.Void RemoveAll()`
  - Remove all tags from the set.
- `virtual System.Boolean Has(System.String tag)`
  - Does this set have the specified tag?
- `virtual System.Void Add(System.String tag)`
  - Add a tag to the set.
- `virtual System.Void Remove(System.String tag)`
  - Remove a tag from the set.
- `virtual System.Void Set(System.String tag, System.Boolean state)`
  - Add or remove this tag, based on state
- `virtual System.Collections.Generic.IEnumerable<System.String> TryGetAll()`
  - Try to get all tags in the set.
- `virtual System.Collections.Generic.IReadOnlySet<System.UInt32> GetTokens()`
  - Try to get all tags in the set.
- `virtual System.Collections.Generic.IEnumerable<System.String> GetSuggested()`
  - Get all default tags for this set.
- `virtual System.Void SetFrom(Sandbox.ITagSet set)`
  - Set the tags to match this other tag set
- `virtual System.Void Add(Sandbox.ITagSet set)`
  - Add the tags from another set, to this set
- `virtual System.Void Toggle(System.String tag)`
  - If this tag is already here, remove it, else add it.
- `virtual System.Boolean HasAny(System.Collections.Generic.IEnumerable<System.String> tags)`
- `virtual System.Boolean HasAny(Sandbox.ITagSet other)`
- `virtual System.Boolean HasAny(System.String[] tags)`
- `virtual System.Boolean HasAll(System.Collections.Generic.IEnumerable<System.String> tags)`
- `virtual System.Boolean HasAll(Sandbox.ITagSet other)`
- `virtual System.Boolean HasAll(System.String[] tags)`
- `virtual System.Collections.Generic.IEnumerator<System.String> GetEnumerator()`
