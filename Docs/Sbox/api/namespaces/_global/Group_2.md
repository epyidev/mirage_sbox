# Sandbox.Internal.IControlSheet.Group

A group is a collection of properties that are related to each other, and can be displayed together in the inspector, usually with a title.

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Reflection`
- **Declaring type:** `Sandbox.Internal.IControlSheet`

## Constructors

- `Group(System.Collections.Generic.List<Sandbox.SerializedProperty> properties)`

## Properties

- `System.String Name`
  - The name of the group, usually displayed as a title in the inspector.
- `System.Collections.Generic.List<Sandbox.SerializedProperty> Properties`
  - The properties that are part of this group, usually displayed together in the inspector.
