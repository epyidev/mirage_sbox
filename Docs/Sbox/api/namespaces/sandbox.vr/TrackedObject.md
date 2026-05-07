# Sandbox.VR.TrackedObject

Represents a physically tracked VR object with a transform

- **Kind:** class
- **Namespace:** `Sandbox.VR`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `TrackedObject(Sandbox.VR.TrackedObject original)`

## Properties

- `System.Type EqualityContract`
- `System.Boolean Active`
  - Whether or not this object is currently accessible (if false, then the transform will not update).
- `Vector3 Velocity`
  - Local velocity of this object.
- `Angles AngularVelocity`
  - Local angular velocity of this object (degrees/s)
- `Transform Transform`
  - The grip pose transform of this tracked object in world space (centered on palm/grip).
This is the default transform used for hand positioning.
- `Transform AimTransform`
  - The aim pose transform of this tracked object in world space (pointing forward).
Use this for aiming, pointing, or ray casting.
- `Sandbox.VR.TrackedDeviceRole Role`
  - Which part of the body this tracked object represents - waist, left shoulder, etc.
- `Sandbox.VR.TrackedDeviceType Type`
  - What type of object this is - tracker, controller, etc.

## Methods

### Instance methods

- `virtual System.Boolean PrintMembers(System.Text.StringBuilder builder)`
- `virtual Sandbox.VR.TrackedObject <Clone>$()`
