# Sandbox.SceneCullingBox

A box which can be used to explicitly control scene visibility. 
There are two modes:
1. Cull inside, hide any objects fully inside the box (excluder)
2. Cull outside, hide any objects not intersecting any cull boxes marked cull outside (includer)

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `SceneCullingBox(Sandbox.SceneWorld world, Transform transform, Vector3 size, Sandbox.SceneCullingBox.CullMode mode)`
  - Create a scene culling box.
Each scene world can have a list of boxes which can be used to explicitly cull objects inside or outside the boxes.

## Properties

- `System.Boolean IsValid`
  - Is this culling box valid, exists inside a scene world.
- `Sandbox.SceneWorld World`
  - The scene world this culling box belongs to.
- `Transform Transform`
  - Position and rotation of this box, scale will scale the box size
- `Vector3 Size`
  - Size of this box, transform scale will scale this size
- `Sandbox.SceneCullingBox.CullMode Mode`
  - Cull mode, either inside or outside

## Methods

### Instance methods

- `System.Void Delete()`
  - Delete this culling box. You shouldn't access it anymore.
