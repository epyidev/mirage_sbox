# Sandbox.SceneFile

A scene file contains a collection of GameObject with Components and their properties.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.GameResource`

## Constructors

- `SceneFile()`

## Properties

- `System.Guid Id`
- `System.Text.Json.Nodes.JsonObject[] GameObjects`
- `System.Text.Json.Nodes.JsonObject SceneProperties`
- `System.Int32 ResourceVersion`
- `System.Type ActionGraphTargetType`
- `System.Object ActionGraphTarget`
- `System.String Title`
- `System.String Description`

## Methods

### Instance methods

- `System.String GetMetadata(System.String title, System.String defaultValue)`
- `virtual Sandbox.Bitmap CreateAssetTypeIcon(System.Int32 width, System.Int32 height)`
