# Sandbox.UI.PackageList

- **Kind:** class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Base Library`
- **Base:** `Sandbox.UI.Panel`

## Constructors

- `PackageList()`

## Properties

- `System.String Query`
- `System.Int32 Take`
- `System.Boolean ShowFilters`
- `Vector2 ItemSize`
- `System.Action<Sandbox.Package> OnMenu`
- `System.Action<Sandbox.Package> OnSelected`
- `System.Action<System.String> OnFilterChanged`
- `Sandbox.Package[] Packages`
- `System.Collections.Generic.List<Sandbox.Package> FoundPackages`

## Fields

- `Sandbox.Package.FindResult Result`

## Methods

### Instance methods

- `virtual System.Void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)`
- `virtual System.Threading.Tasks.Task OnParametersSetAsync()`
