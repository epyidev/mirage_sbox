# Sandbox.GameObject

An object in the scene. Functionality is added using Components. A GameObject has a transform, which explains its position,
rotation and scale, relative to its parent. It also has a name, and can be enabled or disabled. When disabled, the GameObject
is still in the scene, but the components don't tick and are all disabled.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `GameObject(System.String name)`
  - Create a new GameObject with the given name. Will be created enabled.
- `GameObject(System.Boolean enabled, System.String name)`
  - Create a new GameObject with the given enabled state and name.
- `GameObject(Sandbox.GameObject parent, System.Boolean enabled, System.String name)`
  - Create a new GameObject with the given parent, enabled state and name.
- `GameObject(System.Boolean enabled)`
- `GameObject()`

## Properties

- `Sandbox.Scene Scene`
  - The scene that this GameObject is in.
- `Sandbox.GameTransform Transform`
  - Our position relative to our parent, or the scene if we don't have any parent.
- `System.String Name`
  - The GameObject's name is usually used for debugging, and for finding it in the scene.
- `System.Boolean IsRoot`
  - Returns true of this is a root object. Root objects are parented to the scene.
- `Sandbox.GameObject Root`
  - Return the root GameObject. The root is the object that is parented to the scene - which could very much be this object.
- `System.Threading.CancellationToken EnabledToken`
  - This token is cancelled when the GameObject ceases to exist, or is disabled
- `Sandbox.ComponentList Components`
  - Access components on this GameObject
- `System.Boolean Enabled`
  - Is this gameobject enabled?
- `Sandbox.GameObject Parent`
- `System.Collections.Generic.List<Sandbox.GameObject> Children`
- `System.Boolean Active`
  - Is this gameobject active. For it to be active, it needs to be enabled, all of its ancestors
need to be enabled, and it needs to be in a scene.
- `Sandbox.DebugOverlaySystem DebugOverlay`
  - Allows drawing of temporary debug shapes and text in the scene
- `System.Boolean IsValid`
  - True if the GameObject is not destroyed
- `System.Boolean IsDestroyed`
  - Return true if this object is destroyed. This will also return true if the object is marked to be destroyed soon.
- `Sandbox.GameObjectFlags Flags`
- `System.Boolean IsDeserializing`
  - True if this GameObject is being deserialized right now
- `System.Boolean HasGimzoHandle`
- `System.Boolean HasGizmoHandle`
- `System.Guid Id`
- `Transform LocalTransform`
  - The local transform of the game object.
- `Vector3 LocalPosition`
  - The local position of the game object.
- `Rotation LocalRotation`
  - The local rotation of the game object.
- `Vector3 LocalScale`
  - The local scale of the game object.
- `System.Boolean IsProxy`
  - True if this is a networked object and is owned by another client. This means that we're
not controlling this object, so shouldn't try to move it or anything.
- `System.Boolean IsNetworkRoot`
  - If true then this object is the root of a networked object.
- `System.Boolean Networked`
  - OBSOLETE: Use NetworkMode instead.
- `Sandbox.NetworkMode NetworkMode`
  - How should this object be networked to other clients? By default, a `Sandbox.GameObject` will be
networked as part of the `Sandbox.GameObject.Scene` snapshot.
- `System.Boolean NetworkInterpolation`
  - Whether our networked transform will be interpolated. This property will only
be synchronized for a root network object.
            
Obsolete: 09/12/2025
- `Sandbox.GameObject.NetworkAccessor Network`
  - Access network information for this GameObject.
- `Sandbox.GameObject.NetworkAccessor RootNetwork`
- `System.String PrefabInstanceSource`
- `System.Boolean IsPrefabInstance`
  - This GameObject is part of a prefab instance.
- `System.Boolean IsPrefabInstanceRoot`
  - This GameObject is the root of a prefab instance.
Returns true for regular instance roots and nested prefab instance roots.
- `Sandbox.GameTags Tags`
- `Transform WorldTransform`
  - The world transform of the game object.
- `Vector3 WorldPosition`
  - The world position of the game object.
- `Rotation WorldRotation`
  - The world rotation of the game object.
- `Vector3 WorldScale`
  - The world scale of the game object.

## Fields

- `static System.Collections.Generic.HashSet<Sandbox.Json.TrackedObjectDefinition> DiffObjectDefinitions`
  - Defines objects within a scene hierarchy we want to track for prefab diffing and patching.

## Methods

### Static methods

- `static Sandbox.GameObject Clone(System.String prefabPath, System.Nullable<Sandbox.CloneConfig> config)`
- `static Sandbox.GameObject Clone(System.String prefabPath, Transform transform, Sandbox.GameObject parent, System.Boolean startEnabled, System.String name)`
  - Clone a prefab from path
- `static Sandbox.GameObject Clone(Sandbox.PrefabFile prefabFile, System.Nullable<Sandbox.CloneConfig> config)`
- `static Sandbox.GameObject Clone(Sandbox.PrefabFile prefabFile, Transform transform, Sandbox.GameObject parent, System.Boolean startEnabled, System.String name)`
  - Clone a prefab from path
- `static Sandbox.GameObject GetPrefab(System.String prefabFilePath)`
  - Get the GameObject of a prefab from file path
- `static System.Object JsonRead(System.Text.Json.Utf8JsonReader reader, System.Type targetType)`
- `static System.Void JsonWrite(System.Object value, System.Text.Json.Utf8JsonWriter writer)`

### Instance methods

- `Sandbox.GameObject Clone(Sandbox.CloneConfig cloneConfig)`
  - Create a unique copy of the passed in GameObject
