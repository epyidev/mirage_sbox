# Vector2Int

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`

## Constructors

- `Vector2Int(System.Int32 x, System.Int32 y)`
  - Initializes an integer vector with given components.
  - `x`: The X component.
  - `y`: The Y component.
- `Vector2Int(System.Int32 all)`
  - Initializes an integer vector with all components set to the same value.
  - `all`: The value of the X and Y components.
- `Vector2Int(Vector2Int vector2Int)`
  - Initializes an integer vector with given components from another integer vector.
- `Vector2Int(Vector3Int vector3Int)`
  - Initializes an integer vector with given components from another integer vector, discarding the Z component.

## Properties

- `Vector2 Normal`
  - Returns a unit version of this vector. Keep in mind this returns a Vector2 and not a Vector2Int.
- `System.Single Degrees`
  - Return the angle of this vector in degrees, always between 0 and 360.
- `System.Int32 Item`
- `System.Single Length`
  - Length (or magnitude) of the integer vector (Distance from 0,0)
- `System.Int32 LengthSquared`
  - Squared length of the integer vector. This is faster than <see cref="P:Vector2Int.Length">Length</see>, and can be used for things like comparing distances, as long as only squared values are used."/&gt;
- `Vector2Int Perpendicular`
  - Returns an integer vector that runs perpendicular to this one.
- `System.Boolean IsZeroLength`
  - Whether the length of this vector is zero or not.

## Fields

- `System.Int32 x`
  - The X component of this integer vector.
- `System.Int32 y`
  - The Y component of this integer vector.
- `static Vector2Int One`
  - An integer vector with all components set to 1.
- `static Vector2Int Zero`
  - An integer vector with all components set to 0.
- `static Vector2Int Right`
  - An integer vector with X set to 1. This represents the right direction.
- `static Vector2Int Left`
  - An integer vector with X set to -1. This represents the left direction.
- `static Vector2Int Up`
  - An integer vector with Y set to 1. This represents the up direction.
- `static Vector2Int Down`
  - An integer vector with Y set to -1. This represents the down direction.

## Methods

### Static methods

- `static Vector2Int Min(Vector2Int a, Vector2Int b)`
  - Returns an integer vector that has the minimum values on each axis between 2 given vectors.
- `static Vector2Int Max(Vector2Int a, Vector2Int b)`
  - Returns an integer vector that has the maximum values on each axis between 2 given vectors.
- `static Vector2Int Parse(System.String str)`
  - Given a string, try to convert this into a Vector2Int. Example formatting is "x,y", "[x,y]", "x y", etc.
- `static Vector2Int Parse(System.String str, System.IFormatProvider provider)`
- `static System.Boolean TryParse(System.String str, System.IFormatProvider info, Vector2Int result)`

### Instance methods

- `System.Boolean IsNearlyZero(System.Int32 tolerance)`
  - Returns true if value on every axis is less than or equal to tolerance
- `System.Void Write(System.IO.BinaryWriter writer)`
- `Vector2Int Read(System.IO.BinaryReader reader)`
- `Vector2Int ComponentMin(Vector2Int other)`
  - Returns an integer vector that has the minimum values on each axis of the two input vectors.
- `Vector2Int ComponentMax(Vector2Int other)`
  - Returns an integer vector that has the maximum values on each axis of the two input vectors.
- `System.Single Distance(Vector2Int other)`
  - Returns the distance between this vector and another.
- `System.Single Distance(Vector2 other)`
  - Returns the distance between this vector and another.
- `Vector2Int SnapToGrid(System.Int32 gridSize, System.Boolean sx, System.Boolean sy)`
  - Snap to grid along any of the 2 axes.
- `Vector2Int Abs()`
  - Returns a new integer vector with all values positive. -5 becomes 5, ect.
- `Vector2Int WithX(System.Int32 x)`
  - Returns this integer vector with given X component.
- `Vector2Int WithY(System.Int32 y)`
  - Returns this integer vector with given Y component.
