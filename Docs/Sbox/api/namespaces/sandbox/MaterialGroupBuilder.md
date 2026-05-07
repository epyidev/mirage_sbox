# Sandbox.MaterialGroupBuilder

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.String Name`
  - The name of the material group.

## Methods

### Instance methods

- `Sandbox.MaterialGroupBuilder WithName(System.String name)`
- `Sandbox.MaterialGroupBuilder AddMaterial(Sandbox.Material material)`
  - Add a material to the group.
- `Sandbox.MaterialGroupBuilder AddMaterials(System.Span<Sandbox.Material> materials)`
