# Facepunch.ActionGraphs.OutputDefinition

Describes an output of a node.

- **Kind:** class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Constructors

- `OutputDefinition(System.String Name, System.Type Type, Facepunch.ActionGraphs.OutputFlags Flags, Facepunch.ActionGraphs.DisplayInfo Display, System.Collections.Generic.IReadOnlySet<System.String> ProvidedBy, System.Collections.Generic.IReadOnlyCollection<System.Attribute> Attributes)`
- `OutputDefinition(Facepunch.ActionGraphs.OutputDefinition original)`

## Properties

- `System.Type EqualityContract`
- `System.String Name`
  - Name used to reference this output.
- `System.Type Type`
  - What type is returned by this output. For signals, this will be `Facepunch.ActionGraphs.Signal`.
- `Facepunch.ActionGraphs.OutputFlags Flags`
- `Facepunch.ActionGraphs.DisplayInfo Display`
  - Optional title and description of the output.
- `System.Collections.Generic.IReadOnlySet<System.String> ProvidedBy`
  - This output is only valid when one of these output signals fires. If empty, it's always valid.
- `System.Collections.Generic.IReadOnlyCollection<System.Attribute> Attributes`
- `System.Boolean IsAlwaysInvoked`
- `System.Boolean IsSignal`
  - If true, this output emits signals that can trigger other nodes
to act.
- `System.Boolean IsPrimarySignal`
- `System.Boolean IsNotAwaited`
- `System.Boolean IsMissing`
- `System.Boolean IsRequired`

## Methods

### Static methods

- `static Facepunch.ActionGraphs.OutputDefinition PrimarySignal(System.String title, System.String description)`
- `static Facepunch.ActionGraphs.OutputDefinition SecondarySignal(System.String name, System.String title, System.String description, System.Boolean isNotAwaited)`
- `static Facepunch.ActionGraphs.OutputDefinition Missing(System.String name)`

### Instance methods

- `System.Boolean IsProvidedBy(Facepunch.ActionGraphs.OutputDefinition outputDef)`
- `virtual System.Boolean PrintMembers(System.Text.StringBuilder builder)`
- `virtual Facepunch.ActionGraphs.OutputDefinition <Clone>$()`
- `System.Void Deconstruct(System.String Name, System.Type Type, Facepunch.ActionGraphs.OutputFlags Flags, Facepunch.ActionGraphs.DisplayInfo Display, System.Collections.Generic.IReadOnlySet<System.String> ProvidedBy, System.Collections.Generic.IReadOnlyCollection<System.Attribute> Attributes)`