- `Sandbox.GameObject Clone(Transform transform, Sandbox.GameObject parent, System.Boolean startEnabled, System.String name)`
  - Create a unique copy of the GameObject
- `Sandbox.GameObject Clone()`
  - Create a unique copy of the GameObject
- `Sandbox.GameObject Clone(Vector3 position)`
  - Create a unique copy of the GameObject
- `Sandbox.GameObject Clone(Vector3 position, Rotation rotation)`
  - Create a unique copy of the GameObject
- `Sandbox.GameObject Clone(Vector3 position, Rotation rotation, Vector3 scale)`
  - Create a unique copy of the GameObject
- `Sandbox.GameObject Clone(Sandbox.GameObject parent, Vector3 position, Rotation rotation, Vector3 scale)`
  - Create a unique copy of the GameObject
- `System.Boolean IsDescendant(Sandbox.GameObject decendant)`
  - Returns true if the passed in object is a decendant of ours
- `System.Boolean IsAncestor(Sandbox.GameObject ancestor)`
  - Returns true if the passed in object is an ancestor
- `System.Void AddSibling(Sandbox.GameObject go, System.Boolean before, System.Boolean keepWorldPosition)`
- `System.Void SetParent(Sandbox.GameObject value, System.Boolean keepWorldPosition)`
- `System.Void MakeNameUnique()`
- `System.Collections.Generic.IEnumerable<Sandbox.GameObject> GetAllObjects(System.Boolean enabled)`
- `virtual System.Void EditLog(System.String name, System.Object source)`
- `BBox GetBounds()`
  - This is slow, and somewhat innacurate. Don't call it every frame!
- `BBox GetLocalBounds()`
  - This is slow, and somewhat innacurate. Don't call it every frame!
- `Sandbox.GameObject GetNextSibling(System.Boolean enabledOnly)`
  - Get the GameObject after us,
- `virtual System.Void Destroy()`
  - Destroy this object. Will actually be destroyed at the start of the next frame.
- `System.Void DestroyImmediate()`
  - Destroy this object immediately. Calling this might cause some problems if functions
are expecting the object to still exist, so it's not always a good idea.
- `System.Void Clear()`
  - Destroy all components and child objects
- `virtual System.Void RunEvent(System.Action<T> action, Sandbox.FindMode find)`
- `T AddComponent(System.Boolean startEnabled)`
  - Add a component to this GameObject
- `T GetOrAddComponent(System.Boolean startEnabled)`
  - Add a component to this GameObject
- `T GetComponent(System.Boolean includeDisabled)`
  - Get a component on this GameObject
- `System.Collections.Generic.IEnumerable<T> GetComponents(System.Boolean includeDisabled)`
  - Get components on this GameObject
- `System.Collections.Generic.IEnumerable<T> GetComponentsInChildren(System.Boolean includeDisabled, System.Boolean includeSelf)`
  - Get components on this GameObject and on descendant GameObjects
- `T GetComponentInChildren(System.Boolean includeDisabled, System.Boolean includeSelf)`
  - Get component on this GameObject or on descendant GameObjects
- `System.Collections.Generic.IEnumerable<T> GetComponentsInParent(System.Boolean includeDisabled, System.Boolean includeSelf)`
  - Get components on this GameObject and on ancestor GameObjects
- `T GetComponentInParent(System.Boolean includeDisabled, System.Boolean includeSelf)`
  - Get component on this GameObject and on ancestor GameObjects
- `System.Boolean NetworkSpawn()`
  - Spawn on the network. If you have permission to spawn entities, this will spawn on
everyone else's clients, and you will be the owner.
- `System.Boolean NetworkSpawn(Sandbox.NetworkSpawnOptions options)`
  - Spawn on the network with the specified options. If you have permission to spawn
entities, this will spawn on everyone else's clients.
- `System.Boolean NetworkSpawn(System.Boolean enabled, Sandbox.Connection owner)`
  - Spawn on the network. If you have permission to spawn entities, this will spawn on
everyone else's clients and the owner will be the connection provided.
- `System.Boolean NetworkSpawn(Sandbox.Connection owner)`
  - Spawn on the network. If you have permission to spawn entities, this will spawn on
everyone else's clients and the owner will be the connection provided.
- `System.Void __sync_SetValue(Sandbox.WrappedPropertySet<T> p)`
- `T __sync_GetValue(Sandbox.WrappedPropertyGet<T> p)`
- `System.Void __rpc_Wrapper(Sandbox.WrappedMethod m, T[] argument)`
- `System.Void __rpc_Wrapper(Sandbox.WrappedMethod m, System.Object[] argumentList)`
- `System.Void BreakFromPrefab()`
  - We are cloned from a prefab. Stop that.
- `System.Void UpdateFromPrefab()`
- `System.Void SetPrefabSource(System.String prefabSource)`
- `virtual System.Text.Json.Nodes.JsonObject Serialize(Sandbox.GameObject.SerializeOptions options)`
  - Returns either a full JsonObject with all the GameObjects data,
or if this GameObject is a prefab instance, it will return an object containing the patch/diff between instance and prefab.
- `virtual System.Void Deserialize(System.Text.Json.Nodes.JsonObject node)`
- `virtual System.Void Deserialize(System.Text.Json.Nodes.JsonObject node, Sandbox.GameObject.DeserializeOptions options)`
- `Sandbox.SoundHandle PlaySound(Sandbox.SoundEvent sound, Vector3 positionOffset)`
  - Play this sound on this GameObject. The sound will follow the position of the GameObject.
You'll be able to use GameObject.StopAllSounds to stop all sounds that are following this GameObject.
- `System.Void StopAllSounds(System.Single fadeOutTime)`
  - Stop any sounds playing on this GameObject
