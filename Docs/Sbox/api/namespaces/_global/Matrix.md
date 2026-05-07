# Matrix

Represents a 4x4 matrix.

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`

## Constructors

- `Matrix(System.Single m11, System.Single m12, System.Single m13, System.Single m14, System.Single m21, System.Single m22, System.Single m23, System.Single m24, System.Single m31, System.Single m32, System.Single m33, System.Single m34, System.Single m41, System.Single m42, System.Single m43, System.Single m44)`

## Properties

- `static Matrix Identity`
  - Returns the multiplicative identity matrix.
- `Matrix Inverted`
  - Returns inverse of this matrix.
- `System.Single M11`
- `System.Single M12`
- `System.Single M13`
- `System.Single M14`
- `System.Single M21`
- `System.Single M22`
- `System.Single M23`
- `System.Single M24`
- `System.Single M31`
- `System.Single M32`
- `System.Single M33`
- `System.Single M34`
- `System.Single M41`
- `System.Single M42`
- `System.Single M43`
- `System.Single M44`

## Methods

### Static methods

- `static Matrix CreateWorld(Vector3 position, Vector3 forward, Vector3 up)`
- `static Matrix CreateRotation(Rotation rot)`
- `static Matrix CreateRotation(Vector3 angles)`
- `static Matrix CreateRotationX(System.Single degrees)`
- `static Matrix CreateRotationX(System.Single degrees, Vector3 center)`
- `static Matrix CreateRotationY(System.Single degrees)`
- `static Matrix CreateRotationY(System.Single degrees, Vector3 center)`
- `static Matrix CreateRotationZ(System.Single degrees)`
- `static Matrix CreateRotationZ(System.Single degrees, Vector3 center)`
- `static Matrix CreateTranslation(Vector3 vec)`
- `static Matrix CreateScale(Vector3 scales)`
- `static Matrix CreateScale(Vector3 scales, Vector3 centerPoint)`
- `static Matrix CreateSkew(Vector2 skew)`
- `static Matrix CreateSkewX(System.Single degrees)`
- `static Matrix CreateSkewY(System.Single degrees)`
- `static Matrix CreateMatrix3D(System.Single[] matrix)`
- `static Matrix Lerp(Matrix ma, Matrix mb, System.Single frac)`
  - Performs linear interpolation from one matrix to another.
- `static Matrix Slerp(Matrix ma, Matrix mb, System.Single frac)`
  - Performs spherical interpolation from one matrix to another.
- `static Matrix CreateProjection(System.Single zNear, System.Single zFar, System.Single fovX, System.Single aspectRatio, System.Nullable<Vector4> clipSpace)`
- `static Matrix CreateObliqueProjection(Transform cameraTransform, Sandbox.Plane clipPlane, Matrix projectionMatrix)`
  - Create a projection matrix. The matrix will be in the correct format for the engine, and will also be reverse z.

### Instance methods

- `Matrix Transpose()`
  - Returns transposed version of this matrix, meaning columns in this matrix become rows in the returned matrix and rows in this matrix become columns in the returned one.
- `Vector4 Transform(Vector4 v)`
  - Transforms a vector by a 4x4 matrix
- `Vector3 Transform(Vector3 v)`
  - Transforms a vector by a 4x4 matrix
- `Vector2 Transform(Vector2 v)`
  - Transforms a vector by a 4x4 matrix
- `Vector3 TransformNormal(Vector3 v)`
  - Transforms a normal vector by a specified 4x4 matrix
