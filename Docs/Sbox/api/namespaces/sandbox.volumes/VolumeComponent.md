# Sandbox.Volumes.VolumeComponent

- **Kind:** abstract class
- **Namespace:** `Sandbox.Volumes`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `VolumeComponent()`

## Properties

- `Sandbox.Volumes.SceneVolume SceneVolume`
- `System.Boolean IsInfinite`
  - True if SceneVolume.Type == SceneVolume.VolumeTypes.Infinite

## Methods

### Instance methods

- `virtual System.Void DrawGizmos()`
- `System.Single GetEdgeDistance(Vector3 worldPosition)`
  - Calculates the shortest distance from the specified world position to the nearest edge of the scene volume.
