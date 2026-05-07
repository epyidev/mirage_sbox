# ISceneUndoScope

- **Kind:** interface
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`

## Methods

### Instance methods

- `virtual ISceneUndoScope WithGameObjectCreations()`
- `virtual ISceneUndoScope WithGameObjectDestructions(System.Collections.Generic.IEnumerable<Sandbox.GameObject> gameObjects)`
- `virtual ISceneUndoScope WithGameObjectDestructions(Sandbox.GameObject gameObject)`
- `virtual ISceneUndoScope WithGameObjectChanges(System.Collections.Generic.IEnumerable<Sandbox.GameObject> objects, GameObjectUndoFlags flags)`
- `virtual ISceneUndoScope WithGameObjectChanges(Sandbox.GameObject gameObject, GameObjectUndoFlags flags)`
- `virtual ISceneUndoScope WithComponentCreations()`
- `virtual ISceneUndoScope WithComponentDestructions(System.Collections.Generic.IEnumerable<Sandbox.Component> components)`
- `virtual ISceneUndoScope WithComponentDestructions(Sandbox.Component component)`
- `virtual ISceneUndoScope WithComponentChanges(System.Collections.Generic.IEnumerable<Sandbox.Component> components)`
- `virtual ISceneUndoScope WithComponentChanges(Sandbox.Component component)`
- `virtual System.IDisposable Push()`
