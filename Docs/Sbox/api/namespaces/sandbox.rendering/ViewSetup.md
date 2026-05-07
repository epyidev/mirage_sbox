# Sandbox.Rendering.ViewSetup

When manually rendering a camera this will let you override specific
elements of that render. This means you can use most of the camera's
properties, but override some without disturbing the camera itself.

- **Kind:** struct
- **Namespace:** `Sandbox.Rendering`
- **Assembly:** `Sandbox.Engine`

## Fields

- `System.Nullable<Transform> Transform`
  - Overrides the camera's position and rotation
- `System.Nullable<System.Single> FieldOfView`
  - Overrides the camera's field of view
- `System.Nullable<System.Single> ZNear`
  - Overrides the camera's znear
- `System.Nullable<System.Single> ZFar`
  - Overrides the camera's zfar
- `System.Nullable<Color> ClearColor`
  - Overrides the camera's clear color
- `System.Nullable<Matrix> ProjectionMatrix`
  - Overrides the camera's projection matrix
- `System.Nullable<Sandbox.Rendering.GradientFogSetup> GradientFog`
  - Allows overriding gradient fog for this view
- `System.Nullable<Color> AmbientLightTint`
  - If set then the regular scene's ambient light will be multiplied by this
- `System.Nullable<Color> AmbientLightAdd`
  - If set then this will be added to the ambient light color
- `System.Nullable<Vector4> ClipSpaceBounds`
  - Clipspace is usually used for rendering posters, or center-offsetting the view. You're basically zooming
into a subrect of the clipspace. So imagine you draw a smaller rect inside the first rect of the frustum.. 
that's what you're gonna render - that rect.
- `System.Nullable<System.Boolean> FlipX`
  - When rendering to a texture, this allows you to flip the view horizontally.
- `System.Nullable<System.Boolean> FlipY`
  - When rendering to a texture, this allows you to flip the view vertically.
- `System.Nullable<System.Boolean> EnablePostprocessing`
  - Whether post processing should be enabled for this view. If null it will use the camera's setting.
- `System.Int32 ViewHash`
  - If you're rendering a subview this will allow the renderer to find the same view again next frame
