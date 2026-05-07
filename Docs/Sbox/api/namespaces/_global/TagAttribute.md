# TagAttribute

Adds a single or multiple tags for this type or member. Tags can then be retrieved via DisplayInfo library.

- **Kind:** attribute
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Attribute`

## Constructors

- `TagAttribute(System.String[] tag)`

## Properties

- `System.String[] Value`
  - The tags to add for this type or member.

## Methods

### Instance methods

- `System.Collections.Generic.IEnumerable<System.String> EnumerateValues()`
  - Returns all the tags as an enumerable.
