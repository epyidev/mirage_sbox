# Sandbox.Component

A GameObject can have many components, which are the building blocks of the game.

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `Component()`

## Properties

- `Sandbox.Scene Scene`
  - The scene this Component is in. This is a shortcut for `GameObject.Scene`.
- `Sandbox.GameTransform Transform`
  - The transform of the GameObject this component belongs to. Components don't have their own transforms
but they can access the transform of the GameObject they belong to. This is a shortcut for `GameObject.Transform`.
- `Sandbox.GameObject GameObject`
  - The GameObject this component belongs to.
- `Sandbox.TaskSource Task`
  - Allow creating tasks that are automatically cancelled when the GameObject is destroyed.
- `Sandbox.ComponentList Components`
  - Access components on this component's GameObject
- `System.Boolean Enabled`
  - The enable state of this `Sandbox.Component`.



This doesn't tell you whether the component is actually active because its parent
            `Sandbox.GameObject` might be disabled. This merely tells you what the
            component wants to be. You should use `Sandbox.Component.Active` to determine whether the
            object is truly active in the scene.
- `System.Boolean Active`
  - True if this Component is enabled, and all of its ancestor GameObjects are enabled
- `System.Boolean IsValid`
- `System.Action OnComponentEnabled`
- `System.Action OnComponentStart`
- `System.Action OnComponentUpdate`
- `System.Action OnComponentFixedUpdate`
- `System.Action OnComponentDisabled`
- `System.Action OnComponentDestroy`
- `Sandbox.ITagSet Tags`
- `Sandbox.DebugOverlaySystem DebugOverlay`
  - Allows drawing of temporary debug shapes and text in the scene
- `Sandbox.ComponentFlags Flags`
- `System.Guid Id`
- `Transform LocalTransform`
  - The local transform of the game object.
- `Vector3 LocalPosition`
  - The local position of the game object.
- `Rotation LocalRotation`
  - The local rotation of the game object.
- `Vector3 LocalScale`
  - The local scale of the game object.
- `Sandbox.GameObject.NetworkAccessor Network`
- `System.Boolean IsProxy`
  - True if this is a networked object and is owned by another client. This means that we're
not controlling this object, so shouldn't try to move it or anything.
- `System.Int32 ComponentVersion`
  - The version of the component. Used by `Sandbox.JsonUpgrader`.
- `Transform WorldTransform`
  - The world transform of the game object.
- `Vector3 WorldPosition`
  - The world position of the game object.
- `Rotation WorldRotation`
  - The world rotation of the game object.
- `Vector3 WorldScale`
  - The world scale of the game object.

## Methods

### Static methods

- `static System.Object JsonRead(System.Text.Json.Utf8JsonReader reader, System.Type targetType)`
- `static System.Void JsonWrite(System.Object value, System.Text.Json.Utf8JsonWriter writer)`

### Instance methods

- `virtual System.Void OnAwake()`
  - Called once per component
- `virtual System.Void OnEnabled()`
  - Called after Awake or whenever the component switches to being enabled (because a gameobject hierarchy active change, or the component changed)
- `virtual System.Void OnDisabled()`
- `virtual System.Void OnDestroy()`
  - Called once, when the component or gameobject is destroyed
- `virtual System.Void OnPreRender()`
  - When enabled, called every frame, does not get called on a dedicated server
- `System.Void Destroy()`
  - Destroy this component, if it isn't already destroyed. The component will be removed from its
GameObject and will stop existing. You should avoid interating with the component after calling this.
- `System.Void DestroyGameObject()`
  - Destroy the parent GameObject. This really only exists so when you're typing Destroy you realise
that calling Destroy only destroys the Component - not the whole GameObject.
- `virtual System.Void Reset()`
- `virtual System.Void OnValidate()`
  - Called immediately after deserializing, and when a property is changed in the editor.
- `virtual System.Void OnRefresh()`
  - Called immediately after being refreshed from a network snapshot.
- `System.Void EditLog(System.String name, System.Object source)`
  - Called when something on the component has been edited
- `virtual System.Void OnTagsChanged()`
  - When tags have been updated
- `virtual System.Void OnParentChanged(Sandbox.GameObject oldParent, Sandbox.GameObject newParent)`
  - The parent has changed from one parent to another
- `System.Void Invoke(System.Single secondsDelay, System.Action action, System.Threading.CancellationToken ct)`
  - Invoke a method in x seconds. Won't be invoked if the component is no longer active.
- `virtual System.Void OnParentDestroy()`
  - The parent object is being destroyed. This is a nice place to switch to a healthier parent.
- `System.Void OnPropertyDirty(Sandbox.WrappedPropertySet<T> p)`
- `System.Void OnPropertyDirty()`
- `virtual System.Void OnDirty()`
  - Called when the component has become dirty
- `System.Void Run(Sandbox.Doo doo, System.Action<Sandbox.Doo.Configure> c)`
- `System.Void Stop(Sandbox.Doo doo)`
  - Stop a specific Doo, if it's running
- `System.Void StopAll()`
  - Stop all running Doos
- `System.Boolean IsRunning(Sandbox.Doo doo)`
  - Returns true if the given Doo is currently running on this component.
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
- `virtual System.Void DrawGizmos()`
  - Called in the editor to draw things like bounding boxes etc
- `virtual System.Threading.Tasks.Task OnLoad()`
- `virtual System.Threading.Tasks.Task OnLoad(Sandbox.LoadingContext context)`
- `System.Void __sync_SetValue(Sandbox.WrappedPropertySet<T> p)`
- `T __sync_GetValue(Sandbox.WrappedPropertyGet<T> p)`
- `System.Void __rpc_Wrapper(Sandbox.WrappedMethod m, T[] argument)`
- `System.Void __rpc_Wrapper(Sandbox.WrappedMethod m, System.Object[] argumentList)`
- `System.Text.Json.Nodes.JsonNode Serialize(Sandbox.GameObject.SerializeOptions options)`
- `System.Void Deserialize(System.Text.Json.Nodes.JsonObject node)`
- `System.Void DeserializeImmediately(System.Text.Json.Nodes.JsonObject node)`
  - Deserialize this component as per `Sandbox.Component.Deserialize(System.Text.Json.Nodes.JsonObject)` but update `Sandbox.Component.GameObject` and `Sandbox.Component` property
references immediately instead of having them deferred.
- `virtual System.Void OnStart()`
  - Called once before the first Update - when enabled.
- `virtual System.Void OnUpdate()`
  - When enabled, called every frame
- `virtual System.Void OnFixedUpdate()`
  - When enabled, called on a fixed interval that is determined by the Scene. This
is also the fixed interval in which the physics are ticked. Time.Delta is that
fixed interval.
