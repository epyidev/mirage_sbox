# Editor.MeshEditor.PrimitiveBuilder

Build primitives out of polygons.

- **Kind:** abstract class
- **Namespace:** `Editor.MeshEditor`
- **Assembly:** `Sandbox.Tools`

## Constructors

- `PrimitiveBuilder()`

## Properties

- `System.Boolean Is2D`
  - If this primitive is 2D the bounds box will be limited to have no depth.
- `Sandbox.Material Material`
  - The material to use for this whole primitive.

## Methods

### Instance methods

- `virtual System.Void Build(Editor.MeshEditor.PrimitiveBuilder.PolygonMesh mesh)`
  - Create the primitive in the mesh.
- `virtual System.Void SetFromBox(BBox box)`
  - Setup properties from box.
