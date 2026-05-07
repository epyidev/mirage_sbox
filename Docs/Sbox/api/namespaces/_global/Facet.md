# Sandbox.Package.Facet

Describes a facet of a group of items, with a limited
number of each facet with their total item counts

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Package`

## Constructors

- `Facet(System.String Name, System.String Title, Sandbox.Package.Facet.Entry[] Entries)`
  - Describes a facet of a group of items, with a limited
number of each facet with their total item counts
- `Facet(Sandbox.Package.Facet original)`

## Properties

- `System.Type EqualityContract`
- `System.String Name`
- `System.String Title`
- `Sandbox.Package.Facet.Entry[] Entries`

## Methods

### Instance methods

- `virtual System.Boolean PrintMembers(System.Text.StringBuilder builder)`
- `virtual Sandbox.Package.Facet <Clone>$()`
- `System.Void Deconstruct(System.String Name, System.String Title, Sandbox.Package.Facet.Entry[] Entries)`
