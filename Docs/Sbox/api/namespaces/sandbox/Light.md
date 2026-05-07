# Sandbox.Light

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `Light()`

## Properties

- `Color LightColor`
  - The main color of the light
- `Sandbox.Light.FogInfluence FogMode`
- `System.Single FogStrength`
- `System.Boolean Shadows`
  - Should this light cast shadows?
- `System.Single ShadowBias`
- `System.Single ShadowHardness`

## Methods

### Instance methods

- `virtual System.Void OnAwake()`
- `virtual System.Void OnEnabled()`
- `virtual System.Void OnDisabled()`
- `virtual Sandbox.SceneLight CreateSceneObject()`
- `virtual System.Void OnTagsChanged()`
  - Tags have been updated - lets update our light's tags
