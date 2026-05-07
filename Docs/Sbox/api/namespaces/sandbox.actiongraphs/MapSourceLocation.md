# Sandbox.ActionGraphs.MapSourceLocation

Source location for action graphs that belong to a Hammer map. This is used for stack
traces, and for knowing which map to save when editing a graph.

- **Kind:** sealed class
- **Namespace:** `Sandbox.ActionGraphs`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.String MapPathName`
- `Facepunch.ActionGraphs.SerializationOptions SerializationOptions`

## Methods

### Static methods

- `static Sandbox.ActionGraphs.MapSourceLocation Get(System.String mapPathName)`
  - Gets a `Sandbox.ActionGraphs.MapSourceLocation` from a path name.
  - `mapPathName`: Project-relative map path ending with ".vmap" or ".vpk".
