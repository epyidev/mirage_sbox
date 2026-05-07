# Sandbox.Json.TrackedObjectDefinition

Defines characteristics of an object type that should be tracked within a JSON tree structure.
These definitions are used to identify, track, and manage specific types of objects during JSON diffing and patching operations.

- **Kind:** class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Json`

## Constructors

- `TrackedObjectDefinition()`

## Fields

- `System.String Type`
  - A unique identifier for this object type. This is used to categorize objects.
- `System.Func<System.Text.Json.Nodes.JsonObject,System.Single> MatchScore`
  - Determines whether a JSON object should be considered an instance of this tracked object type.
- `System.Func<System.Text.Json.Nodes.JsonObject,System.String> ToId`
  - Maps a JSON object to a unique identifier string.
- `System.String ParentType`
  - Specifies the required type of the parent object. If null, AllowedAsRoot must be true.
- `System.Boolean AllowedAsRoot`
  - If true, objects of this type can be the root of the object tree.
- `System.Boolean Atomic`
  - When true, treats this object as an atomic unit during tracking operations.
- `System.Collections.Generic.HashSet<System.String> IgnoredProperties`
