# Facepunch.ActionGraphs.AddAssemblyResult

Returned by `Facepunch.ActionGraphs.NodeLibrary.AddAssembly(System.Reflection.Assembly)`.

- **Kind:** class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Constructors

- `AddAssemblyResult(System.Boolean AlreadyAdded, System.Collections.Generic.IReadOnlyDictionary<System.Reflection.MemberInfo,System.Exception> Errors)`
- `AddAssemblyResult(Facepunch.ActionGraphs.AddAssemblyResult original)`

## Properties

- `System.Type EqualityContract`
- `System.Boolean AlreadyAdded`
  - If true, this assembly was previously added so it was skipped.
- `System.Collections.Generic.IReadOnlyDictionary<System.Reflection.MemberInfo,System.Exception> Errors`
  - Any exceptions thrown when attempting to add methods can be found here.

## Methods

### Instance methods

- `virtual System.Boolean PrintMembers(System.Text.StringBuilder builder)`
- `virtual Facepunch.ActionGraphs.AddAssemblyResult <Clone>$()`
- `System.Void Deconstruct(System.Boolean AlreadyAdded, System.Collections.Generic.IReadOnlyDictionary<System.Reflection.MemberInfo,System.Exception> Errors)`
