# Sandbox.SceneSkyBox

Renders a skybox within a `Sandbox.SceneWorld`.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.SceneObject`

## Constructors

- `SceneSkyBox(Sandbox.SceneWorld world, Sandbox.Material skyMaterial)`

## Properties

- `Sandbox.Material SkyMaterial`
  - The skybox material. Typically it should use the "Sky" shader.
- `Color SkyTint`
  - Skybox color tint.
- `Sandbox.SceneSkyBox.FogParamInfo FogParams`
  - Controls the skybox specific fog.

## Methods

### Instance methods

- `System.Void SetSkyLighting(Vector3 ConstantSkyLight)`
