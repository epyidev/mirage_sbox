# Sandbox.ChromaticAberration

Applies a chromatic aberration effect to the camera

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.BasePostProcess<T>`

## Constructors

- `ChromaticAberration()`

## Properties

- `System.Single Scale`
  - Strength of the chromatic aberration effect
- `Vector3 Offset`
  - The pixel offset for each color channel. These values should
be very small as it's in UV space. (0.004 for example)
X = Red
Y = Green
Z = Blue

## Methods

### Instance methods

- `virtual System.Void Render()`
