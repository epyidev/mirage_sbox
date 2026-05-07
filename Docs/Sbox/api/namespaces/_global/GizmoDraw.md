# Sandbox.Gizmo.GizmoDraw

Contains functions to add objects to the Gizmo Scene. This
is an instantiable class so it's possible to add extensions.

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Gizmo`

## Properties

- `Color Color`
  - The color to render the next object
- `System.Boolean IgnoreDepth`
  - Ignore depth when drawing, draw on top of everything
- `System.Single LineThickness`
  - The thickness of line drawings
- `System.Boolean CullBackfaces`
  - Don't draw backfaces when drawing solids

## Methods

### Instance methods

- `Sandbox.SceneModel Model(System.String modelName, Transform localTransform)`
  - Draw a model
- `Sandbox.SceneModel Model(System.String modelName)`
  - Draw a model
- `Sandbox.SceneModel Model(Sandbox.Model model, Transform localTransform)`
  - Draw a model
- `Sandbox.SceneModel Model(Sandbox.Model modelName)`
  - Draw a model
- `System.Void Particles(System.String modelName, Transform localTransform, System.Nullable<System.Single> updateSpeed)`
- `System.Void Particles(System.String modelName, System.Nullable<System.Single> updateSpeed)`
- `System.Void Text(System.String text, Transform tx, System.String font, System.Single size, Sandbox.TextFlag flags)`
  - Draw text
- `System.Void WorldText(System.String text, Transform tx, System.String font, System.Single size, Sandbox.TextFlag flags)`
- `System.Void ScreenText(System.String text, Vector2 pos, System.String font, System.Single size, Sandbox.TextFlag flags)`
  - Draw text
- `System.Void ScreenText(Sandbox.TextRendering.Scope text, Vector2 pos, Sandbox.TextFlag flags)`
  - Draw text with a text rendering scope for more text rendering customization.
- `System.Void ScreenText(System.String text, Vector3 worldPos, Vector2 offset, System.String font, System.Single size, Sandbox.TextFlag flags)`
  - Draw text on screen at a 3d position
- `System.Void ScreenText(Sandbox.TextRendering.Scope text, Vector3 worldPos, Vector2 offset, Sandbox.TextFlag flags)`
  - Draw text on screen at a 3d position with a text rendering scope for more text rendering customization.
- `System.Void ScreenText(Sandbox.TextRendering.Scope text, Sandbox.Rect rect, System.Single angle, Sandbox.TextFlag flags)`
  - Draw text at an angle
- `System.Void ScreenRect(Sandbox.Rect rect, Color color, Vector4 borderRadius, Color borderColor, Vector4 borderSize, Sandbox.BlendMode blendMode)`
  - Draw a rect, on the screen
- `System.Void Plane(Vector3 position, Vector3 normal)`
  - Draw a plane
- `System.Void Arrow(Vector3 from, Vector3 to, System.Single arrowLength, System.Single arrowWidth)`
  - Draw a line with an arrow on the end
- `System.Void Grid(Sandbox.Gizmo.GridAxis axis, System.Single spacing, System.Single opacity, System.Single minorLineWidth, System.Single majorLineWidth)`
  - Draws a grid
- `System.Void Grid(Sandbox.Gizmo.GridAxis axis, Vector2 spacing, System.Single opacity, System.Single minorLineWidth, System.Single majorLineWidth)`
  - Draws a grid
- `System.Void Grid(Vector3 center, Sandbox.Gizmo.GridAxis axis, Vector2 spacing, System.Single opacity, System.Single minorLineWidth, System.Single majorLineWidth)`
  - Draws a grid centered at a position
- `System.Void Line(Vector3 a, Vector3 b)`
  - Draw a line from a to b
- `System.Void Line(Line line)`
  - Draw a line from a to b
- `System.Void Lines(System.Collections.Generic.IEnumerable<Line> lines)`
- `System.Void LineBBox(BBox box)`
  - Draw a bounding box
- `System.Void LineFrustum(Sandbox.Frustum frustum)`
  - Draws a frustum.
- `System.Void LineSphere(Vector3 point, System.Single radius, System.Int32 rings)`
  - Draw a sphere made out of lines
- `System.Void LineSphere(Sandbox.Sphere sphere, System.Int32 rings)`
  - Draw a sphere made out of lines
- `System.Void LineCircle(Vector3 center, System.Single radius, System.Single startAngle, System.Single totalDegrees, System.Int32 sections)`
  - Draw a sphere made out of lines
- `System.Void LineCircle(Vector3 center, Vector3 forward, System.Single radius, System.Single startAngle, System.Single totalDegrees, System.Int32 sections)`
- `System.Void LineCircle(Vector3 center, Vector3 forward, Vector3 up, System.Single radius, System.Single startAngle, System.Single totalDegrees, System.Int32 sections)`
- `System.Void LineCylinder(Vector3 vPointA, Vector3 vPointB, System.Single flRadiusA, System.Single flRadiusB, System.Int32 nNumSegments)`
  - A cylinder
- `System.Void LineCapsule(Capsule capsule, System.Int32 rings)`
- `System.Void LineTriangle(Sandbox.Triangle triangle)`
  - A triangle
- `System.Void LineTriangles(System.Collections.Generic.IEnumerable<Sandbox.Triangle> triangles)`
- `System.Void SolidCone(Vector3 base, Vector3 extent, System.Single flRadius, System.Nullable<System.Int32> segments)`
- `System.Void SolidBox(BBox box)`
  - Draw a solid box shape
- `System.Void SolidTriangle(Sandbox.Triangle triangle)`
  - Draw a solid triangle shape
- `System.Void SolidTriangle(Vector3 a, Vector3 b, Vector3 c)`
  - Draw a solid triangle shape
- `System.Void SolidTriangles(System.Collections.Generic.IEnumerable<Sandbox.Triangle> triangles)`
- `System.Void SolidCircle(Vector3 center, System.Single radius, System.Single startAngle, System.Single totalDegrees, System.Int32 sections)`
  - Draw a filled circle
- `System.Void SolidRing(Vector3 center, System.Single innerRadius, System.Single outerRadius, System.Single startAngle, System.Single totalDegrees, System.Int32 sections)`
  - Draw a filled ring
- `System.Void SolidSphere(Vector3 center, System.Single radius, System.Int32 hSegments, System.Int32 vSegments)`
  - Draw a solid sphere shape
- `System.Void SolidCylinder(Vector3 start, Vector3 end, System.Single radius, System.Int32 hSegments)`
  - Draw a solid cylinder shape
- `System.Void SolidCapsule(Vector3 start, Vector3 end, System.Single radius, System.Int32 hSegments, System.Int32 vSegments)`
  - Draw a solid capsule shape
- `System.Void ScreenBiasedHalfCircle(Vector3 center, System.Single radius)`
  - Draws a half circle that tries its best to point towards the camera. This is used by
the rotation widgets that bias towards the camera.
- `System.Void Sprite(Vector3 center, System.Single size, System.String texture)`
  - Draw a sprite.
- `System.Void Sprite(Vector3 center, System.Single size, Sandbox.Texture texture)`
  - Draw a sprite.
- `System.Void Sprite(Vector3 center, Vector2 size, Sandbox.Texture texture, System.Boolean worldspace)`
  - Draw a sprite.
- `System.Void Sprite(Vector3 center, Vector2 size, Sandbox.Texture texture, System.Boolean worldspace, System.Single angle)`
  - Draw a sprite.
