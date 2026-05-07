# Sandbox.ModelEditor.HandPoseAttribute

A helper used for VR hand purposes.

- **Kind:** attribute
- **Namespace:** `Sandbox.ModelEditor`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.ModelEditor.Internal.BaseModelDocAttribute`

## Constructors

- `HandPoseAttribute(System.String originKey, System.String anglesKey, System.String model, System.Boolean isRightHand)`
  - `originKey`: Internal name of the key to store position in.
  - `anglesKey`: Internal name of the key to store angles in.
  - `model`: Path to a model to use.
  - `isRightHand`: Whether this helper represents the right hand or not. This decides the names of the bones the helper will try to use.

## Properties

- `System.String Label`
  - Text label this helper will have when hovered/selected.
- `System.String Enabled`
  - Internal name of the key that controls whether this helper is visible or not.

## Methods

### Instance methods

- `virtual System.Void AddKeys(System.Collections.Generic.Dictionary<System.String,System.Object> dict)`
