# Sandbox.ResourceExtension<T>

A GameResource type that adds extended properties to another resource type. You should prefer to use
the type with to generic arguments, and define your own type as the second argument. That way you get
access to the helper methods.

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.GameResource`

## Constructors

- `ResourceExtension<T>()`

## Properties

- `System.Boolean ExtensionDefault`
  - If true then this is returned when calling FindForResourceOrDefault if
no other extension is found targetting a specific resource.
- `System.Collections.Generic.List<T> ExtensionTargets`
  - Extensions can target more than one resource.
