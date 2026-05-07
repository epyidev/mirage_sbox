# Vector3Int

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`

## Constructors

- `Vector3Int(System.Int32 x, System.Int32 y, System.Int32 z)`
  - Initializes an integer vector with given components.
  - `x`: The X component.
  - `y`: The Y component.
  - `z`: The Z component.
- `Vector3Int(System.Int32 all)`
  - Initializes an integer vector with all components set to the same value.
  - `all`: The value of the X, Y, and Z components.
- `Vector3Int(Vector3Int vector3Int)`
  - Initializes an integer vector with given components from another integer vector

## Properties

- `Vector3 Normal`
  - Returns a unit version of this vector. Keep in mind this returns a Vector3 and not a Vector3Int.
- `Angles EulerAngles`
  - The Euler angles of this direction vector.
- `Vector3 Inverse`
  - Returns the inverse of this vector, which is useful for scaling vectors. Keep in mind this returns a Vector3 and not a Vector3Int.
- `System.Int32 Item`
- `System.Single Length`
  - Length (or magnitude) of the integer vector (Distance from 0,0,0)
- `System.Int32 LengthSquared`
  - Squared length of the integer vector. This is faster than <see cref="P:Vector3Int.Length">Length</see>, and can be used for things like comparing distances, as long as only squared values are used.
- `System.Boolean IsZeroLength`
  - Whether the length of this vector is zero or not.

## Fields

- `System.Int32 x`
  - The X component of this integer vector.
- `System.Int32 y`
  - The Y component of this integer vector.
- `System.Int32 z`
  - The Z component of this integer vector.
- `static Vector3Int One`
  - An integer vector with all components set to 1.
- `static Vector3Int Zero`
  - An integer vector with all components set to 0.
- `static Vector3Int Forward`
  - An integer vector with X set to 1. This represents the forward direction.
- `static Vector3Int Backward`
  - An integer vector with X set to -1. This represents the backward direction.
- `static Vector3Int Up`
  - An integer vector with Z set to 1. This represents the up direction.
- `static Vector3Int Down`
  - An integer vector with Z set to -1. This represents the down direction.
- `static Vector3Int Right`
  - An integer vector with Y set to 1. This represents the right direction.
- `static Vector3Int Left`
  - An integer vector with Y set to -1. This represents the left direction.
- `static Vector3Int OneX`
  - An integer vector with X set to 1.
- `static Vector3Int OneY`
  - An integer vector with Y set to 1.
- `static Vector3Int OneZ`
  - An integer vector with Z set to 1.

## Methods

### Static methods

- `static Vector3Int Cross(Vector3Int a, Vector3Int b)`
  - Returns the cross product of this and the given integer vector.
If this and the given vectors are linearly independent, the resulting vector is perpendicular to them both, also known as a normal of a plane.
- `static System.Single Dot(Vector3Int a, Vector3Int b)`
  - Returns the scalar/dot product of the 2 given integer vectors.
- `static System.Single Dot(Vector3Int a, Vector3 b)`
  - Returns the scalar/dot product of the 2 given vectors.
- `static System.Single GetAngle(Vector3Int v1, Vector3Int v2)`
- `static Vector3Int Min(Vector3Int a, Vector3Int b)`
  - Returns an integer vector that has the minimum values on each axis between 2 given vectors.
- `static Vector3Int Max(Vector3Int a, Vector3Int b)`
  - Returns an integer vector that has the maximum values on each axis between 2 given vectors.
- `static Vector3Int Parse(System.String str)`
  - Given a string, try to convert this into a Vector3Int. Example formatting is "x,y,z", "[x,y,z]", "x y z", etc.
- `static Vector3Int Parse(System.String str, System.IFormatProvider provider)`
- `static System.Boolean TryParse(System.String str, System.IFormatProvider info, Vector3Int result)`

### Instance methods

- `System.Boolean IsNearlyZero(System.Int32 tolerance)`
  - Returns true if value on every axis is less than or equal to tolerance.
- `System.Void Write(System.IO.BinaryWriter writer)`
- `Vector3Int Read(System.IO.BinaryReader reader)`
- `Vector3Int ComponentMin(Vector3Int other)`
  - Returns an integer vector that has the minimum values on each axis between this vector and a given vector.
- `Vector3Int ComponentMax(Vector3Int other)`
  - Returns an integer vector that has the maximum values on each axis between this vector and a given vector.
- `System.Single Dot(Vector3Int b)`
  - Returns the scalar/dot product of this and the given vector.
- `System.Single Dot(Vector3 b)`
  - Returns the scalar/dot product of this and the given vector.
- `System.Single Distance(Vector3Int other)`
  - Returns distance between this vector and another.
- `System.Single Distance(Vector3 other)`
  - Returns distance between this vector and another.
- `Vector3Int SnapToGrid(System.Int32 gridSize, System.Boolean sx, System.Boolean sy, System.Boolean sz)`
  - Snap to grid along any of the 3 axes.
- `Vector3Int Abs()`
  - Returns a new integer vector with all values positive. -5 becomes 5, ect.
- `Vector3Int WithX(System.Int32 x)`
  - Returns this integer vector with given X component.
- `Vector3Int WithY(System.Int32 y)`
  - Returns this integer vector with given Y component.
- `Vector3Int WithZ(System.Int32 z)`
  - Returns this integer vector with given Z component.
