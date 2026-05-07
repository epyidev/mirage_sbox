# Sandbox.BoneCollection.Bone

A bone in a `Sandbox.BoneCollection`.

- **Kind:** abstract class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.BoneCollection`

## Constructors

- `Bone()`

## Properties

- `System.Int32 Index`
  - Numerical index of this bone.
- `System.String Name`
  - Name of this bone.
- `Sandbox.BoneCollection.Bone Parent`
  - The parent bone.
- `Transform LocalTransform`
  - Transform on this bone, relative to the root bone.
- `System.Boolean HasChildren`
  - Whether this bone has any child bones.
- `System.Collections.Generic.IReadOnlyList<Sandbox.BoneCollection.Bone> Children`
  - List of all bones that descend from this bone.

## Methods

### Instance methods

- `System.Boolean IsNamed(System.String name)`
  - Whether this bone has given name or not.
