# Sandbox.MapLoader

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `MapLoader(Sandbox.SceneWorld world, Sandbox.PhysicsWorld physics, Vector3 origin)`

## Properties

- `Sandbox.SceneWorld World`
- `Sandbox.PhysicsWorld PhysicsWorld`
- `Vector3 WorldOrigin`

## Fields

- `System.Collections.Generic.List<Sandbox.SceneObject> SceneObjects`

## Methods

### Instance methods

- `virtual System.Void CreateObject(Sandbox.MapLoader.ObjectEntry kv)`
  - Create an object from a serialized object entry
