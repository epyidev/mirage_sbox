# Facepunch.ActionGraphs.InputDefinition

Describes an input of a node.

- **Kind:** class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Constructors

- `InputDefinition(System.String Name, System.Type Type, Facepunch.ActionGraphs.InputFlags Flags, Facepunch.ActionGraphs.DisplayInfo Display, System.Collections.Generic.IReadOnlySet<System.String> UsedBy, System.Object Default, System.Collections.Generic.IReadOnlyCollection<System.Attribute> Attributes)`
- `InputDefinition(Facepunch.ActionGraphs.InputDefinition original)`

## Properties

- `System.Type EqualityContract`
- `System.String Name`
  - Name used to reference this input.
- `System.Type Type`
  - What type is accepted in this input. For input signals, this will be `Facepunch.ActionGraphs.Signal`.
- `Facepunch.ActionGraphs.InputFlags Flags`
- `Facepunch.ActionGraphs.DisplayInfo Display`
  - Optional title and description of the input.
- `System.Collections.Generic.IReadOnlySet<System.String> UsedBy`
  - Input signals that use this input.
- `System.Object Default`
  - If `Facepunch.ActionGraphs.InputDefinition.IsRequired` is false, this value will be used when no value is provided.
- `System.Collections.Generic.IReadOnlyCollection<System.Attribute> Attributes`
- `System.Boolean IsSignal`
  - If true, this input receives a signal that will cause the parent node
to act.
- `System.Boolean IsPrimarySignal`
- `System.Boolean IsArray`
  - If true, this input accepts an array of values. Each element
can be connected to a different output.
- `System.Type ElementType`
  - For array input types, the type of an element of the array.
- `System.Boolean IsRequired`
- `System.Boolean IsMissing`
- `System.Boolean IsNotAlwaysAccessed`
- `System.Boolean IsTarget`
- `System.Boolean AllowCaching`

## Methods

### Static methods

- `static Facepunch.ActionGraphs.InputDefinition PrimarySignal(System.String title, System.String description)`
- `static Facepunch.ActionGraphs.InputDefinition SecondarySignal(System.String name, System.String title, System.String description)`
- `static Facepunch.ActionGraphs.InputDefinition Target(System.Type type, System.Object defaultValue, System.String title, System.String description)`
- `static Facepunch.ActionGraphs.InputDefinition Missing(System.String name)`

### Instance methods

- `virtual System.Boolean PrintMembers(System.Text.StringBuilder builder)`
- `virtual Facepunch.ActionGraphs.InputDefinition <Clone>$()`
- `System.Void Deconstruct(System.String Name, System.Type Type, Facepunch.ActionGraphs.InputFlags Flags, Facepunch.ActionGraphs.DisplayInfo Display, System.Collections.Generic.IReadOnlySet<System.String> UsedBy, System.Object Default, System.Collections.Generic.IReadOnlyCollection<System.Attribute> Attributes)`
