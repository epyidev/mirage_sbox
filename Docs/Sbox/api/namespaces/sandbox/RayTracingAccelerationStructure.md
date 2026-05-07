# Sandbox.RayTracingAccelerationStructure

Represents a ray tracing acceleration structure that contains geometry for efficient ray intersection testing.
This is used to organize scene geometry in a hierarchical structure optimized for ray tracing performance.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Methods

### Static methods

- `static Sandbox.RayTracingAccelerationStructure Create(System.Object geometryData)`
  - Create a ray tracing acceleration structure from scene geometry.
  - `geometryData`: The geometry data to build the acceleration structure from.
  - returns: A new acceleration structure, or null if creation failed.

### Instance methods

- `System.Boolean IsValid()`
  - Gets whether this acceleration structure is valid and can be used for ray tracing.
- `System.Void Update(System.Object geometryData)`
  - Updates the acceleration structure with new geometry data.
This is more efficient than rebuilding from scratch for dynamic geometry.
  - `geometryData`: The updated geometry data.
- `System.Void Dispose()`
  - Releases the native resources associated with this acceleration structure.
