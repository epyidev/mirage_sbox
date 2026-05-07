# Sandbox.Clutter.SlopeScatterer

Scatterer that filters and selects assets based on the slope angle of the surface.
Useful for placing different vegetation or rocks on flat vs steep terrain.

- **Kind:** class
- **Namespace:** `Sandbox.Clutter`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Clutter.Scatterer`

## Constructors

- `SlopeScatterer()`

## Properties

- `RangedFloat Scale`
  - Scale range for spawned objects.
- `System.Single Density`
  - Points per square meter (density).
- `System.Single HeightOffset`
  - Offset from ground surface.
- `System.Boolean AlignToNormal`
  - Align objects to surface normal.
- `System.Collections.Generic.List<Sandbox.Clutter.SlopeMapping> Mappings`
  - Define which entries spawn at which slope angles.
- `System.Boolean UseFallback`
  - Use random clutter entry if no slope mapping matches.

## Methods

### Instance methods

- `virtual System.Collections.Generic.List<Sandbox.Clutter.ClutterInstance> Generate(BBox bounds, Sandbox.Clutter.ClutterDefinition clutter, Sandbox.Scene scene)`
