# Sandbox.Terrain

Terrain renders heightmap based terrain.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Collider`

## Constructors

- `Terrain()`

## Properties

- `System.Boolean EnableCollision`
- `System.Boolean IsConcave`
- `Sandbox.TerrainStorage Storage`
- `Sandbox.Material MaterialOverride`
- `System.Single TerrainSize`
  - Uniform world size of the width and length of the terrain.
- `System.Single TerrainHeight`
  - World size of the maximum height of the terrain.
- `System.Int32 ClipMapLodLevels`
- `System.Int32 ClipMapLodExtentTexels`
- `System.Int32 SubdivisionFactor`
- `System.Int32 SubdivisionLodCount`
- `Sandbox.ModelRenderer.ShadowRenderType RenderType`
- `Sandbox.Texture HeightMap`
- `Sandbox.Texture ControlMap`
- `System.Int32 ComponentVersion`

## Methods

### Instance methods

- `System.Void Create()`
  - Call on enable or storage change
- `System.Boolean RayIntersects(Ray ray, System.Single distance, Vector3 position)`
  - Given a world ray, finds out the LOCAL position it intersects with this terrain.
- `System.Void SyncCPUTexture(Sandbox.Terrain.SyncFlags flags, Sandbox.RectInt region)`
  - Downloads dirty regions from the GPU texture maps onto the CPU, updating collider data and making changes saveable.
This is used from the editor after modifying.
- `System.Void SyncGPUTexture()`
  - Updates the GPU texture maps with the CPU data
- `System.Nullable<Sandbox.Terrain.TerrainMaterialInfo> GetMaterialAtWorldPosition(Vector3 worldPosition)`
  - Gets terrain material information at a world position.
Returns null if the position is outside terrain bounds.
- `System.Void UpdateMaterialsBuffer()`
  - Upload the Materials buffer, this should be called when materials are added, removed or modified.
