# Sandbox.SceneObject

A model scene object that can be rendered within a `Sandbox.SceneWorld`.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `SceneObject(Sandbox.SceneWorld sceneWorld, Sandbox.Model model)`
- `SceneObject(Sandbox.SceneWorld sceneWorld, Sandbox.Model model, Transform transform)`
- `SceneObject(Sandbox.SceneWorld sceneWorld, System.String modelName, Transform transform)`
- `SceneObject(Sandbox.SceneWorld sceneWorld, System.String modelName)`

## Properties

- `Sandbox.RenderAttributes Attributes`
- `Sandbox.SceneWorld World`
  - The scene world this object belongs to.
- `Transform Transform`
  - Transform of this scene object, relative to its `Sandbox.SceneObject.Parent`, or `Sandbox.SceneWorld` if parent is not set.
- `Rotation Rotation`
  - Rotation of this scene object, relative to its `Sandbox.SceneObject.Parent`, or `Sandbox.SceneWorld` if parent is not set.
- `Vector3 Position`
  - Position of this scene object, relative to its `Sandbox.SceneObject.Parent`, or `Sandbox.SceneWorld` if parent is not set.
- `BBox Bounds`
  - Set or get the axis aligned bounding box for this object.
- `BBox LocalBounds`
  - Set the axis aligned bounding box by transforming by this objects transform.
- `System.Boolean RenderingEnabled`
  - Whether this scene object should render or not.
- `Color ColorTint`
  - Color tint of this scene object.
- `Sandbox.SceneObject Parent`
  - Movement parent of this scene object, if any.
- `Sandbox.Model Model`
  - The model this scene object will render.
- `System.UInt64 MeshGroupMask`
  - State of all bodygroups of this object's model. You might be looking for `Sandbox.SceneModel.SetBodyGroup(System.String,System.Int32)`.
- `System.Boolean Batchable`
  - This object is not batchable by material for some reason ( example: has dynamic attributes that affect rendering )
- `Sandbox.SceneObject.SceneObjectFlagAccessor Flags`
  - Access to various advanced scene object flags.
- `Sandbox.SceneRenderLayer RenderLayer`
  - For a layer to draw this object, the target layer must match (or be unset)
and the flags must match
- `Sandbox.ITagSet Tags`
  - List of tags for this scene object.

## Fields

- `Sandbox.Plane ClipPlane`
  - Clipping plane for this scene object. Requires `Sandbox.SceneObject.ClipPlaneEnabled` to be `true`.
- `System.Boolean ClipPlaneEnabled`
  - Whether or not to use the clipping plane defined in `Sandbox.SceneObject.ClipPlane`.

## Methods

### Instance methods

- `System.Void Delete()`
  - Delete this scene object. You shouldn't access it anymore.
- `System.Void AddChild(System.String name, Sandbox.SceneObject child)`
  - Add a named child scene object to this one. The child scene object will have its parent set.
- `System.Void RemoveChild(Sandbox.SceneObject child)`
  - Unlink given scene object as a child from this one. The child scene object will have its parent set to null. It will not be deleted.
- `System.Void SetMaterialOverride(Sandbox.Material material)`
  - Override all materials on this object's `Sandbox.SceneObject.Model`.
- `System.Void ClearMaterialOverride()`
  - Clear all material replacements.
- `System.Void SetMaterialOverride(Sandbox.Material material, System.String attributeName, System.Int32 attributeValue)`
  - Replaces all materials of the model that have the given <b>User Material Attribute</b> set to <b>"1"</b>, with given material.
            


The system checks both the models' default material group materials and the materials of the active material group.
  - `material`: Material to replace with.
  - `attributeName`: Name of the <b>User Material Attribute</b> to test on each material of the model. They are set in the Material Editor's <b>Attributes</b> tab.
  - `attributeValue`: Value of the attribute to test for.
- `System.Void SetMaterialGroup(System.String name)`
  - Set material group to replace materials of the model as set up in ModelDoc.
- `System.Void SetComponentSource(Sandbox.Component c)`
- `Sandbox.GameObject GetGameObject()`
