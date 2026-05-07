# Sandbox.Engine.MaterialAccessor.ITarget

The target of a MaterialAccessor. This is the object that will be modified when setting or clearing material overrides.

- **Kind:** interface
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Engine.MaterialAccessor`

## Properties

- `System.Boolean IsValid`
  - Return true if this target is valid

## Methods

### Instance methods

- `virtual System.Int32 GetMaterialCount()`
  - The number of materials on this target
- `virtual Sandbox.Material Get(System.Int32 index)`
  - Get the original material, before overrides, matching this index
- `virtual System.Void SetOverride(System.Int32 index, Sandbox.Material material)`
  - Set the override material for this index.
- `virtual System.Void ClearOverrides()`
  - Wipe all overrides
