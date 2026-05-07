# Sandbox.VR.VRTrackedObject

Updates this GameObject's transform based on a given tracked object (e.g. left controller, HMD).

- **Kind:** class
- **Namespace:** `Sandbox.VR`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `VRTrackedObject()`

## Properties

- `Sandbox.VR.VRTrackedObject.PoseSources PoseSource`
  - Which tracked object should we use to update the transform?
- `Sandbox.VR.VRTrackedObject.PoseTypes PoseType`
  - Which pose type to use (only applies to hand controllers, not the head).
Grip is centered on the palm, Aim points forward for aiming/pointing.
- `Sandbox.VR.VRTrackedObject.TrackingTypes TrackingType`
  - Which parts of the transform should be updated? (eg. rotation, position)
- `System.Boolean UseRelativeTransform`
  - If this is checked, then the transform used will be relative to the VR anchor (rather than an absolute world position).

## Methods

### Instance methods

- `virtual System.Void OnUpdate()`
- `virtual System.Void OnPreRender()`
