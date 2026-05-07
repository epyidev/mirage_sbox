# Sandbox.GameTransform

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `Sandbox.GameObject GameObject`
- `Sandbox.TransformProxy Proxy`
- `Transform InterpolatedLocal`
  - The current interpolated local transform.
- `Transform Local`
  - The current local transform.
- `Transform World`
  - The current world transform.
- `Vector3 Position`
  - The position in world coordinates.
- `Rotation Rotation`
  - The rotation in world coordinates.
- `Vector3 Scale`
  - The scale in world coordinates.
- `Vector3 LocalPosition`
  - Position in local coordinates.
- `Rotation LocalRotation`
  - Rotation in local coordinates.
- `Vector3 LocalScale`
  - Scale in local coordinates.

## Fields

- `System.Action OnTransformChanged`
  - Called when the transform is changed

## Methods

### Instance methods

- `System.Void LerpTo(Transform target, System.Single frac)`
  - Performs linear interpolation between this and the given transform.
  - `target`: The destination transform.
  - `frac`: Fraction, where 0 would return this, 0.5 would return a point between this and given transform, and 1 would return the given transform.
- `System.IDisposable DisableProxy()`
  - Disable the proxy temporarily
- `System.Void ClearInterpolation()`
  - Clear any interpolation and force us to reach our final destination immediately. If we own this object
we'll tell other clients to clear interpolation too when they receive the next network update from us.
- `System.Void ClearLerp()`
