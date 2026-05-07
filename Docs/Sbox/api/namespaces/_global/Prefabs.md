# Editor.EditorUtility.Prefabs

- **Kind:** static class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Tools`
- **Declaring type:** `Editor.EditorUtility`

## Methods

### Static methods

- `static System.Boolean IsOuterMostPrefabRoot(System.Object obj)`
  - Returns the name of the prefab file that this GameObject or Component is an instance of.
- `static System.String GetOuterMostPrefabName(System.Object obj)`
  - Returns the name of the prefab file that this GameObject or Component is an instance of.
- `static System.Boolean IsPropertyOverridden(Sandbox.SerializedProperty prop)`
  - `PrefabInstanceData.IsPropertyOverridden(System.Object,System.String,System.Boolean)`
- `static System.Boolean IsGameObjectAddedToInstance(Sandbox.GameObject go)`
  - `PrefabInstanceData.IsAddedGameObject(Sandbox.GameObject)`
- `static System.Boolean IsComponentAddedToInstance(Sandbox.Component comp)`
  - `PrefabInstanceData.IsAddedComponent(Sandbox.Component)`
- `static System.Boolean IsInstanceModified(Sandbox.GameObject prefabInstance)`
  - `PrefabInstanceData.IsModified`
- `static System.Boolean IsGameObjectInstanceModified(Sandbox.GameObject go)`
  - `PrefabInstanceData.IsGameObjectModified(Sandbox.GameObject,System.Boolean)`
- `static System.Boolean IsComponentInstanceModified(Sandbox.Component comp)`
  - `PrefabInstanceData.IsComponentModified(Sandbox.Component)`
- `static System.Boolean IsComponentPartOfInstance(Sandbox.Component comp)`
  - Returns true if the owning GameObject is part of a prefab instance.
- `static System.Void RevertPropertyChange(Sandbox.SerializedProperty prop)`
  - `PrefabInstanceData.RevertPropertyChange(System.Object,System.String)`
- `static System.Void ApplyPropertyChange(Sandbox.SerializedProperty prop)`
  - `PrefabInstanceData.ApplyPropertyChangeToPrefab(System.Object,System.String)`
- `static System.Void RevertComponentInstanceChanges(Sandbox.Component comp)`
  - `PrefabInstanceData.RevertComponentChanges(Sandbox.Component)`
- `static System.Void RevertGameObjectInstanceChanges(Sandbox.GameObject go)`
  - `PrefabInstanceData.RevertGameObjectChanges(Sandbox.GameObject)`
- `static System.Void ApplyComponentInstanceChangesToPrefab(Sandbox.Component comp)`
  - `PrefabInstanceData.ApplyComponentChangesToPrefab(Sandbox.Component)`
- `static System.Void AddInstanceAddedGameObjectToPrefab(Sandbox.GameObject go)`
  - `PrefabInstanceData.AddGameObjectToPrefab(Sandbox.GameObject)`
- `static System.Void ApplyGameObjectInstanceChangesToPrefab(Sandbox.GameObject go)`
  - `PrefabInstanceData.ApplyGameObjectChangesToPrefab(Sandbox.GameObject)`
- `static System.Void WriteInstanceToPrefab(Sandbox.GameObject go, System.Boolean skipDiskWrite)`
  - Write a prefab instance back to the prefab file and save it to disk.
- `static System.Void ConvertGameObjectToPrefab(Sandbox.GameObject go, System.String saveLocation, System.Boolean skipDiskWrite)`
  - Convert a GameObject to a prefab. This will write the newly created prefab to disk and set the prefab source on the GameObject.
- `static Sandbox.SerializedProperty GetTargets(Sandbox.GameObject root, Sandbox.PrefabVariable variable)`
  - Get a SerializedProperty representing variable targets. Will return null if there are no targets
- `static Sandbox.PrefabScene.VariableCollection GetVariables(Sandbox.SerializedObject obj)`
- `static Sandbox.PrefabFile CreateAsset(Sandbox.GameObject clone)`
  - Create a prefab out of any GameObject
- `static System.Collections.Generic.IEnumerable<Sandbox.PrefabFile> GetTemplates()`
  - Fetches all prefab templates to show in Create GameObject menus
