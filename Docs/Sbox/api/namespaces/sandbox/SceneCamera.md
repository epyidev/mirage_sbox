# Sandbox.SceneCamera

Represents a camera and holds render hooks. This camera can be used to draw tool windows and scene panels.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `SceneCamera(System.String name)`

## Properties

- `Sandbox.SceneCamera.BloomAccessor Bloom`
  - Access tonemapping properties of camera
- `Sandbox.RenderAttributes Attributes`
- `System.String Name`
  - The name of this camera.. for debugging purposes.
- `Sandbox.ITagSet ExcludeTags`
  - Scene objects with any of these tags won't be rendered by this camera.
- `Sandbox.ITagSet RenderTags`
  - Only scene objects with one of these tags will be rendered by this camera.
- `System.Action OnRenderPostProcess`
  - Called when rendering the post process pass
- `System.Action OnRenderOpaque`
  - Called when rendering the transparent pass
- `System.Action OnRenderTransparent`
  - Called when rendering the transparent pass
- `System.Action OnRenderOverlay`
- `System.Action OnRenderUI`
- `Vector2 Size`
  - The size of the screen. Allows us to work out aspect ratio.
For now will get updated automatically on render.
- `Sandbox.VolumetricFogParameters VolumetricFog`
  - Control volumetric fog parameters, expect this to take 1-2ms of your GPU frame time.
- `Sandbox.CubemapFogController CubemapFog`
  - Control fog based on an image.
- `Sandbox.SceneWorld World`
  - The world we're going to render.
- `System.Collections.Generic.HashSet<Sandbox.SceneWorld> Worlds`
  - Your camera can render multiple worlds.
- `Vector3 Position`
  - The position of the scene's camera.
- `Rotation Rotation`
  - The rotation of the scene's camera.
- `Angles Angles`
  - The rotation of the scene's camera.
- `System.Single FieldOfView`
  - The horizontal field of view of the Camera in degrees.
- `System.Single ZFar`
  - The camera's zFar distance. This is the furthest distance this camera will be able to render.
This value totally depends on the game you're making. Shorter the better, sensible ranges would be
between about 1000 and 30000, but if you want it to be further out you can balance that out by making
znear larger.
- `System.Single ZNear`
  - The camera's zNear distance. This is the closest distance this camera will be able to render.
A good value for this is about 5. Below 5 and particularly below 1 you're going to start to see
a lot of artifacts like z-fighting.
- `System.Boolean Ortho`
  - Whether to use orthographic projection.
- `System.Single OrthoHeight`
  - Height of the ortho when `Sandbox.SceneCamera.Ortho` is enabled.
- `Sandbox.SceneCameraDebugMode DebugMode`
  - Render this camera using a different render mode
- `System.Boolean WireframeMode`
  - Render this camera using a wireframe view.
- `Sandbox.ClearFlags ClearFlags`
  - What kind of clearing should we do before we begin?
- `Sandbox.Rect Rect`
  - The rect of the screen to render to. This is normalized, between 0 and 1.
- `Color BackgroundColor`
  - Color the scene camera clears the render target to.
- `Color AmbientLightColor`
  - The color of the ambient light. Set it to black for no ambient light, alpha is used for lerping between IBL and constant color.
- `System.Boolean AntiAliasing`
  - Enable or disable anti-aliasing for this render.
- `System.Boolean EnablePostProcessing`
  - Toggle all post processing effects for this camera. The default is on.
- `Sandbox.StereoTargetEye TargetEye`
  - The HMD eye that this camera is targeting.
Use `Sandbox.StereoTargetEye.None` for the user's monitor (i.e. the companion window).
- `System.Boolean WantsStereoSubmit`
  - Set this to false if you don't want the stereo renderer to submit this camera's texture to the compositor.
This option isn't considered if `Sandbox.SceneCamera.TargetEye` is `Sandbox.StereoTargetEye.None`.
- `System.Boolean EnableDirectLighting`
  - Enable or disable direct lighting
- `System.Boolean EnableIndirectLighting`
  - Enable or disable indirect lighting
- `System.Nullable<Matrix> CustomProjectionMatrix`
  - Allows specifying a custom projection matrix for this camera

## Methods

### Instance methods

- `virtual System.Void Dispose()`
- `Sandbox.Frustum GetFrustum(Sandbox.Rect pixelRect)`
  - Given a pixel rect return a frustum on the current camera.
- `Sandbox.Frustum GetFrustum(Sandbox.Rect pixelRect, Vector3 screenSize)`
  - Given a pixel rect return a frustum on the current camera. Pass in 1 to ScreenSize to use normalized screen coords.
- `Ray GetRay(Vector3 cursorPosition)`
  - Given a cursor position get a scene aiming ray.
- `Ray GetRay(Vector2 cursorPosition, Vector3 screenSize)`
  - Given a cursor position get a scene aiming ray.
- `Vector2 ToScreen(Vector3 world)`
  - Convert from world coords to screen coords. The results for x and y will be from 0 to `Sandbox.SceneCamera.Size`.
- `System.Boolean ToScreen(Vector3 world, Vector2 screen)`
  - Convert from world coords to screen coords. The results for x and y will be from 0 to `Sandbox.SceneCamera.Size`.
- `Vector2 ToScreenNormal(Vector3 world)`
  - Convert from world coords to normal screen corrds. The results will be between 0 and 1
- `Vector3 ToWorld(Vector2 screen)`
  - Convert from screen coords to world coords on the near frustum plane.
