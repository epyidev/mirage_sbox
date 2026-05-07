# Sandbox.Volumes.SceneVolume

A generic way to represent volumes in a scene. If we all end up using this instead of defining our own version
in everything, we can improve this and improve everything at the same time.

- **Kind:** struct
- **Namespace:** `Sandbox.Volumes`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `SceneVolume()`

## Fields

- `Sandbox.Volumes.SceneVolume.VolumeTypes Type`
- `Sandbox.Sphere Sphere`
- `BBox Box`
- `Capsule Capsule`

## Methods

### Instance methods

- `System.Void DrawGizmos(System.Boolean withControls)`
  - Draws an editable sphere/box gizmo, for adjusting the volume
- `System.Boolean Test(Transform volumeTransform, Vector3 position)`
  - Is this point within the volume
- `System.Boolean Test(Vector3 position)`
  - Is this point within the (local space) volume
- `System.Single GetVolume()`
  - Get the actual amount of volume in this shape. This is useful if you want to make
a system where you prioritize by volume size. Don't forget to multiply by scale!
- `System.Single GetEdgeDistance(Transform worldTransform, Vector3 worldPosition)`
  - Calculates the shortest distance from the specified world position to the edge of this volume.
  - `worldTransform`: The world transform of the volume.
  - `worldPosition`: The position in world space to measure from.
  - returns: The distance, in world units, from the position to the volume edge.
- `BBox GetBounds()`
  - Returns the axis-aligned bounding box that encloses the current volume.
