# Sandbox.SceneLight

Base class for light scene objects for use with a `Sandbox.SceneWorld`.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.SceneObject`

## Constructors

- `SceneLight(Sandbox.SceneWorld sceneWorld, Vector3 position, System.Single radius, Color color)`
- `SceneLight(Sandbox.SceneWorld sceneWorld)`

## Properties

- `Color LightColor`
  - Color and brightness of the light
- `System.Single Radius`
  - Radius of the light in units
- `System.Single ConstantAttenuation`
  - The light attenuation constant term
- `System.Single LinearAttenuation`
  - The light attenuation linear term
- `System.Single QuadraticAttenuation`
  - The light attenuation quadratic term
- `System.Int32 ShadowTextureResolution`
  - Get or set the resolution of the shadow map. If this is zero the engine will decide what it should use.
- `System.Boolean ShadowsEnabled`
  - Enable or disable shadow rendering
- `Sandbox.Texture LightCookie`
  - Access the LightCookie - which is a texture that gets drawn over the light
- `Sandbox.SceneLight.LightShape Shape`
- `Vector2 ShapeSize`
- `Sandbox.SceneLight.FogLightingMode FogLighting`
- `System.Single FogStrength`
- `System.Single ShadowBias`
- `System.Single ShadowHardness`
