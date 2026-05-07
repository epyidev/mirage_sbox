# Sandbox.IValid

Interface for objects that can become invalid over time,
such as references to deleted game objects or disposed resources.

- **Kind:** interface
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Properties

- `System.Boolean IsValid`
  - Returns true if this object is still valid and can be safely accessed.
When false, accessing the object's properties or methods may throw exceptions.
