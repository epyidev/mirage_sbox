# Editor.StackLineHandlerAttribute

Marks a method as a custom handler for stack trace lines matching a certain pattern.
The method must take in a `System.Text.RegularExpressions.Match` parameter, and return
a `Editor.StackRow` (or null).

- **Kind:** attribute
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`
- **Base:** `System.Attribute`

## Constructors

- `StackLineHandlerAttribute(System.String regex)`

## Properties

- `System.String Regex`
- `System.Int32 Order`
