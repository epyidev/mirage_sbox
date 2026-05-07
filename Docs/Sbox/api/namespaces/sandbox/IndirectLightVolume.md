# Sandbox.IndirectLightVolume

Dynamic Diffuse Global Illumination volume that provides indirect lighting using a 3D probe grid.
Probes store irradiance and distance data in volume textures that can be sampled by shaders.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `IndirectLightVolume()`

## Properties

- `BBox Bounds`
  - World-space bounding box that defines the volume coverage area.
- `System.Int32 ProbeDensity`
  - Number of probes per 1024 world units. Higher values increase probe resolution.
- `System.Single NormalBias`
  - Bias applied along surface normals to prevent self-occlusion artifacts.
- `System.Single Contrast`
  - Controls how much less energy to conserve during probe integration.
Higher values give a harsher, more contrasty look.
- `Vector3Int ProbeCounts`
  - Calculated probe count along each axis based on bounds and density.
- `Sandbox.Texture IrradianceTexture`
  - Volume texture storing probe irradiance data (color).
- `Sandbox.Texture DistanceTexture`
  - Volume texture storing probe distance/visibility data.
- `Sandbox.Texture RelocationTexture`
  - Volume texture storing probe relocation offsets (XYZ = offset, W = active).
- `Sandbox.IndirectLightVolume.InsideGeometryBehavior InsideGeometry`
  - How to handle probes detected inside geometry.

## Methods

### Static methods

- `static System.Threading.Tasks.Task BakeAll()`

### Instance methods

- `System.Threading.Tasks.Task BakeProbes(System.Threading.CancellationToken ct)`
  - Starts the probe baking process to capture lighting into the volume textures.
- `System.Void ExtendToSceneBounds()`
  - Automatically sizes the volume to encompass all scene geometry.
- `System.Void ComputeProbeRelocation()`
  - Computes probe relocation offsets for all probes in the volume.
Uses iterative refinement with mesh tracing.
All computations are relative to probe spacing for resolution-independent behavior.
- `System.Void ClearProbeRelocation()`
  - Clears all probe relocation offsets.
