# Editor.MapDoc.MapMesh

MapMesh is the Hammer map node which represents editable mesh geometry in a Hammer map.
This is the map node that is created when using the hammer geometry editing tools.

- **Kind:** class
- **Namespace:** `Editor.MapDoc`
- **Assembly:** `Sandbox.Tools`
- **Base:** `Editor.MapDoc.MapNode`

## Constructors

- `MapMesh(Editor.MapDoc.MapDocument mapDocument)`

## Methods

### Instance methods

- `System.Void SetMaterial(Sandbox.Material material)`
  - Assigns the specified material to the entire mesh
- `System.Void ConstructFromPolygons(Editor.MeshEditor.PrimitiveBuilder.PolygonMesh mesh)`
  - Constructs the mesh from the given `Editor.MeshEditor.PrimitiveBuilder.PolygonMesh` builder.
- `System.Collections.Generic.IEnumerable<Editor.Asset> GetFaceMaterialAssets()`
  - Get all material assets used on this mesh
