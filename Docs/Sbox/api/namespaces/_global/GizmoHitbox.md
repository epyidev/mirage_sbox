# Sandbox.Gizmo.GizmoHitbox

Contains functions to add objects to the immediate mode Scene. This
is an instantiable class so it's possible to add extensions.

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Gizmo`

## Properties

- `System.Boolean CanInteract`
  - Whether or not drawn gizmos can be interacted with. Only affects gizmos in the current scope.
- `System.Boolean Debug`
- `System.Single DepthBias`

## Methods

### Instance methods

- `System.Void TrySetHovered(System.Single distance)`
  - If this distance is closer than our previous best, this path will become the hovered path
- `System.Void TrySetHovered(Vector3 position)`
  - If this distance is closer than our previous best, this path will become the hovered path
- `System.Void Sphere(Sandbox.Sphere sphere)`
  - A sphere hitbox
- `System.Void BBox(BBox bounds)`
  - A bounding box hitbox
- `System.Void Circle(Vector3 center, Vector3 forward, System.Single outerRadius, System.Single innerRadius)`
  - A 2d circle hitbox, on a plane
- `System.Void Model(Sandbox.Model model)`
  - A model hitbox
- `System.Void Sprite(Vector3 center, System.Single size, System.Boolean worldspace)`
  - A 2d sprite hitbox
- `System.Void Model(Sandbox.Model model, System.Single maxDistance)`
- `System.IDisposable LineScope()`
  - Start a line scope. Any drawn lines should become a hitbox during this scope.
- `System.Void AddPotentialLine(Vector3 p0, Vector3 p1, System.Single thickness)`
  - If we're in a hitbox linescope we'll distance this test vs the current ray. If
not, we'll return immediately.
This is automatically called when rendering lines
