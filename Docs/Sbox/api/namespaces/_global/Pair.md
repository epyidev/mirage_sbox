# Sandbox.Physics.CollisionRules.Pair

A pair of case- and order-insensitive tags, used as a key to look up a `Sandbox.Physics.CollisionRules.Result`.

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Physics.CollisionRules`

## Constructors

- `Pair(System.String left, System.String right)`
  - Initializes from a pair of tags.

## Properties

- `System.String Left`
  - First of the two tags.
- `System.String Right`
  - Second of the two tags.

## Methods

### Instance methods

- `System.Boolean Contains(System.String tag)`
  - Returns true if either `Sandbox.Physics.CollisionRules.Pair.Left` or `Sandbox.Physics.CollisionRules.Pair.Right` matches the given tag.
- `virtual System.Collections.Generic.IEnumerator<System.String> GetEnumerator()`
