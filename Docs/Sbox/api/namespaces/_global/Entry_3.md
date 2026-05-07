# Sandbox.Package.Facet.Entry

A facet entry consists of a name, display information and the number of items inside

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Package/Facet`

## Constructors

- `Entry(System.String Name, System.String Title, System.String Icon, System.Int32 Count, System.Collections.Generic.List<Sandbox.Package.Facet.Entry> Children)`
- `Entry(Sandbox.Package.Facet.Entry original)`

## Properties

- `System.Type EqualityContract`
- `System.String Name`
- `System.String Title`
- `System.String Icon`
- `System.Int32 Count`
- `System.Collections.Generic.List<Sandbox.Package.Facet.Entry> Children`

## Methods

### Instance methods

- `virtual System.Boolean PrintMembers(System.Text.StringBuilder builder)`
- `virtual Sandbox.Package.Facet.Entry <Clone>$()`
- `System.Void Deconstruct(System.String Name, System.String Title, System.String Icon, System.Int32 Count, System.Collections.Generic.List<Sandbox.Package.Facet.Entry> Children)`
