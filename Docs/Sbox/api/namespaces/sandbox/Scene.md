# Sandbox.Scene

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.GameObject`

## Constructors

- `Scene(System.Boolean isEditor)`
- `Scene()`

## Properties

- `Sandbox.CameraComponent Camera`
- `System.Boolean IsEditor`
- `Sandbox.SceneWorld SceneWorld`
- `Sandbox.SceneWorld DebugSceneWorld`
- `System.Boolean HasUnsavedChanges`
- `Sandbox.GameResource Source`
- `Sandbox.GameObjectDirectory Directory`
- `System.String Title`
- `System.String Description`
- `System.Boolean WantsSystemScene`
  - If true we'll additive load the system scene when this scene is loaded. Defaults
to true. You might want to disable this for specific scenes, like menu scenes etc.
- `Sandbox.RenderAttributes RenderAttributes`
  - Global render attributes accessible on any renderable in this Scene.
- `Sandbox.PhysicsWorld PhysicsWorld`
- `System.Boolean IsValid`
  - Returns true if this scene has not been destroyed
- `Sandbox.Volumes.VolumeSystem Volumes`
  - Allows quickly finding components that have a volume
- `Sandbox.Scene.ISceneEditorSession Editor`
  - Allows access to the scene's editor session from the game. This will be null if there is no
editor session active on this scene.
- `System.Boolean IsLoading`
  - Return true if we're in an initial loading phase
- `Sandbox.Navigation.NavMesh NavMesh`
- `System.Single NetworkFrequency`
- `System.Single NetworkRate`
  - One divided by ProjectSettings.Networking.UpdateRate.
- `static System.Collections.Generic.IEnumerable<Sandbox.Scene> All`
  - All active non-editor scenes.
- `System.Boolean IsFixedUpdate`
- `System.Single FixedDelta`
- `System.Single FixedUpdateFrequency`
- `System.Int32 MaxFixedUpdates`
- `System.Int32 PhysicsSubSteps`
- `System.Boolean ThreadedAnimation`
- `System.Boolean UseFixedUpdate`
- `System.Single TimeScale`
- `Sandbox.SceneTrace Trace`

## Methods

### Static methods

- `static Sandbox.Scene CreateEditorScene()`

### Instance methods

- `System.Collections.Generic.IEnumerable<T> GetAllComponents()`
  - Get all components of type. This can include interfaces.
This function can only find enabled/active components.
- `System.Collections.Generic.IEnumerable<Sandbox.Component> GetAllComponents(System.Type type)`
  - Get all components of type. This can include interfaces.
This function can only find enabled/active components.
- `virtual System.Void Finalize()`
- `virtual System.Void Destroy()`
  - Destroy this scene. After this you should never use it again.
- `Sandbox.GameObject CreateObject(System.Boolean enabled)`
  - Create a GameObject on this scene. This doesn't require the scene to be the active scene.
- `System.IDisposable Push()`
  - Push this scene as the active scene, for a scope
- `System.IDisposable BatchGroup()`
  - Collects anything inside into a batch group. A batchgroup is used with GameObject and Components to
make sure that their OnEnable/OnDisable and other callbacks are called in a deterministic order,
and that they can find each other during creation. `Sandbox.GameObject.NetworkSpawn` calls will also be batched.
- `System.Void ClearUnsavedChanges()`
- `System.Collections.Generic.IEnumerable<Sandbox.GameObject> FindAllWithTags(System.Collections.Generic.IEnumerable<System.String> tags)`
- `System.Collections.Generic.IEnumerable<Sandbox.GameObject> FindAllWithTag(System.String tag)`
  - Find objects with tag
- `System.Void ProcessDeletes()`
  - Delete any GameObjects waiting to be deleted
- `virtual System.Void RunEvent(System.Action<T> action, Sandbox.FindMode find)`
- `System.Void StartLoading()`
- `virtual System.Boolean Load(Sandbox.GameResource resource)`
  - Load from the provided `Sandbox.SceneFile`. This will not load the scene for other clients in a
multiplayer session, you should instead use `Sandbox.Game.ChangeScene(Sandbox.SceneLoadOptions)`
if you want to bring other clients.
- `System.Boolean Load(Sandbox.SceneLoadOptions options)`
  - Load from the provided `Sandbox.SceneLoadOptions`. This will not load the scene for other clients in a
multiplayer session, you should instead use `Sandbox.Game.ChangeScene(Sandbox.SceneLoadOptions)`
if you want to bring other clients.
- `System.Boolean LoadFromFile(System.String filename)`
  - Load from the provided file name. This will not load the scene for other clients in a
multiplayer session, you should instead use `Sandbox.Game.ChangeScene(Sandbox.SceneLoadOptions)`
if you want to bring other clients.
- `virtual System.Text.Json.Nodes.JsonObject Serialize(Sandbox.GameObject.SerializeOptions options)`
- `virtual System.Void Deserialize(System.Text.Json.Nodes.JsonObject node, Sandbox.GameObject.DeserializeOptions option)`
- `System.Text.Json.Nodes.JsonObject SerializeProperties()`
- `System.Boolean IsBBoxVisibleToConnection(Sandbox.Connection target, BBox box)`
  - Are these bounds visible to the specified `Sandbox.Connection`?
- `System.Boolean IsPointVisibleToConnection(Sandbox.Connection target, Vector3 position)`
  - Is a position visible to the specified `Sandbox.Connection`?
- `System.Collections.Generic.IEnumerable<T> GetAll()`
  - Get all objects of this type. This could be a component or a GameObjectSystem, or other stuff in the future.
- `System.Void GetAll(System.Collections.Generic.List<T> target)`
- `T Get()`
  - Gets the first object found of this type. This could be a component or a GameObjectSystem, or other stuff in the future.
- `System.IDisposable AddHook(Sandbox.GameObjectSystem.Stage stage, System.Int32 order, System.Action action, System.String className, System.String description)`
  - Call this method on this stage. This returns a disposable that will remove the hook when disposed.
- `T GetSystem()`
  - Get a specific system by type.
- `System.Void GetSystem(T val)`
  - Get a specific system by type.
- `System.Void EditorTick(System.Single timeNow, System.Single timeDelta)`
- `System.Void EditorDraw()`
- `System.Void GameTick(System.Double timeDelta)`
- `System.Collections.Generic.IEnumerable<Sandbox.GameObject> FindInPhysics(Sandbox.Sphere sphere)`
  - Find game objects in a sphere using physics.
- `System.Collections.Generic.IEnumerable<Sandbox.GameObject> FindInPhysics(BBox box)`
  - Find game objects in a box using physics.
- `System.Collections.Generic.IEnumerable<Sandbox.GameObject> FindInPhysics(Sandbox.Frustum frustum)`
  - Find game objects in a frustum using physics.
