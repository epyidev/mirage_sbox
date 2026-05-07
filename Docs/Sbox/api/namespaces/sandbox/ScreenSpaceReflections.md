# Sandbox.ScreenSpaceReflections

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.BasePostProcess<T>`

## Constructors

- `ScreenSpaceReflections()`

## Properties

- `System.Single RoughnessCutoff`
  - Stop tracing rays after this roughness value. 
This is meant to be used to avoid tracing rays for very rough surfaces which are unlikely to have any reflections.
This is a performance optimization.

## Methods

### Instance methods

- `virtual System.Void OnEnabled()`
- `virtual System.Void OnDisabled()`
- `virtual System.Void Render()`
