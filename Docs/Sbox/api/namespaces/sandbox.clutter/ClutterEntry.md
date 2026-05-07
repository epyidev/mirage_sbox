# Sandbox.Clutter.ClutterEntry

Represents a single weighted entry in a `Sandbox.Clutter.ClutterDefinition`.
Contains either a Prefab or Model reference along with spawn parameters.

- **Kind:** class
- **Namespace:** `Sandbox.Clutter`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `ClutterEntry()`

## Properties

- `Sandbox.GameObject Prefab`
  - Prefab to spawn. If set, this takes priority over `Sandbox.Clutter.ClutterEntry.Model`.
- `Sandbox.Model Model`
  - Model to spawn as a static prop. Only used if `Sandbox.Clutter.ClutterEntry.Prefab` is null.
- `System.Single Weight`
  - Relative weight for random selection. Higher values = more likely to be chosen.
- `System.Boolean HasAsset`
  - Returns whether this entry has a valid asset to spawn.
- `System.String AssetName`
  - Returns the primary asset reference as a string for debugging.
