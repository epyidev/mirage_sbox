# Sandbox.UI.WorldPanel

An interactive 2D panel rendered in the 3D world.

- **Kind:** class
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.UI.RootPanel`

## Constructors

- `WorldPanel(Sandbox.SceneWorld world)`

## Properties

- `static System.Single ScreenToWorldScale`
- `Transform Transform`
  - Transform of the world panel in 3D space.
- `Sandbox.ITagSet Tags`
  - Tags that are applied to the underlying SceneObject
- `Vector3 Position`
  - Position of the world panel in 3D space.
- `Rotation Rotation`
  - Rotation of the world panel in 3D space.
- `System.Single WorldScale`
  - Scale of the world panel in 3D space.
- `System.Single MaxInteractionDistance`
  - Maximum distance at which a player can interact with this world panel.

## Methods

### Instance methods

- `virtual System.Void UpdateBounds(Sandbox.Rect rect)`
  - Update the bounds for this panel. We purposely do nothing here because
on world panels you can change the bounds by setting `Sandbox.UI.RootPanel.PanelBounds`.
- `virtual System.Void UpdateScale(Sandbox.Rect screenSize)`
  - We override this to prevent the scale automatically being set based on screen
size changing.. because that's obviously not needed here.
- `virtual System.Void Delete(System.Boolean immediate)`
- `virtual System.Void OnDeleted()`
- `virtual System.Boolean RayToLocalPosition(Ray ray, Vector2 position, System.Single distance)`
