# Sandbox.BoneCollection

A collection of bones. This could be from a model, or an entity

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `BoneCollection()`

## Properties

- `Sandbox.BoneCollection.Bone Root`
  - Root bone of the model.
- `System.Collections.Generic.IReadOnlyList<Sandbox.BoneCollection.Bone> AllBones`
  - List of all bones of our object.

## Methods

### Instance methods

- `System.Boolean HasBone(System.String name)`
  - Whether the model or entity has a given bone by name.
- `Sandbox.BoneCollection.Bone GetBone(System.String name)`
  - Retrieve a bone by name.
