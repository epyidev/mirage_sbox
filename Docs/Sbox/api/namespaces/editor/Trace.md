# Editor.Trace

Trace for tools, not to be confused with `Sandbox.SceneTrace`

- **Kind:** struct
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Methods

### Static methods

- `static Editor.Trace Ray(Vector3 from, Vector3 to)`
  - Create a trace ray.
  - `from`: Start position in world space.
  - `to`: End position in world space.

### Instance methods

- `Editor.Trace MeshesOnly()`
  - Only trace against hammer mesh geometry ( CMapMesh nodes )
- `Editor.Trace SkipToolsMaterials()`
  - Don't hit tools materials (materials with the `tools.toolsmaterial` attribute)
- `Editor.TraceResult Run(Editor.MapDoc.MapWorld world)`
  - Runs a trace against given world.
