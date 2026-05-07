# Facepunch.ActionGraphs.BindingSurface

- **Kind:** class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Constructors

- `BindingSurface(System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object> Properties, System.Collections.Generic.IReadOnlyDictionary<System.String,System.Type> InputTypes, System.Collections.Generic.IReadOnlyDictionary<System.String,System.Type> OutputTypes, Facepunch.ActionGraphs.ActionGraph ActionGraph, Facepunch.ActionGraphs.Node Node)`
- `BindingSurface(Facepunch.ActionGraphs.BindingSurface original)`

## Properties

- `System.Type EqualityContract`
- `System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object> Properties`
- `System.Collections.Generic.IReadOnlyDictionary<System.String,System.Type> InputTypes`
- `System.Collections.Generic.IReadOnlyDictionary<System.String,System.Type> OutputTypes`
- `Facepunch.ActionGraphs.ActionGraph ActionGraph`
- `Facepunch.ActionGraphs.Node Node`
- `static Facepunch.ActionGraphs.BindingSurface Empty`
- `System.Boolean IsNested`

## Methods

### Static methods

- `static Facepunch.ActionGraphs.BindingSurface FromNode(Facepunch.ActionGraphs.Node node)`
- `static Facepunch.ActionGraphs.BindingSurface FromNodeDeserializationSafe(Facepunch.ActionGraphs.Node node)`

### Instance methods

- `virtual System.Boolean PrintMembers(System.Text.StringBuilder builder)`
- `virtual Facepunch.ActionGraphs.BindingSurface <Clone>$()`
- `System.Void Deconstruct(System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object> Properties, System.Collections.Generic.IReadOnlyDictionary<System.String,System.Type> InputTypes, System.Collections.Generic.IReadOnlyDictionary<System.String,System.Type> OutputTypes, Facepunch.ActionGraphs.ActionGraph ActionGraph, Facepunch.ActionGraphs.Node Node)`
