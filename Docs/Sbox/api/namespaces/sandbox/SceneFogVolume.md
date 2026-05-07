# Sandbox.SceneFogVolume

Represents a volume of fog in a scene, contributing to volumetric fog effects set on `Sandbox.SceneCamera.VolumetricFog`.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `SceneFogVolume(Sandbox.SceneWorld world, Transform transform, BBox boundingBox, System.Single fogStrength, System.Single falloffExponent)`

## Properties

- `Transform Transform`
  - The position and rotation of the fog volume in the scene.
- `BBox BoundingBox`
  - Defines the spatial boundaries of the fog volume.
- `System.Single FogStrength`
  - The intensity of the fog. Higher values indicate denser fog.
- `System.Single FalloffExponent`
  - Controls how quickly the fog fades at the edges of the volume. Higher values give sharper transitions.
- `System.Boolean IsValid`

## Methods

### Instance methods

- `System.Void Delete()`
  - Delete this fog volume. You shouldn't access it anymore.
