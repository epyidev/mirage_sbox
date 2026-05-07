# Sandbox.Engine.MaterialAccessor

A wrapper to allow the unification of editing materials. This is usually a member on a Component which implements MaterialAccessor.ITarget.

- **Kind:** sealed class
- **Namespace:** `Sandbox.Engine`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `MaterialAccessor(Sandbox.Engine.MaterialAccessor.ITarget renderer)`
  - Create a new material accessor for this object.

## Properties

- `System.Int32 Count`
  - Total number of material slots

## Methods

### Instance methods

- `Sandbox.Material GetOriginal(System.Int32 i)`
  - Get the original material for the specified index.
- `System.Boolean HasOverride(System.Int32 i)`
  - Does this index have an override material?
- `Sandbox.Material GetOverride(System.Int32 i)`
  - Get the override material for this slot. Or null if not set.
- `System.Void SetOverride(System.Int32 i, Sandbox.Material material)`
  - Set an override material for this slot. If the material is null, it will clear the override.
- `System.Void Apply()`
  - Apply to the object. You don't need to call this when setting overrides, as it will automatically apply them to the target when you set them.
This is here as a convenience if this object holds data, and you need to apply it to another object that didn't exist when the
overrides were originally set, or loaded.
