# Sandbox.NavMeshArea

An area that influences the NavMesh generation.
Areas can be used to block off parts of the NavMesh.
Static areas have almost no performance overhead.
Moving areas at runtime will have an impact on performance if done excessively.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Volumes.VolumeComponent`

## Constructors

- `NavMeshArea()`

## Properties

- `System.Boolean IsBlocker`
  - Whether navmesh generation in this area will be completely disabled.
- `Sandbox.Engine.Resources.NavMeshAreaDefinition Area`
  - The NavMesh area definition to apply to this area.
- `Sandbox.Collider LinkedCollider`
  - The collider this area's shape is based on.
In almost every case, you will want to use a trigger collider for this.

## Methods

### Instance methods

- `virtual System.Threading.Tasks.Task OnLoad(Sandbox.LoadingContext context)`
