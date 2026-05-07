# Sandbox.Engine.Utility.RayTrace.MeshTraceRequest

- **Kind:** struct
- **Namespace:** `Sandbox.Engine.Utility.RayTrace`
- **Assembly:** `Sandbox.Engine`

## Methods

### Instance methods

- `Sandbox.Engine.Utility.RayTrace.MeshTraceRequest.Result Run()`
  - Run the trace and return the result. The result will return the first hit.
- `Sandbox.Engine.Utility.RayTrace.MeshTraceRequest.Result[] RunAll()`
- `Sandbox.Engine.Utility.RayTrace.MeshTraceRequest Ray(Vector3 from, Vector3 to)`
  - Casts a ray from point A to point B.
- `Sandbox.Engine.Utility.RayTrace.MeshTraceRequest Ray(Ray ray, System.Single distance)`
  - Casts a ray from a given position and direction, up to a given distance.
- `Sandbox.Engine.Utility.RayTrace.MeshTraceRequest WithTag(System.String tag)`
  - Only return scene objects with this tag. Subsequent calls to this will add multiple requirements
and they'll all have to be met (ie, the scene object will need all tags).
- `Sandbox.Engine.Utility.RayTrace.MeshTraceRequest WithAllTags(System.String[] tags)`
  - Only return scene objects with all of these tags
- `Sandbox.Engine.Utility.RayTrace.MeshTraceRequest WithAnyTags(System.String[] tags)`
  - Only return scene objects with any of these tags
- `Sandbox.Engine.Utility.RayTrace.MeshTraceRequest WithoutTags(System.String[] tags)`
  - Only return scene objects without any of these tags
