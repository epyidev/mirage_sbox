# Sandbox.VertexBuffer

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `VertexBuffer()`

## Properties

- `System.Boolean Indexed`
  - Whether this vertex buffer has any indexes. This is set by `Sandbox.VertexBuffer.Init(System.Boolean)`.

## Fields

- `Sandbox.Vertex Default`

## Methods

### Instance methods

- `virtual System.Void Clear()`
  - Clear all vertices and indices, and resets `Sandbox.VertexBuffer.Default`.
- `virtual System.Void Init(System.Boolean useIndexBuffer)`
  - Clear the buffer and set whether it will have indices.
  - `useIndexBuffer`: Whether this buffer will have indices. Affects `Sandbox.VertexBuffer.Indexed`.
- `System.Void Add(Sandbox.Vertex v)`
  - Add a vertex
- `System.Void AddIndex(System.Int32 i)`
  - Add an index. This is relative to the top of the vertex buffer. So 0 is Vertex.Count., 1 is Vertex.Count -1
- `System.Void AddTriangleIndex(System.Int32 a, System.Int32 b, System.Int32 c)`
  - Add a triangle by indices. This is relative to the top of the vertex buffer. So 0 is Vertex.Count.
- `System.Void AddRawIndex(System.Int32 i)`
  - Add an index. This is NOT relative to the top of the vertex buffer.
- `System.Void Draw(Sandbox.Material material, Sandbox.RenderAttributes attributes)`
  - Draw this mesh using Material
