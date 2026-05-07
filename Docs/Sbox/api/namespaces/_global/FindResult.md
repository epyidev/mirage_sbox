# Sandbox.Package.FindResult

A result from the call to FindAsync

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Package`

## Constructors

- `FindResult()`

## Properties

- `System.Double Milliseconds`
  - The amount of time the query took
- `Sandbox.Package[] Packages`
  - A list of packages retrieved
- `System.Int32 TotalCount`
  - The total amount of packages
- `Sandbox.Package.Facet[] Facets`
  - Facets particular to this search
- `Sandbox.Package.TagEntry[] Tags`
  - A list of tags relevant to this search
- `Sandbox.Package.SortOrder[] Orders`
  - A list of sort orders. There may be other sort orders, but we provide a list here that can
be easily used to save rewriting the same code over and over.
- `Sandbox.Package.PackageProperty[] Properties`
  - Binary options
