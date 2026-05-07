# Sandbox.Engine.Utility.RayTrace.MeshTraceRequest.Result

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Engine.Utility.RayTrace.MeshTraceRequest`

## Properties

- `System.Boolean Hit`
- `System.Single Distance`
  - The distance between start and end positions.
- `Vector3 StartPosition`
  - The start position of the trace
- `Vector3 EndPosition`
  - The end or hit position of the trace
- `Vector3 HitPosition`
  - The hit position of the trace
- `System.Single Fraction`
  - A fraction [0..1] of where the trace hit between the start and the original end positions
- `Vector3 Normal`
  - The hit surface normal (direction vector)
- `System.Int32 HitTriangle`
- `Sandbox.Material Material`
- `Transform Transform`
  - The transform of the hit object (if it has one)
- `Sandbox.SceneObject SceneObject`
  - If we hit something associated with a sceneobject, this will be that object.
- `Vector2 HitTriangleUv`
  - This is the Uv coordinate on the triangle hit. 'x' represents the distance between Vertex 0-1, 'y' represents the distance between Vertex 0-2.
- `Vector3 VertexInfluence`
  - Given the position on the triangle hit, this vector gives the influence of each vertex on that position.
So for example, if the Vector is [1,0,0] that means that the hit point is right on vertex 0. If it's [0.33, 0.33, 0.33] then it's 
right in the middle of each vertex.

## Fields

- `Sandbox.Engine.Utility.RayTrace.MeshTraceRequest.Result.VertexDetail Vertex0`
- `Sandbox.Engine.Utility.RayTrace.MeshTraceRequest.Result.VertexDetail Vertex1`
- `Sandbox.Engine.Utility.RayTrace.MeshTraceRequest.Result.VertexDetail Vertex2`
