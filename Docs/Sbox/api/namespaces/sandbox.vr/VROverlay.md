# Sandbox.VR.VROverlay

VR overlays draw over the top of the 3D scene, they will not be affected by lighting,
            post processing effects or anything else in the world.<br />
            This makes them ideal for HUDs or menus, or anything else that should be local to the
            HMD or tracked devices.



If you need something in the world, consider using WorldPanel
            and WorldInput instead.

- **Kind:** class
- **Namespace:** `Sandbox.VR`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `VROverlay()`

## Properties

- `System.Boolean Visible`
  - Shows or hides the VR overlay.
- `Transform Transform`
  - Sets the transform to absolute tracking origin
- `System.UInt32 SortOrder`
  - Sets the rendering sort order for the overlay.
- `System.Single Width`
  - The width of the overlay quad.
By default overlays are rendered on a quad that is 1 meter across.
- `System.Single Curvature`
  - Use to draw overlay as a curved surface. Curvature is a percentage from (0..1] where 1 is a fully closed cylinder.
For a specific radius, curvature can be computed as: overlay.width / (2 PI r).
- `Color Color`
  - Sets the color tint of the overlay quad. Use 0.0 to 1.0 per channel.
Sets the alpha of the overlay quad. Use 1.0 for 100 percent opacity to 0.0 for 0 percent opacity.
- `Sandbox.Texture Texture`
  - Texture that is rendered on the overlay quad.
`Sandbox.TextureBuilder`
- `Vector2 MouseScale`
  - Sets the mouse scaling factor that is used for mouse events.

## Methods

### Instance methods

- `virtual System.Void Finalize()`
- `virtual System.Void Dispose()`
  - Destroys this overlay.
- `virtual System.Void Dispose(System.Boolean disposing)`
  - Destroys this overlay.
- `System.Void SetTransformAbsolute(Transform transform)`
  - Sets the transform to absolute tracking origin
