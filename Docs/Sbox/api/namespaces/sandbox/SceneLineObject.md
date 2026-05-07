# Sandbox.SceneLineObject

A scene object which is used to draw lines

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.SceneCustomObject`

## Constructors

- `SceneLineObject(Sandbox.SceneWorld sceneWorld)`

## Properties

- `Sandbox.Texture LineTexture`
- `Sandbox.SceneLineObject.CapStyle StartCap`
- `Sandbox.SceneLineObject.CapStyle EndCap`
- `Sandbox.SceneLineObject.FaceMode Face`
- `System.Boolean Wireframe`
- `System.Boolean Lighting`
- `System.Boolean Clamped`
- `Sandbox.Rendering.SamplerState SamplerState`
- `System.Int32 Smoothness`
- `System.Boolean Opaque`
- `System.Int32 TessellationLevel`
  - Number of tessellation subdivisions across the width of each line segment.
1 = no tessellation (just left and right), 2 = one subdivision in the middle, etc.
Higher values create smoother curves and more detailed geometry but use more vertices.

## Fields

- `Sandbox.Material Material`

## Methods

### Instance methods

- `System.Void StartLine()`
- `System.Void AddLinePoint(Vector3 pos, Color color, System.Single width)`
- `System.Void AddLinePoint(Vector3 pos, Color color, System.Single width, System.Single textureCoord)`
- `System.Void AddLinePoint(Vector3 pos, Vector3 normal, Color color, System.Single width, System.Single textureCoord)`
- `System.Void EndLine()`
- `System.Void Clear()`
- `virtual System.Void RenderSceneObject()`
