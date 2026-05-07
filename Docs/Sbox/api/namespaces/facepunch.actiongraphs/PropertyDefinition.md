# Facepunch.ActionGraphs.PropertyDefinition

Describes a property of a node that should be configurable in the inspector.

- **Kind:** class
- **Namespace:** `Facepunch.ActionGraphs`
- **Assembly:** `Facepunch.ActionGraphs`

## Constructors

- `PropertyDefinition(System.String Name, System.Type Type, Facepunch.ActionGraphs.PropertyFlags Flags, Facepunch.ActionGraphs.DisplayInfo Display, System.Object Default, System.Type GenericParameter, System.Collections.Generic.IReadOnlyCollection<System.Attribute> Attributes)`
- `PropertyDefinition(Facepunch.ActionGraphs.PropertyDefinition original)`

## Properties

- `System.Type EqualityContract`
- `System.String Name`
  - Name used to reference this property.
- `System.Type Type`
  - What type is accepted for this property.
- `Facepunch.ActionGraphs.PropertyFlags Flags`
- `Facepunch.ActionGraphs.DisplayInfo Display`
  - Optional title and description of the property.
- `System.Object Default`
  - If `Facepunch.ActionGraphs.PropertyDefinition.IsRequired` is false, this value will be used when no value is provided.
- `System.Type GenericParameter`
  - If `Facepunch.ActionGraphs.PropertyDefinition.Type` is `System.Type`, can hold a generic parameter constraining the type.
- `System.Collections.Generic.IReadOnlyCollection<System.Attribute> Attributes`
- `System.Boolean IsRequired`
- `System.Boolean IsMissing`
- `System.Boolean AlwaysSerialize`

## Methods

### Static methods

- `static Facepunch.ActionGraphs.PropertyDefinition Missing(System.String name)`

### Instance methods

- `virtual System.Boolean PrintMembers(System.Text.StringBuilder builder)`
- `virtual Facepunch.ActionGraphs.PropertyDefinition <Clone>$()`
- `System.Void Deconstruct(System.String Name, System.Type Type, Facepunch.ActionGraphs.PropertyFlags Flags, Facepunch.ActionGraphs.DisplayInfo Display, System.Object Default, System.Type GenericParameter, System.Collections.Generic.IReadOnlyCollection<System.Attribute> Attributes)`
