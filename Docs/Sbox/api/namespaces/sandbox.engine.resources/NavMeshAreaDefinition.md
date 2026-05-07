# Sandbox.Engine.Resources.NavMeshAreaDefinition

Defines a navigation area resource for use in navigation meshes.

- **Kind:** sealed class
- **Namespace:** `Sandbox.Engine.Resources`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.GameResource`

## Constructors

- `NavMeshAreaDefinition()`

## Properties

- `Color Color`
  - Debug color for this Area.
- `System.Single CostMultiplier`
  - How much costlier it is to cross this Area.
Will be clamped.
- `System.Int32 Priority`
  - Gets or sets the priority level for the area definition.
Higher values take precedence if multiple areas overlap.
