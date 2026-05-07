# Facepunch.ActionGraphs.ActionGraphCache

Used to re-use `Facepunch.ActionGraphs.ActionGraph` instances when deserializing.

- **Kind:** sealed class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Constructors

- `ActionGraphCache()`

## Properties

- `System.Collections.Generic.IEnumerable<System.Guid> Guids`

## Methods

### Instance methods

- `virtual System.Void Add(System.Guid guid, Facepunch.ActionGraphs.ActionGraph graph)`
- `virtual System.Boolean TryGetValue(System.Guid guid, Facepunch.ActionGraphs.ActionGraph graph)`
- `System.Boolean Remove(System.Guid guid)`
- `System.Void Clear()`
