# Facepunch.ActionGraphs.SerializationOptions

Controls how `Facepunch.ActionGraphs.ActionGraph`s are (de)serialized.

- **Kind:** class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Constructors

- `SerializationOptions(Facepunch.ActionGraphs.InputDefinition ImpliedTarget, Facepunch.ActionGraphs.IActionGraphCache Cache, Facepunch.ActionGraphs.ISourceLocation SourceLocation, System.Collections.Generic.IReadOnlyDictionary<System.Guid,System.Guid> GuidMap, System.Boolean WriteCacheReferences, System.Boolean ForceUpdateCached, System.Boolean MakeGuidsUnique)`
- `SerializationOptions(Facepunch.ActionGraphs.SerializationOptions original)`

## Properties

- `System.Type EqualityContract`
- `Facepunch.ActionGraphs.InputDefinition ImpliedTarget`
  - Add this input to any graphs deserialized in this scope, usually representing
a "this" parameter holding the object this graph is embedded in.
When serializing, omit this input from the serialized graph because we know
it will be added automatically when deserializing.
- `Facepunch.ActionGraphs.IActionGraphCache Cache`
  - Re-use instances from this cache when deserializing, matching by `Facepunch.ActionGraphs.ActionGraph.Guid`.
Graphs will be added to the cache when serializing or deserializing in this scope.
When serializing, if `Facepunch.ActionGraphs.SerializationOptions.WriteCacheReferences` is true, a minimal graph reference stub
will be written instead of full graphs.
- `Facepunch.ActionGraphs.ISourceLocation SourceLocation`
  - For debugging / editors, describe where graphs deserialized in this scope came from.
- `System.Collections.Generic.IReadOnlyDictionary<System.Guid,System.Guid> GuidMap`
  - When deserializing, maps any graph `System.Guid`s encountered.
- `System.Boolean WriteCacheReferences`
  - If true, and a `Facepunch.ActionGraphs.SerializationOptions.Cache` is provided, write a reference stub when serializing
graphs instead of the full JSON.
- `System.Boolean ForceUpdateCached`
  - If true, replace cached instance when deserializing. Otherwise, it'll only be
replaced if its `Facepunch.ActionGraphs.ActionGraph.ChangeId` differs.
- `System.Boolean MakeGuidsUnique`
- `static Facepunch.ActionGraphs.SerializationOptions Empty`
  - Default empty `Facepunch.ActionGraphs.SerializationOptions`.

## Methods

### Instance methods

- `virtual System.Boolean PrintMembers(System.Text.StringBuilder builder)`
- `virtual Facepunch.ActionGraphs.SerializationOptions <Clone>$()`
- `System.Void Deconstruct(Facepunch.ActionGraphs.InputDefinition ImpliedTarget, Facepunch.ActionGraphs.IActionGraphCache Cache, Facepunch.ActionGraphs.ISourceLocation SourceLocation, System.Collections.Generic.IReadOnlyDictionary<System.Guid,System.Guid> GuidMap, System.Boolean WriteCacheReferences, System.Boolean ForceUpdateCached, System.Boolean MakeGuidsUnique)`
