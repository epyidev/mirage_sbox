# Sandbox.GameObjectFlags

- **Kind:** enum
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Enum`

## Values

- `None`
- `Hidden` - Hide this object in hierarchy/inspector
- `NotSaved` - Don't save this object to disk, or when duplicating
- `Bone` - Auto created - it's a bone, driven by animation
- `Attachment` - Auto created - it's an attachment
- `Error` - There's something wrong with this
- `Loading` - Loading something
- `Deserializing` - Is in the process of deserializing
- `DontDestroyOnLoad` - When loading a new scene, keep this gameobject active
- `NotNetworked` - Keep local - don't network this object as part of the scene snapshot
- `Refreshing` - In the process of refreshing from the network
- `ProceduralBone` - Stops animation stomping the bone, will use the bone's local position
- `EditorOnly` - Only exists in the editor. Don't spawn it in game.
- `Absolute` - Ignore the parent transform. Basically, position: absolute for gameobjects.
- `PhysicsBone` - The position of this object is controlled by by physics - usually via a RigidBody component
- `NoInterpolation` - Stops this object being interpolated, either via the network system or the physics system
