# Sandbox.Doo.MethodAttribute

Marks a static method as callable from within a Doo script.

- **Kind:** attribute
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Attribute`
- **Declaring type:** `Sandbox.Doo`

## Constructors

- `MethodAttribute(System.String path)`
  - Creates a new `Sandbox.Doo.MethodAttribute` with the given method path.

## Properties

- `System.String Path`
  - The fully qualified method path (e.g. "Log.Info").
- `System.String CategoryName`
  - The category portion of the path, derived from the text before the first dot.
