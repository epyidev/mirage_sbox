# Sandbox.MeshComponent

An editable polygon mesh with collision

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Collider`

## Constructors

- `MeshComponent()`

## Properties

- `Sandbox.PolygonMesh Mesh`
- `Sandbox.MeshComponent.CollisionType Collision`
- `Color Color`
- `System.Single SmoothingAngle`
- `System.Boolean HideInGame`
- `Sandbox.ModelRenderer.ShadowRenderType RenderType`
- `Sandbox.Model Model`
- `System.Boolean IsConcave`

## Methods

### Instance methods

- `virtual System.Void SetMaterial(Sandbox.Material material, System.Int32 triangle)`
- `virtual Sandbox.Material GetMaterial(System.Int32 triangle)`
- `System.Void RebuildMesh()`
