# Sandbox.CameraComponent

Every scene should have at least one Camera.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Component`

## Constructors

- `CameraComponent()`

## Properties

- `Sandbox.CameraComponent.AutoExposureSetup AutoExposure`
  - Enables and configures auto exposure on the camera. This is usually controlled
by the Tonemapping component. But if you're not using that, it can be controlled manually here.
- `Sandbox.ClearFlags ClearFlags`
  - The clear flags for this camera.
- `Color BackgroundColor`
  - The background color of this camera's view if there's no 2D Sky in the scene.
- `System.Boolean IsMainCamera`
  - Returns true if this is the main game camera.
- `Sandbox.CameraComponent.Axis FovAxis`
  - The axis to use for the field of view.
- `System.Single FieldOfView`
  - The field of view of this camera.
- `System.Single ZNear`
  - The camera's near clip plane distance. This is the closest distance this camera will be able to render.
A good value for this is about 5. Below 5 and particularly below 1 you're going to start to see
a lot of artifacts like z-fighting.
- `System.Single ZFar`
  - The camera's far clip plane distance. This is the furthest distance this camera will be able to render.
This value totally depends on the game you're making. Shorter the better, sensible ranges would be
between about 1000 and 30000, but if you want it to be further out you can balance that out by making
ZNear larger.
- `System.Int32 Priority`
  - The priority of this camera. Dictates which camera gets rendered on top of another. Higher means it'll be rendered on top.
- `System.Boolean Orthographic`
  - Whether or not to use orthographic projection instead of perspective.
- `System.Single OrthographicHeight`
  - The orthographic size for this camera while `Sandbox.CameraComponent.Orthographic` is set to true.
- `Sandbox.StereoTargetEye TargetEye`
  - The HMD eye that this camera is targeting.
Use `Sandbox.StereoTargetEye.None` for the user's monitor (i.e. the companion window).
- `Sandbox.TagSet RenderTags`
  - A list of tags that will be checked to include specific game objects when rendering this camera.
If none are set, it will include everything.
- `Sandbox.TagSet RenderExcludeTags`
  - A list of tags that will be checked to exclude specific game objects when rendering this camera.
- `Vector4 Viewport`
  - The size of the camera represented on the screen. Normalized between 0 and 1.
- `Sandbox.Texture RenderTarget`
  - The texture to draw this camera to.
Requires `Sandbox.Texture.CreateRenderTarget`
- `Sandbox.SceneCameraDebugMode DebugMode`
  - Render this camera using a different render mode
- `System.Boolean WireframeMode`
  - Render this camera using a wireframe view.
- `Sandbox.Rect ScreenRect`
  - The size of the viewport, in screen coordinates
- `System.Nullable<Matrix> CustomProjectionMatrix`
  - Allows specifying a custom projection matrix for this camera
- `System.Nullable<Vector2> CustomSize`
  - Allows specifying a custom aspect ratio for this camera.
By default (or when null) the camera size is screen size or render target size.
- `Matrix ProjectionMatrix`
  - Get frustum projection matrix.
- `Sandbox.Rendering.HudPainter Hud`
  - Allows drawing on the camera. This is drawn before the post processing.
- `Sandbox.Rendering.HudPainter Overlay`
  - Used to draw to the screen. This is drawn on top of everything, so is good for debug overlays etc.
- `System.Boolean EnablePostProcessing`
  - Enable or disable post processing for this camera.
- `Sandbox.GameObject PostProcessAnchor`
  - If set then we'll trigger post process volumes from this position, instead of the camera's position.

## Fields

- `Sandbox.RenderTextureAsset RenderTexture`
  - If specified, this camera will render to this RenderTexture instead of the screen.
This can then be used in other stuff like materials.

## Methods

### Instance methods

- `System.Void AddCommandList(Sandbox.Rendering.CommandList buffer, Sandbox.Rendering.Stage stage, System.Int32 order)`
  - Add a command list to the render
- `System.Void RemoveCommandList(Sandbox.Rendering.CommandList buffer, Sandbox.Rendering.Stage stage)`
  - Remove an entry
- `System.Void RemoveCommandList(Sandbox.Rendering.CommandList buffer)`
  - Remove an entry
- `System.Void ClearCommandLists(Sandbox.Rendering.Stage stage)`
  - Remove all entries in this stage
- `System.Void ClearCommandLists()`
  - Remove all entries in this stage
- `virtual System.Void Reset()`
- `System.Void UpdateSceneCamera(Sandbox.SceneCamera camera, System.Boolean includeTags)`
  - Update a SceneCamera with the settings from this component
- `System.IDisposable AddHookAfterOpaque(System.String debugName, System.Int32 order, System.Action<Sandbox.SceneCamera> renderEffect)`
- `System.IDisposable AddHookAfterTransparent(System.String debugName, System.Int32 order, System.Action<Sandbox.SceneCamera> renderEffect)`
- `System.IDisposable AddHookBeforeOverlay(System.String debugName, System.Int32 order, System.Action<Sandbox.SceneCamera> renderEffect)`
- `System.IDisposable AddHookAfterUI(System.String debugName, System.Int32 order, System.Action<Sandbox.SceneCamera> renderEffect)`
- `Vector2 PointToScreenNormal(Vector3 worldPosition)`
- `Vector2 PointToScreenPixels(Vector3 worldPosition)`
- `Sandbox.Rect BBoxToScreenPixels(BBox bounds, System.Boolean isBehind)`
  - Given a BBox in world space, will return the screen space rect that totally contains the box.
- `Vector2 PointToScreenPixels(Vector3 worldPosition, System.Boolean isBehind)`
- `Vector2 PointToScreenNormal(Vector3 worldPosition, System.Boolean isBehind)`
- `Ray ScreenPixelToRay(Vector2 pixelPosition)`
- `Ray ScreenNormalToRay(Vector3 normalPosition)`
- `Vector3 ScreenToWorld(Vector2 screen)`
  - Convert from screen coords to world coords on the near frustum plane.
- `Sandbox.Frustum GetFrustum()`
  - Returns the view frustum of the current screen rect.
- `Sandbox.Frustum GetFrustum(Sandbox.Rect screenRect)`
  - Given a pixel rect return a frustum on the current camera.
- `Sandbox.Frustum GetFrustum(Sandbox.Rect screenRect, Vector3 screenSize)`
  - Given a pixel rect return a frustum on the current camera. Pass in 1 to ScreenSize to use normalized screen coords.
- `System.Boolean RenderToTexture(Sandbox.Texture target, Sandbox.Rendering.ViewSetup config)`
  - Render scene to a texture from this camera's point of view
- `Matrix CalculateObliqueMatrix(Sandbox.Plane clipPlane)`
  - Calculates a projection matrix with an oblique clip-plane defined in world space.
- `System.Void RenderToBitmap(Sandbox.Bitmap targetBitmap)`
  - Render this camera to the target bitmap.
