# Sandbox.HammerMesh

Added automatically by Hammer to GameObjects that have a map mesh tied to them.
When a map is compiled the Model property is populated by the generated model.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `HammerMesh()`

## Properties

- `Sandbox.Model Model`
  - Gets populated at compile time, will be valid when loading from compiled map
- `System.Boolean UseRenderer`
- `System.Boolean UseCollision`
- `Color Tint`
- `Sandbox.ModelRenderer.ShadowRenderType RenderType`
- `System.Boolean Static`
- `System.Nullable<System.Single> Friction`
- `Sandbox.Surface Surface`
- `Vector3 SurfaceVelocity`
  - Set the local velocity of the surface so things can slide along it, like a conveyor belt
- `System.Boolean IsTrigger`
- `System.Action<Sandbox.Collider> OnTriggerEnter`
  - Called when a collider enters this trigger
- `System.Action<Sandbox.Collider> OnTriggerExit`
  - Called when a collider exits this trigger

## Methods

### Instance methods

- `virtual System.Void OnEnabled()`
- `virtual System.Void OnDisabled()`
