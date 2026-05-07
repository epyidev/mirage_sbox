# Sandbox.DirectionalLight

A directional light that casts shadows, like the sun.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Light`

## Constructors

- `DirectionalLight()`

## Properties

- `Color SkyColor`
  - Color of the ambient sky color
This is kept for long term support, the recommended way to do this is with an Ambient Light component.
- `System.Int32 ShadowCascadeCount`
  - Number of cascades to split the view frustum into for the whole scene dynamic shadow.  
More cascades result in better shadow resolution, but adds significant rendering cost.

User settings will set a maximum.
- `System.Single ShadowCascadeSplitRatio`
  - Controls how cascades 2+ are distributed between the first cascade boundary and the far clip.
0 is uniform, 1 is fully logarithmic.
- `Sandbox.DirectionalLight.CascadeVisualizer Visualizer`

## Methods

### Instance methods

- `virtual Sandbox.SceneLight CreateSceneObject()`
- `virtual System.Void OnAwake()`
- `virtual System.Void DrawGizmos()`
