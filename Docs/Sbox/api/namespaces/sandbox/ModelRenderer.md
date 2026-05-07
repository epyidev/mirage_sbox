# Sandbox.ModelRenderer

Renders a model in the world

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Renderer`

## Constructors

- `ModelRenderer()`

## Properties

- `BBox Bounds`
- `BBox LocalBounds`
- `Sandbox.Model Model`
- `Color Tint`
- `System.Boolean CreateAttachments`
- `System.UInt64 BodyGroups`
- `System.Boolean HasBodyGroups`
- `System.String MaterialGroup`
- `System.Boolean HasMaterialGroups`
- `Sandbox.ModelRenderer.ShadowRenderType RenderType`
- `System.Nullable<System.Int32> LodOverride`
  - Force a level of detail.
- `Sandbox.SceneObject SceneObject`
- `Sandbox.Material MaterialOverride`
- `Sandbox.Engine.MaterialAccessor Materials`
  - Access to the materials

## Methods

### Instance methods

- `Sandbox.GameObject GetAttachmentObject(System.String name)`
  - Get the GameObject of a specific attachment.
- `Sandbox.GameObject GetAttachmentObject(Sandbox.ModelAttachments.Attachment attachment)`
  - Get the GameObject of a specific attachment.
- `virtual Sandbox.GameObject GetBoneObject(Sandbox.BoneCollection.Bone bone)`
- `System.Void SetBodyGroup(System.String name, System.Int32 value)`
  - Set body group value by name
- `System.Void SetBodyGroup(System.String name, System.String choice)`
  - Set body group value by name and choice
- `System.Void SetBodyGroup(System.Int32 part, System.Int32 value)`
  - Set body group value by index
- `System.Int32 GetBodyGroup(System.String name)`
  - Get body group value by name
- `System.Int32 GetBodyGroup(System.Int32 part)`
  - Get body group value by index
- `virtual System.Void UpdateObject()`
- `virtual System.Void OnEnabled()`
- `virtual System.Void OnRenderOptionsChanged()`
- `virtual System.Void SetMaterial(Sandbox.Material material, System.Int32 triangle)`
- `virtual Sandbox.Material GetMaterial(System.Int32 triangle)`
- `virtual System.Void CopyFrom(Sandbox.Renderer other)`
  - Copy everything from another renderer
- `System.Void ClearMaterialOverrides()`
  - Completely stop overriding materials
- `System.Void SetMaterialOverride(Sandbox.Material material, System.String target)`
  - Set a material override for a material with a specific attribute set. For example, if you have a model with lots of different materials, but one of them has an attribute "skin" set to "1", then 
calling this with a material and "skin" will override only that material.
