# Sandbox.HasImplementationAttribute

In ActionGraph, this type parameter can only be satisfied by a type `TArg`, such
that there exists at least one non-abstract type that extends / implements both
`TArg` and `Sandbox.HasImplementationAttribute.BaseType`.

- **Kind:** attribute
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Attribute`

## Constructors

- `HasImplementationAttribute(System.Type baseType)`
  - `baseType`: Base class or interface for which there must exist an extending / implementing type.

## Properties

- `System.Type BaseType`
  - Base class or interface for which there must exist an extending / implementing type.
