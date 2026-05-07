# Sandbox.ModelBuilder.Bone

A bone definition for use with `Sandbox.ModelBuilder`.

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.ModelBuilder`

## Constructors

- `Bone(System.String Name, System.String ParentName, Vector3 Position, Rotation Rotation)`
  - A bone definition for use with `Sandbox.ModelBuilder`.
  - `Name`: Name of the bone.
  - `ParentName`: Name of the parent bone.
  - `Position`: Position of the bone, relative to its parent.
  - `Rotation`: Rotation of the bone, relative to its parent.

## Properties

- `System.String Name`
  - Name of the bone.
- `System.String ParentName`
  - Name of the parent bone.
- `Vector3 Position`
  - Position of the bone, relative to its parent.
- `Rotation Rotation`
  - Rotation of the bone, relative to its parent.

## Methods

### Instance methods

- `System.Void Deconstruct(System.String Name, System.String ParentName, Vector3 Position, Rotation Rotation)`
