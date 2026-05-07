# Sandbox.SceneDirectionalLight

A directional scene light that is used to mimic sun light in a `Sandbox.SceneWorld`.
Direction is controlled by this object's `Rotation`.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.SceneLight`

## Constructors

- `SceneDirectionalLight(Sandbox.SceneWorld sceneWorld, Rotation rotation, Color color)`

## Properties

- `Color SkyColor`
  - Ambient light color outside of all light probes.
- `System.Int32 ShadowCascadeCount`
  - Control number of shadow cascades
- `System.Single ShadowCascadeSplitRatio`

## Methods

### Instance methods

- `System.Void SetCascadeDistanceScale(System.Single distance)`
  - Set the max distance of the shadow cascade
