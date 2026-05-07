# Sandbox.Internal.ClassFileLocationAttribute

Automatically added to codegenerated classes to let them determine their location
This helps when looking for resources relative to them, like style sheets.
Replaced in Sept 2023 by SourceLocationAttribute, which is added to classes and members.

- **Kind:** attribute
- **Namespace:** `Sandbox.Internal`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Attribute`

## Constructors

- `ClassFileLocationAttribute(System.String value)`

## Properties

- `System.String Path`
