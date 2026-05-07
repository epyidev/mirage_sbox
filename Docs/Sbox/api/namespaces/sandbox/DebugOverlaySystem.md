# Sandbox.DebugOverlaySystem

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.GameObjectSystem<T>`

## Constructors

- `DebugOverlaySystem(Sandbox.Scene scene)`

## Methods

### Instance methods

- `System.Void Capsule(Capsule capsule, Color color, System.Single duration, Transform transform, System.Boolean overlay, System.Int32 segments)`
  - Draw a wireframe capsule, simple cylinder with 2 hemispheres.
- `System.Void Cylinder(Capsule capsule, Color color, System.Single duration, Transform transform, System.Boolean overlay, System.Int32 segments)`
  - Draw a wireframe cylinder, like a capsule without the hemispheres, showing all sides.
- `System.Void Box(Vector3 position, Vector3 size, Color color, System.Single duration, Transform transform, System.Boolean overlay)`
  - Draw a box
- `System.Void Box(BBox box, Color color, System.Single duration, Transform transform, System.Boolean overlay)`
  - Draw a box
- `System.Void GameObject(Sandbox.GameObject go, Color color, System.Single duration, Transform transform, System.Boolean overlay, System.Boolean castShadows, Sandbox.Material materialOveride)`
  - Draw a GameObject in the world
- `System.Void Normal(Vector3 position, Vector3 direction, Color color, System.Single duration, Transform transform, System.Boolean overlay)`
  - Draw a line
- `System.Void Line(Line line, Color color, System.Single duration, Transform transform, System.Boolean overlay)`
  - Draw a line
- `System.Void Line(Vector3 from, Vector3 to, Color color, System.Single duration, Transform transform, System.Boolean overlay)`
  - Draw a line
- `System.Void Line(System.Collections.Generic.IEnumerable<Vector3> points, Color color, System.Single duration, Transform transform, System.Boolean overlay)`
- `System.Void Model(Sandbox.Model model, Color color, System.Single duration, Transform transform, System.Boolean overlay, System.Boolean castShadows, Sandbox.Material materialOveride, Transform[] localBoneTransforms)`
  - Draw model in the world
- `System.Void Sphere(Sandbox.Sphere sphere, Color color, System.Single duration, Transform transform, System.Boolean overlay)`
  - Draw a sphere
- `System.Void Text(Vector3 position, System.String text, System.Single size, Sandbox.TextFlag flags, Color color, System.Single duration, System.Boolean overlay)`
  - Draw text in the world
- `System.Void Text(Vector3 position, Sandbox.TextRendering.Scope scope, Sandbox.TextFlag flags, System.Single duration, System.Boolean overlay)`
  - Draw text in the world
- `System.Void Texture(Vector2 pixelPosition, Sandbox.Texture texture, Vector2 size, System.Single duration)`
- `System.Void Frustum(Sandbox.Frustum frustum, Color color, System.Single duration, Transform transform, System.Boolean overlay)`
  - Draw a frustum
- `System.Void ScreenText(Vector2 pixelPosition, System.String text, System.Single size, Sandbox.TextFlag flags, Color color, System.Single duration)`
  - Draw text on the screen
- `System.Void ScreenText(Vector2 pixelPosition, Sandbox.TextRendering.Scope textBlock, Sandbox.TextFlag flags, System.Single duration)`
  - Draw text on the screen
- `System.Void Texture(Sandbox.Texture texture, Vector2 position, System.Nullable<Color> color, System.Single duration)`
- `System.Void Texture(Sandbox.Texture texture, Sandbox.Rect screenRect, System.Nullable<Color> color, System.Single duration)`
- `System.Void ScreenTexture(Vector3 worldPos, Sandbox.Texture texture, Vector2 size, System.Single duration)`
- `System.Void Trace(Sandbox.SceneTraceResult trace, System.Single duration, System.Boolean overlay)`
  - Draws the result of a physics trace, showing the start and end points, the hit location and normal (if any),
and the traced shape (ray, sphere, box, capsule, cylinder) at both the start and end positions.
