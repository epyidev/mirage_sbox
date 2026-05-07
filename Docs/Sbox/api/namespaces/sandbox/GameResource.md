# Sandbox.GameResource

Assets defined in C# and created through tools.
You can define your own <a href="https://sbox.game/dev/doc/assetsresources/custom-assets/">Custom Asset Types</a>.

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Resource`

## Constructors

- `GameResource()`

## Properties

- `System.Boolean HasUnsavedChanges`
  - True if this resource has changed but the changes aren't written to disk
- `System.Type ActionGraphTargetType`
  - Target type used for any action graphs contained in this resource.
Defaults to this resource's type.
- `System.Object ActionGraphTarget`
  - Target instance used for any action graphs contained in this resource.
Defaults to this resource itself.
- `System.Int32 ResourceVersion`
  - The version of the component. Used by `Sandbox.JsonUpgrader`.
- `System.Boolean IsValid`

## Methods

### Instance methods

- `virtual System.Void StateHasChanged()`
  - Should be called after the resource has been edited by the inspector
- `System.Collections.Generic.IEnumerable<System.String> GetReferencedPackages()`
  - Get a list of packages that are needed to load this asset
- `virtual System.Void PostLoad()`
  - Called when the asset is first loaded from disk.
- `virtual System.Void PostReload()`
  - Called when the asset is recompiled/reloaded from disk.
- `System.Text.Json.Nodes.JsonObject Serialize()`
  - Serialize the current state to a JsonObject
- `System.Void LoadFromJson(System.String json)`
- `System.Void Deserialize(System.Text.Json.Nodes.JsonObject jso)`
  - Deserialize values from a JsonObject
- `virtual System.Void OnJsonSerialize(System.Text.Json.Nodes.JsonObject node)`
  - Called after we serialize, allowing you to store any extra or modify the output.
- `virtual System.Void OnDestroy()`
  - Called when this resource is being unloaded.
Clean up any resources owned by this instance here.
