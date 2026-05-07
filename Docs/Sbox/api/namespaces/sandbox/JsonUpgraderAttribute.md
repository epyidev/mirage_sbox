# Sandbox.JsonUpgraderAttribute

An attribute that describes a version update for a JSON object.

- **Kind:** attribute
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Attribute`

## Constructors

- `JsonUpgraderAttribute(System.Type type, System.Int32 version)`

## Properties

- `System.Int32 Version`
  - The version of this upgrade.
- `System.Type Type`
  - The type we're targeting for this upgrade.
