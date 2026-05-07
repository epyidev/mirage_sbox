# Sandbox.GameObjectSystem.Stage

A list of stages in the scene tick in which we can hook

- **Kind:** enum
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Enum`
- **Declaring type:** `Sandbox.GameObjectSystem`

## Values

- `StartUpdate` - At the very start of the scene update
- `UpdateBones` - Bones are worked out
- `PhysicsStep` - Physics step, called in fixed update
- `Interpolation` - When transforms are interpolated
- `FinishUpdate` - At the very end of the scene update
- `StartFixedUpdate` - Called at the start of fixed update
- `FinishFixedUpdate` - Called at the end of fixed update
- `SceneLoaded` - Called after a scene has been loaded
