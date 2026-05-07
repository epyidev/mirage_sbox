# Editor.MeshEditor.PrimitiveBuilder.PolygonMesh

A list of vertices and faces.

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Tools`
- **Declaring type:** `Editor.MeshEditor.PrimitiveBuilder`

## Constructors

- `PolygonMesh()`

## Properties

- `System.Collections.Generic.List<Vector3> Vertices`
- `System.Collections.Generic.List<Editor.MeshEditor.PrimitiveBuilder.PolygonMesh.Face> Faces`

## Methods

### Instance methods

- `System.Int32 AddVertex(Vector3 position)`
  - Adds a new vertex to the end of the `Editor.MeshEditor.PrimitiveBuilder.PolygonMesh.Vertices` list.
  - `position`: Position of the vertex to add.
  - returns: The index of the newly added vertex.
- `Editor.MeshEditor.PrimitiveBuilder.PolygonMesh.Face AddFace(System.Int32[] indices)`
  - Adds a new face to the end of the `Editor.MeshEditor.PrimitiveBuilder.PolygonMesh.Faces` list.
  - `indices`: The vertex indices which define the face, ordered anticlockwise.
  - returns: The newly added face.
- `Editor.MeshEditor.PrimitiveBuilder.PolygonMesh.Face AddFace(Vector3[] positions)`
  - Adds a new face to the end of the `Editor.MeshEditor.PrimitiveBuilder.PolygonMesh.Faces` list and it's vertices to the end of the `Editor.MeshEditor.PrimitiveBuilder.PolygonMesh.Vertices` list.
  - `positions`: The vertex positions which define the face, ordered anticlockwise.
  - returns: The newly added face.
