# Sandbox.Mesh

A <a href="https://en.wikipedia.org/wiki/Polygon_mesh">mesh</a> is a basic version of a `Sandbox.Model`,
containing a set of vertices and indices which make up faces that make up a shape.
            


A set of meshes can be used to create a `Sandbox.Model` via the `Sandbox.ModelBuilder` class.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `Mesh()`
- `Mesh(Sandbox.Material material, Sandbox.MeshPrimitiveType primType)`
- `Mesh(System.String name, Sandbox.Material material, Sandbox.MeshPrimitiveType primType)`

## Properties

- `System.Boolean IsValid`
- `Sandbox.MeshPrimitiveType PrimitiveType`
  - Sets the primitive type for this mesh.
- `Sandbox.Material Material`
  - Sets material for this mesh.
- `BBox Bounds`
  - Sets AABB bounds for this mesh.
- `System.Single UvDensity`
  - Used to calculate texture size for texture streaming.
- `System.Boolean HasIndexBuffer`
  - Whether this mesh has an index buffer.
- `System.Int32 IndexCount`
  - Number of indices this mesh has.
- `System.Boolean HasVertexBuffer`
  - Whether this mesh has a vertex buffer.
- `System.Int32 VertexCount`
  - Number of vertices this mesh has.

## Methods

### Static methods

- `static System.Span<System.Int32> TriangulatePolygon(System.Span<Vector3> vertices)`

### Instance methods

- `virtual System.Void Finalize()`
- `System.Void SetVertexRange(System.Int32 start, System.Int32 count)`
  - Set how many vertices this mesh draws (if there's no index buffer)
- `System.Void SetIndexRange(System.Int32 start, System.Int32 count)`
  - Set how many indices this mesh draws
- `System.Void CreateBuffers(Sandbox.VertexBuffer vb, System.Boolean calculateBounds)`
  - Create vertex and index buffers.
  - `vb`: Input vertex buffer. If it is indexed (`Sandbox.VertexBuffer.Indexed`), then index buffer will also be created.
  - `calculateBounds`: Whether to recalculate bounds from the vertex buffer.
- `System.Void CreateIndexBuffer()`
  - Create an empty index buffer, it can be resized later
- `System.Void CreateIndexBuffer(System.Int32 indexCount, System.Collections.Generic.List<System.Int32> data)`
- `System.Void CreateIndexBuffer(System.Int32 indexCount, System.Span<System.Int32> data)`
- `System.Void SetIndexBufferData(System.Collections.Generic.List<System.Int32> data, System.Int32 elementOffset)`
- `System.Void SetIndexBufferData(System.Span<System.Int32> data, System.Int32 elementOffset)`
- `System.Void SetIndexBufferSize(System.Int32 elementCount)`
  - Resize the index buffer.
- `System.Void LockIndexBuffer(Sandbox.Mesh.IndexBufferLockHandler handler)`
  - Lock all the memory in this buffer so you can write to it
- `System.Void LockIndexBuffer(System.Int32 elementCount, Sandbox.Mesh.IndexBufferLockHandler handler)`
  - Lock a specific amount of the memory in this buffer so you can write to it
- `System.Void LockIndexBuffer(System.Int32 elementOffset, System.Int32 elementCount, Sandbox.Mesh.IndexBufferLockHandler handler)`
  - Lock a region of memory in this buffer so you can write to it
- `System.Void CreateVertexBuffer(System.Int32 vertexCount, System.Span<T> data)`
- `System.Void CreateVertexBuffer(System.Int32 vertexCount, System.Collections.Generic.List<T> data)`
- `System.Void CreateVertexBuffer(Sandbox.VertexAttribute[] layout)`
  - Create an empty vertex buffer, it can be resized later
- `System.Void CreateVertexBuffer(System.Int32 vertexCount, Sandbox.VertexAttribute[] layout, System.Collections.Generic.List<T> data)`
- `System.Void CreateVertexBuffer(System.Int32 vertexCount, Sandbox.VertexAttribute[] layout, System.Span<T> data)`
- `System.Void SetVertexBufferData(System.Collections.Generic.List<T> data, System.Int32 elementOffset)`
- `System.Void SetVertexBufferData(System.Span<T> data, System.Int32 elementOffset)`
- `System.Void SetVertexBufferSize(System.Int32 elementCount)`
  - Resize the vertex buffer
- `System.Void LockVertexBuffer(Sandbox.Mesh.VertexBufferLockHandler<T> handler)`
- `System.Void LockVertexBuffer(System.Int32 elementCount, Sandbox.Mesh.VertexBufferLockHandler<T> handler)`
- `System.Void LockVertexBuffer(System.Int32 elementOffset, System.Int32 elementCount, Sandbox.Mesh.VertexBufferLockHandler<T> handler)`
