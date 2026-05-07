# Sandbox.Clutter.Scatterer

Base class to override if you want to create custom scatterer logic.
Provides utility methods for entry selection and common operations.

- **Kind:** abstract class
- **Namespace:** `Sandbox.Clutter`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `Scatterer()`

## Properties

- `System.Random Random`

## Methods

### Static methods

- `static Rotation GetAlignedRotation(Vector3 normal, System.Single yawDegrees)`
  - Creates a rotation aligned to a surface normal with random yaw.
- `static Sandbox.SceneTraceResult TraceGround(Sandbox.Scene scene, Vector3 position)`
  - Helper to perform a ground trace at a position.
- `static System.Int32 GenerateSeed(System.Int32 baseSeed, System.Int32 x, System.Int32 y)`
  - Generates a deterministic seed from tile coordinates and base seed.
Use this to create unique seeds for different tiles.

### Instance methods

- `virtual System.Collections.Generic.List<Sandbox.Clutter.ClutterInstance> Generate(BBox bounds, Sandbox.Clutter.ClutterDefinition clutter, Sandbox.Scene scene)`
  - Generates clutter instances for the given bounds.
The Random property is initialized before this is called.
  - `bounds`: World-space bounds to scatter within
  - `clutter`: The clutter containing objects to scatter
  - `scene`: Scene to use for tracing (null falls back to Game.ActiveScene)
  - returns: Collection of clutter instances to spawn
- `System.Collections.Generic.List<Sandbox.Clutter.ClutterInstance> Scatter(BBox bounds, Sandbox.Clutter.ClutterDefinition clutter, System.Int32 seed, Sandbox.Scene scene)`
  - Public entry point for scattering. Creates Random from seed and calls Generate().
  - `bounds`: World-space bounds to scatter within
  - `clutter`: The clutter containing objects to scatter
  - `seed`: Seed for deterministic random generation
  - `scene`: Scene to use for tracing (required in editor mode)
  - returns: Collection of clutter instances to spawn
- `Sandbox.Clutter.ClutterEntry GetRandomEntry(Sandbox.Clutter.ClutterDefinition clutter)`
  - Selects a random entry from the clutter based on weights.
Returns null if no valid entries exist.
- `System.Int32 CalculatePointCount(BBox bounds, System.Single density, System.Int32 maxPoints)`
  - Calculates the number of points to scatter based on density and area.
Caps at maxPoints to prevent engine freezing.
  - `bounds`: Bounds to scatter in
  - `density`: Points per square meter
  - `maxPoints`: Maximum points to cap at (default 10000)
  - returns: Number of points to generate
