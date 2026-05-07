# Sandbox.PrefabFile

A GameObject which is saved to a file.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.GameResource`

## Constructors

- `PrefabFile()`

## Properties

- `System.Text.Json.Nodes.JsonObject RootObject`
  - Contains the original JSON read from File.
- `System.Int32 ResourceVersion`
- `System.Boolean ShowInMenu`
  - If true then we'll show this in the right click menu, so people can create it
- `System.String MenuPath`
  - If ShowInMenu is true, this is the path in the menu for this prefab
- `System.String MenuIcon`
  - Icon to show to the left of the option in the menu
- `System.Boolean DontBreakAsTemplate`
  - If true then the prefab will not be broken when created as a template
- `System.Type ActionGraphTargetType`
- `System.Object ActionGraphTarget`

## Methods

### Static methods

- `static Sandbox.PrefabFile Load(System.String path)`
  - Load a prefab by file path. Also handles mount:// paths

### Instance methods

- `Sandbox.PrefabScene GetScene()`
  - Get the actual scene scene
- `virtual System.Void PostLoad()`
- `virtual System.Void PostReload()`
- `virtual System.Void OnDestroy()`
- `System.String GetMetadata(System.String title, System.String defaultValue)`
  - Read metadata saved using a ISceneMetadata based component, such as SceneInformation
- `virtual Sandbox.Bitmap CreateAssetTypeIcon(System.Int32 width, System.Int32 height)`
