# Sandbox.ModelEditor.Internal.BaseTransformAttribute

- **Kind:** attribute
- **Namespace:** `Sandbox.ModelEditor.Internal`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.ModelEditor.Internal.BaseModelDocAttribute`

## Constructors

- `BaseTransformAttribute(System.String name)`

## Properties

- `System.String Bone`
  - Internal name of the key that dictates which bone to use as parent for position/angles.
- `System.String Attachment`
  - Internal name of the key that dictates which attachment to use as parent for position/angles.
- `System.String Origin`
  - Internal name of the key to store position in, if set, allows the helper to be moved.
- `System.String Angles`
  - Internal name of the key to store angles in, allows the helper to be rotated.

## Methods

### Instance methods

- `virtual System.Void AddTransform(System.Text.StringBuilder sb)`
