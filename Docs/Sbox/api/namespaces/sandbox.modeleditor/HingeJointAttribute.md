# Sandbox.ModelEditor.HingeJointAttribute

A helper that draws axis of rotation and angle limit of a hinge joint.

- **Kind:** attribute
- **Namespace:** `Sandbox.ModelEditor`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.ModelEditor.Internal.BaseTransformAttribute`

## Constructors

- `HingeJointAttribute()`

## Properties

- `System.String EnableLimit`
  - Key name that dictates whether the hinge limit is enabled or not.
- `System.String MinAngle`
  - Key name that stores the minimum angle value for the revolute joint.
- `System.String MaxAngle`
  - Key name that stores the maximum angle value for the revolute joint.

## Methods

### Instance methods

- `virtual System.Void AddKeys(System.Collections.Generic.Dictionary<System.String,System.Object> dict)`
