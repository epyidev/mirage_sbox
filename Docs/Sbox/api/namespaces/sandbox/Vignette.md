# Sandbox.Vignette

Applies a vignette to the camera

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.BasePostProcess<T>`

## Constructors

- `Vignette()`

## Properties

- `Color Color`
  - The color of the vignette or the "border"
- `System.Single Intensity`
  - How strong the vignette is. This is a value between 0 -&gt; 1
- `System.Single Smoothness`
  - How much fall off or how blurry the vignette is
- `System.Single Roundness`
  - How circular or round the vignette is
- `Vector2 Center`
  - The center of the vignette in relation to UV space. This means
a value of {0.5, 0.5} is the center of the screen

## Methods

### Instance methods

- `virtual System.Void Render()`
