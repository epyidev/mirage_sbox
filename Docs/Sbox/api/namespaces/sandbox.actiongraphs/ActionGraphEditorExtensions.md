# Sandbox.ActionGraphs.ActionGraphEditorExtensions

Helper methods for action graph editor tools. Mostly workaround for `Sandbox.GameObjectReference`
and `Sandbox.ComponentReference` being internal.

- **Kind:** static class
- **Namespace:** `Sandbox.ActionGraphs`
- **Assembly:** `Sandbox.Tools`

## Methods

### Static methods

- `static System.Collections.Generic.IEnumerable<Sandbox.ActionGraphs.SceneReferenceNode> GetSceneReferences(Facepunch.ActionGraphs.IActionGraphDelegate actionGraphDelegate)`
  - Find all `Sandbox.GameObject`s and `Sandbox.Component`s referenced by the given `Facepunch.ActionGraphs.IActionGraphDelegate`.
- `static System.Nullable<Sandbox.ActionGraphs.SceneReferenceNode> GetSceneReference(Facepunch.ActionGraphs.Node node, Sandbox.Scene scene, Facepunch.ActionGraphs.IActionGraphDelegate actionGraphDelegate)`
- `static System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object> GetNodeProperties(Sandbox.GameObject go)`
- `static System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object> GetNodeProperties(System.String prefabPath)`
- `static System.Collections.Generic.IReadOnlyDictionary<System.String,System.Object> GetNodeProperties(Sandbox.Component component)`
