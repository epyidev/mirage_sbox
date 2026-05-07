# Sandbox.VR.VRHand

Updates the parameters on an `Sandbox.SkinnedModelRenderer` on this GameObject based on the skeletal data from SteamVR.
Useful for quick hand posing based on controller input.

- **Kind:** class
- **Namespace:** `Sandbox.VR`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `VRHand()`

## Properties

- `Sandbox.SkinnedModelRenderer SkinnedModelComponent`
  - Which `Sandbox.SkinnedModelRenderer` to use when updating this component
- `Sandbox.VR.VRHand.HandSources HandSource`
  - Which hand should we use to update the parameters?
- `Sandbox.VR.MotionRange MotionRange`
  - What motion range should we use to update the parameters?

## Methods

### Instance methods

- `virtual System.Void OnUpdate()`
- `virtual System.Void OnPreRender()`
