# Sandbox.Clutter.ClutterGridSystem.ClutterStorage

Manages storage and serialization of painted clutter instances.
Uses binary serialization via BlobData for efficient storage.

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.BlobData`
- **Declaring type:** `Sandbox.Clutter.ClutterGridSystem`

## Constructors

- `ClutterStorage()`

## Properties

- `System.Int32 Version`
- `System.Int32 TotalCount`
  - Gets the total number of instances across all models.
- `System.Collections.Generic.IEnumerable<System.String> ModelPaths`
  - Gets all model paths that have instances.

## Methods

### Instance methods

- `System.Collections.Generic.IReadOnlyList<Sandbox.Clutter.ClutterGridSystem.ClutterStorage.Instance> GetInstances(System.String modelPath)`
  - Gets instances for a specific model path.
- `System.Collections.Generic.IReadOnlyDictionary<System.String,System.Collections.Generic.List<Sandbox.Clutter.ClutterGridSystem.ClutterStorage.Instance>> GetAllInstances()`
  - Gets all instances grouped by model path.
- `System.Void AddInstance(System.String modelPath, Vector3 position, Rotation rotation, System.Single scale)`
  - Adds a single instance for a model.
- `System.Void AddInstances(System.String modelPath, System.Collections.Generic.IEnumerable<Sandbox.Clutter.ClutterGridSystem.ClutterStorage.Instance> instances)`
- `System.Int32 Erase(Vector3 position, System.Single radius)`
  - Erases all instances within a radius of a position.
- `System.Boolean ClearModel(System.String modelPath)`
  - Clears all instances for a specific model.
- `System.Void ClearAll()`
  - Clears all instances.
- `virtual System.Void Serialize(Sandbox.BlobData.Writer writer)`
  - Serialize to binary format.
- `virtual System.Void Deserialize(Sandbox.BlobData.Reader reader)`
  - Deserialize from binary format.
