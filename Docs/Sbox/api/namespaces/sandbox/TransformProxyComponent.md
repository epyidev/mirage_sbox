# Sandbox.TransformProxyComponent

Help to implement a component that completely overrides the transform. This is useful for scenarios
where you will want to keep the local transform of a GameObject, but want to offset based on that 
for some reason.
Having multiple of these on one GameObject is not supported, and will result in weirdness.

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `TransformProxyComponent()`

## Methods

### Instance methods

- `virtual System.Void OnEnabled()`
- `virtual System.Void OnDisabled()`
- `virtual Transform GetLocalTransform()`
  - Override to provide the local transform
- `virtual System.Void SetLocalTransform(Transform& modreq(System.Runtime.InteropServices.InAttribute) value)`
- `virtual Transform GetWorldTransform()`
  - Override to provide the world transform. The default implementation will calculate it using GetLocalTransform() based on the parent.
- `virtual System.Void SetWorldTransform(Transform value)`
  - Called when the world transform is being set
- `System.Void MarkTransformChanged()`
  - Tell our other components, and our children that our transform has changed. This will
update things like Renderers to update their render positions.
