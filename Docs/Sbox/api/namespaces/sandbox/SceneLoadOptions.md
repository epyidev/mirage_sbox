# Sandbox.SceneLoadOptions

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `SceneLoadOptions()`

## Properties

- `System.Boolean ShowLoadingScreen`
- `System.Boolean IsAdditive`
- `System.Boolean DeleteEverything`
  - If true, on load we'll even delete objects that are marked as DontDelete
- `Transform Offset`

## Methods

### Instance methods

- `Sandbox.SceneFile GetSceneFile()`
- `System.Boolean SetScene(Sandbox.SceneFile sceneFile)`
- `System.Boolean SetScene(System.String sceneFileName)`
