# Sandbox.Clutter.SimpleScatterer

- **Kind:** class
- **Namespace:** `Sandbox.Clutter`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Clutter.Scatterer`

## Constructors

- `SimpleScatterer()`

## Properties

- `RangedFloat Scale`
  - Scale range for spawned objects.
- `System.Single Density`
  - Points per square meter. 0.05 = sparse trees, 0.5 = dense grass.
- `System.Boolean PlaceOnGround`
- `System.Single HeightOffset`
- `System.Boolean AlignToNormal`

## Methods

### Instance methods

- `virtual System.Collections.Generic.List<Sandbox.Clutter.ClutterInstance> Generate(BBox bounds, Sandbox.Clutter.ClutterDefinition clutter, Sandbox.Scene scene)`
