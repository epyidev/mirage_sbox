# Sandbox.SceneUtility

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Methods

### Static methods

- `static System.Collections.Generic.Dictionary<System.Guid,System.Guid> MakeIdGuidsUnique(System.Text.Json.Nodes.JsonObject json, System.Nullable<System.Guid> rootGuid)`
- `static System.Void MakeGameObjectsUnique(System.Text.Json.Nodes.JsonObject json, System.Nullable<System.Guid> rootGuid)`
- `static Sandbox.GameObject Instantiate(Sandbox.GameObject template, Transform transform)`
  - Create a unique copy of the passed in GameObject
- `static Sandbox.GameObject Instantiate(Sandbox.GameObject template)`
  - Create a unique copy of the passed in GameObject
- `static Sandbox.GameObject Instantiate(Sandbox.GameObject template, Vector3 position, Rotation rotation)`
  - Create a unique copy of the passed in GameObject
- `static Sandbox.GameObject Instantiate(Sandbox.GameObject template, Vector3 position)`
  - Create a unique copy of the passed in GameObject
- `static Sandbox.PrefabScene GetPrefabScene(Sandbox.PrefabFile prefabFile)`
  - Get a (cached) scene from a PrefabFile
- `static System.Void RenderGameObjectToBitmap(Sandbox.GameObject objSource, Sandbox.Bitmap bitmap)`
  - Render a GameObject to a bitmap. This is usually used for easily rendering "previews" of GameObjects, 
for things like saving thumbnails etc.
- `static System.Void RenderModelBitmap(Sandbox.Model model, Sandbox.Bitmap bitmap)`
  - Render a Model to a bitmap. This is usually used for easily rendering "previews" of Models for thumbnails
- `static System.Void RunInBatchGroup(System.Action action)`
  - Run an action inside a batch group. A batchgroup is used with GameObject and Components to
make sure that their OnEnable/OnDisable and other callbacks are called in a deterministic order,
and that they can find each other during creation.
