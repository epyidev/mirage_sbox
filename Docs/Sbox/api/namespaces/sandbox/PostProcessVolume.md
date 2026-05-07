# Sandbox.PostProcessVolume

A volume that defines a region in the scene where post processing effects will be applied.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Volumes.VolumeComponent`

## Constructors

- `PostProcessVolume()`

## Properties

- `System.Int32 Priority`
  - Higher priority volumes override lower priority ones. The default priority is 0.
- `System.Single BlendWeight`
  - Allows fading in and out
- `System.Single BlendDistance`
  - Distance from the edge of the volume where blending starts.
0 means hard edge, higher values create softer transitions.
- `System.Boolean EditorPreview`
  - Preview the post processing when this object is selected in the editor, or when the editor camera is inside the volume.

## Methods

### Instance methods

- `System.Single GetWeight(Vector3 pos)`
  - Get weight based on position
