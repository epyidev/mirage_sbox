# Sandbox.DepthOfField

Applies a depth of field effect to the camera

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.BasePostProcess<T>`

## Constructors

- `DepthOfField()`

## Properties

- `System.Single BlurSize`
  - How blurry to make stuff that isn't in focus.
- `System.Single FocalDistance`
  - How far away from the camera to focus in world units.
- `System.Single FocusRange`
  - This modulates how far is the blur to the image.
- `System.Boolean FrontBlur`
  - Should we blur what's ahead the focal point towards us?
- `System.Boolean BackBlur`
  - Should we blur what's behind the focal point?

## Methods

### Instance methods

- `virtual System.Void Render()`
