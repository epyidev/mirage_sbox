# Sandbox.ColorGrading

Applies color grading to the camera

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.BasePostProcess<T>`

## Constructors

- `ColorGrading()`

## Properties

- `Sandbox.ColorGrading.GradingType GradingMethod`
- `System.Single ColorTempK`
- `System.Single BlendFactor`
- `Sandbox.Texture LookupTexture`
- `Sandbox.ColorGrading.ColorSpaceEnum ColorSpace`
- `Sandbox.Curve RedCurve`
- `Sandbox.Curve GreenCurve`
- `Sandbox.Curve BlueCurve`
- `Sandbox.Curve HueCurve`
- `Sandbox.Curve SaturationCurve`
- `Sandbox.Curve ValueCurve`

## Methods

### Instance methods

- `virtual System.Void Render()`
