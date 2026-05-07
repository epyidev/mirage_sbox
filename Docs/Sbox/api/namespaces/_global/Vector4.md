# Vector4

A 4-dimensional vector/point.

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`

## Constructors

- `Vector4(System.Single x, System.Single y, System.Single z, System.Single w)`
  - Initializes a vector4 with given components.
  - `x`: The X component.
  - `y`: The Y component.
  - `z`: The Z component.
  - `w`: The W component.
- `Vector4(Vector4 other)`
  - Initializes a 4D vector from a given Vector4, i.e. creating a copy.
- `Vector4(Vector3 v, System.Single w)`
  - Initializes a 4D vector from given #D vector and the given W component.
- `Vector4(System.Single all)`
  - Initializes the 4D vector with all components set to given value.
- `Vector4(System.Numerics.Vector4 v)`

## Properties

- `System.Single x`
  - The X component of this Vector.
- `System.Single y`
  - The Y component of this Vector.
- `System.Single z`
  - The Z component of this Vector.
- `System.Single w`
  - The W component of this Vector.
- `System.Single Length`
  - The length (or magnitude) of the vector (Distance from 0,0,0).
- `System.Single LengthSquared`
  - Squared length of the vector. This is faster than `Vector4.Length`, and can be used for things like comparing distances, as long as only squared values are used.
- `System.Boolean IsNaN`
  - Returns true if x, y, z or w are NaN
- `System.Boolean IsInfinity`
  - Returns true if x, y, z or w are infinity
- `System.Boolean IsNearZeroLength`
  - Whether length of this vector is nearly zero.
- `System.Single Item`

## Fields

- `static Vector4 Zero`
  - A 4D vector with all components set to 0.
- `static Vector4 One`
  - A 4D vector with all components set to 1.

## Methods

### Static methods

- `static Vector4 Clamp(Vector4 value, Vector4 min, Vector4 max)`
  - Restricts a vector between a minimum and a maximum value.
  - `value`: The vector to restrict.
  - `min`: The mins vector. Values on each axis should be smaller than those of the maxs vector. See <see cref="M:Vector4.Sort(Vector4@,Vector4@)">Vector4.Sort</see>.
  - `max`: The maxs vector. Values on each axis should be bigger than those of the mins vector. See <see cref="M:Vector4.Sort(Vector4@,Vector4@)">Vector4.Sort</see>.
- `static Vector4 Max(Vector4 a, Vector4 b)`
  - Returns a vector that has the maximum values on each axis between the 2 given vectors.
- `static Vector4 Lerp(Vector4 a, Vector4 b, System.Single frac, System.Boolean clamp)`
  - Performs linear interpolation between 2 given vectors.
  - `a`: Vector A
  - `b`: Vector B
  - `frac`: Fraction, where 0 would return Vector A, 0.5 would return a point between the 2 vectors, and 1 would return Vector B.
  - `clamp`: Whether to clamp the fraction argument between [0,1]
- `static Vector4 Lerp(Vector4 a, Vector4 b, Vector4 frac, System.Boolean clamp)`
  - Performs linear interpolation between 2 given vectors, using a vector for the fraction on each axis.
  - `a`: Vector A
  - `b`: Vector B
  - `frac`: Fraction for each axis, where 0 would return Vector A, 0.5 would return a point between the 2 vectors, and 1 would return Vector B.
  - `clamp`: Whether to clamp the fraction argument between [0,1] on each axis
- `static System.Single Dot(Vector4 a, Vector4 b)`
  - Returns the scalar/dot product of the 2 given vectors
- `static System.Single DistanceBetween(Vector4 a, Vector4 b)`
- `static System.Single DistanceBetweenSquared(Vector4 a, Vector4 b)`
  - Returns squared distance between the 2 given vectors. This is faster than <see cref="M:Vector4.DistanceBetween(Vector4@,Vector4@)">DistanceBetween</see>,
and can be used for things like comparing distances, as long as only squared values are used.
- `static System.Void Sort(Vector4 min, Vector4 max)`
  - Sort these two vectors into min and max. This doesn't just swap the vectors, it sorts each component.
So that min will come out containing the minimum x, y, z and w values.
- `static Vector4 Parse(System.String str)`
  - Given a string, try to convert this into a vector4. The format is "x,y,z,w".
- `static Vector4 Parse(System.String str, System.IFormatProvider provider)`
- `static System.Boolean TryParse(System.String str, Vector4 result)`
- `static System.Boolean TryParse(System.String str, System.IFormatProvider provider, Vector4 result)`

### Instance methods

- `Vector4 WithX(System.Single x)`
  - Returns this vector with given X component.
  - `x`: The override for X component.
  - returns: The new vector.
- `Vector4 WithY(System.Single y)`
  - Returns this vector with given Y component.
  - `y`: The override for Y component.
  - returns: The new vector.
- `Vector4 WithZ(System.Single z)`
  - Returns this vector with given Z component.
  - `z`: The override for Z component.
  - returns: The new vector.
- `Vector4 WithW(System.Single w)`
  - Returns this vector with given W component.
  - `w`: The override for W component.
  - returns: The new vector.
- `System.Boolean IsNearlyZero(System.Single tolerance)`
  - Returns true if value on every axis is less than tolerance away from zero
- `Vector4 Clamp(Vector4 otherMin, Vector4 otherMax)`
  - Returns a vector each axis of which is clamped to between the 2 given vectors.
  - `otherMin`: The mins vector. Values on each axis should be smaller than those of the maxs vector. See <see cref="M:Vector4.Sort(Vector4@,Vector4@)">Vector4.Sort</see>.
  - `otherMax`: The maxs vector. Values on each axis should be bigger than those of the mins vector. See <see cref="M:Vector4.Sort(Vector4@,Vector4@)">Vector4.Sort</see>.
- `Vector4 Clamp(System.Single min, System.Single max)`
  - Returns a vector each axis of which is clamped to given min and max values.
  - `min`: Minimum value for each axis.
  - `max`: Maximum value for each axis.
- `Vector4 ComponentMin(Vector4 other)`
  - Returns a vector that has the minimum values on each axis between this vector and given vector.
- `Vector4 Min(Vector4 a, Vector4 b)`
  - Returns a vector that has the minimum values on each axis between the 2 given vectors.
- `Vector4 ComponentMax(Vector4 other)`
  - Returns a vector that has the maximum values on each axis between this vector and given vector.
- `Vector4 LerpTo(Vector4 target, System.Single frac, System.Boolean clamp)`
  - Performs linear interpolation between this and given vectors.
  - `target`: Vector B
  - `frac`: Fraction, where 0 would return Vector A, 0.5 would return a point between the 2 vectors, and 1 would return Vector B.
  - `clamp`: Whether to clamp the fraction argument between [0,1]
- `Vector4 LerpTo(Vector4 target, Vector4 frac, System.Boolean clamp)`
  - Performs linear interpolation between this and given vectors, with separate fraction for each vector component.
  - `target`: Vector B
  - `frac`: Fraction for each axis, where 0 would return this, 0.5 would return a point between this and given vectors, and 1 would return the given vector.
  - `clamp`: Whether to clamp the fraction argument between [0,1] on each axis
- `System.Single Dot(Vector4 b)`
  - Returns the scalar/dot product of this vector and given vector.
- `System.Single Distance(Vector4 target)`
  - Returns distance between this vector to given vector.
- `System.Single DistanceSquared(Vector4 target)`
  - Returns squared distance between this vector to given vector. This is faster than <see cref="M:Vector4.Distance(Vector4@)">Distance</see>,
and can be used for things like comparing distances, as long as only squared values are used.
- `System.Boolean AlmostEqual(Vector4 v, System.Single delta)`
  - Returns true if we're nearly equal to the passed vector.
  - `v`: The value to compare with
  - `delta`: The max difference between component values
  - returns: True if nearly equal
- `Vector4 SnapToGrid(System.Single gridSize, System.Boolean sx, System.Boolean sy, System.Boolean sz, System.Boolean sw)`
  - Snap to grid along any of the 4 axes.
