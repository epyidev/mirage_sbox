# Vector2

A 2-dimensional vector. Typically represents a position, size, or direction in 2D space.

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`

## Constructors

- `Vector2(System.Single x, System.Single y)`
  - Initializes a 2D vector with given components.
  - `x`: The X component.
  - `y`: The Y component.
- `Vector2(Vector2 other)`
  - Initializes a Vector2 from a given Vector2, i.e. creating a copy.
- `Vector2(System.Single all)`
  - Initializes the 2D vector with all components set to the given value.
- `Vector2(Vector3 v)`
  - Initializes the 2D vector with components from given 3D Vector, discarding the Z component.
- `Vector2(Vector4 v)`
  - Initializes the 2D vector with components from given 4D vector, discarding the Z and W components.
- `Vector2(System.Numerics.Vector2 v)`

## Properties

- `System.Single x`
  - X component of this vector.
- `System.Single y`
  - Y component of this vector.
- `static Vector2 One`
  - Returns a 2D vector with every component set to 1
- `static Vector2 Zero`
  - Returns a 2D vector with every component set to 0
- `static Vector2 Up`
  - Returns a 2D vector with Y set to -1. This typically represents up in 2D space.
- `static Vector2 Down`
  - Returns a 2D vector with Y set to 1. This typically represents down in 2D space.
- `static Vector2 Left`
  - Returns a 2D vector with X set to -1. This typically represents the left hand direction in 2D space.
- `static Vector2 Right`
  - Returns a 2D vector with X set to 1. This typically represents the right hand direction in 2D space.
- `static Vector2 Random`
  - Uniformly samples a 2D position from all points with distance at most 1 from the origin.
- `Vector2 Normal`
  - Return the same vector but with a length of one
- `System.Single Length`
  - Returns the magnitude of the vector
- `System.Single LengthSquared`
  - This is faster than Length, so is better to use in certain circumstances
- `Vector2 Inverse`
  - Returns the inverse of this vector, which is useful for scaling vectors
- `System.Single Degrees`
  - Return the angle of this vector in degrees, always between 0 and 360
- `Vector2 Perpendicular`
  - Returns a vector that runs perpendicular to this one
- `System.Boolean IsNaN`
  - Returns true if x, y, or z are NaN
- `System.Boolean IsInfinity`
  - Returns true if x, y, or z are infinity
- `System.Boolean IsNearZeroLength`
  - Returns true if the squared length is less than 1e-8 (which is really near zero)
- `System.Single Item`

## Methods

### Static methods

- `static Vector2 FromRadians(System.Single radians)`
  - Returns a point on a circle at given rotation from X axis, counter clockwise.
- `static Vector2 FromDegrees(System.Single degrees)`
  - Returns a point on a circle at given rotation from X axis, counter clockwise.
- `static Vector2 Clamp(Vector2 value, Vector2 min, Vector2 max)`
  - Restricts a vector between a minimum and maximum value.
  - `value`: The vector to restrict.
  - `min`: The mins vector. Values on each axis should be smaller than those of the maxs vector. See <see cref="M:Vector2.Sort(Vector2@,Vector2@)">Vector2.Sort</see>.
  - `max`: The maxs vector. Values on each axis should be larger than those of the mins vector. See <see cref="M:Vector2.Sort(Vector2@,Vector2@)">Vector2.Sort</see>.
- `static Vector2 Min(Vector2 a, Vector2 b)`
  - Returns a vector that has the minimum values on each axis between the 2 given vectors.
- `static Vector2 Max(Vector2 a, Vector2 b)`
  - Returns a vector that has the maximum values on each axis between the 2 given vectors.
- `static Vector2 Lerp(Vector2 a, Vector2 b, System.Single frac, System.Boolean clamp)`
  - Linearly interpolate from point a to point b.
- `static Vector2 Lerp(Vector2 a, Vector2 b, Vector2 t, System.Boolean clamp)`
  - Linearly interpolate from point a to point b with separate fraction for each axis.
- `static System.Single Dot(Vector2 a, Vector2 b)`
  - Returns the scalar/dot product between the 2 given vectors.
- `static System.Single DistanceBetween(Vector2 a, Vector2 b)`
  - Returns distance between the 2 given vectors.
- `static System.Single Distance(Vector2 a, Vector2 b)`
  - Returns distance between the 2 given vectors.
- `static System.Single DistanceBetweenSquared(Vector2 a, Vector2 b)`
  - Returns squared distance between the 2 given vectors. This is faster than <see cref="M:Vector2.DistanceBetween(Vector2,Vector2)">DistanceBetween</see>,
and can be used for things like comparing distances, as long as only squared values are used.
- `static System.Single DistanceSquared(Vector2 a, Vector2 b)`
  - Returns squared distance between the 2 given vectors. This is faster than <see cref="M:Vector2.DistanceBetween(Vector2,Vector2)">DistanceBetween</see>,
and can be used for things like comparing distances, as long as only squared values are used.
- `static Vector2 Direction(Vector2 from, Vector2 to)`
  - Calculates the normalized direction vector from one point to another in 2D space.
- `static Vector2 Abs(Vector2 value)`
  - Returns a new vector with all values positive. -5 becomes 5, etc.
- `static Vector2 Reflect(Vector2 direction, Vector2 normal)`
  - Returns a reflected vector based on incoming direction and plane normal. Like a ray reflecting off of a mirror.
- `static System.Void Sort(Vector2 min, Vector2 max)`
  - Sort these two vectors into min and max. This doesn't just swap the vectors, it sorts each component.
So that min will come out containing the minimum x and y values.
- `static Vector2 CubicBezier(Vector2 source, Vector2 target, Vector2 sourceTangent, Vector2 targetTangent, System.Single t)`
  - Calculates position of a point on a cubic bezier curve at given fraction.
  - `source`: Point A of the curve.
  - `target`: Point B of the curve.
  - `sourceTangent`: Tangent for the Point A.
  - `targetTangent`: Tangent for the Point B.
  - `t`: How far along the path to get a point on. Range is 0 to 1, inclusive.
  - returns: The point on the curve
- `static System.Single GetAngle(Vector2 v1, Vector2 v2)`
  - Returns the distance between two direction vectors in degrees.
- `static Vector2 Parse(System.String str)`
  - Given a string, try to convert this into a Vector2. Example formatting is "x,y", "[x,y]", "x y", etc.
- `static System.Boolean TryParse(System.String str, Vector2 result)`
- `static Vector2 Parse(System.String str, System.IFormatProvider provider)`
- `static System.Boolean TryParse(System.String str, System.IFormatProvider provider, Vector2 result)`
- `static Vector2 SmoothDamp(Vector2 current, Vector2 target, Vector2 velocity, System.Single smoothTime, System.Single deltaTime)`
  - Smoothly move towards the target vector
- `static Vector2 SpringDamp(Vector2 current, Vector2 target, Vector2 velocity, System.Single deltaTime, System.Single frequency, System.Single damping)`
  - Springly move towards the target vector
- `static Vector2 SpringDamp(Vector2 current, Vector2 target, Vector2 velocity, System.Single smoothTime, System.Single deltaTime, System.Single frequency, System.Single damping)`

### Instance methods

- `Vector2 WithX(System.Single x)`
  - Return this vector with given X.
- `Vector2 WithY(System.Single y)`
  - Return this vector with given Y.
- `System.Boolean IsNearlyZero(System.Single tolerance)`
  - Returns true if value on every axis is less than tolerance away from zero
- `Vector2 ClampLength(System.Single maxLength)`
  - Returns a vector whose length is limited to given maximum
- `Vector2 ClampLength(System.Single minLength, System.Single maxLength)`
  - Returns a vector whose length is limited between given minimum and maximum
- `Vector2 Clamp(Vector2 otherMin, Vector2 otherMax)`
  - Returns a vector each axis of which is clamped to between the 2 given vectors. Basically clamps a point to a square.
  - `otherMin`: The mins vector. Values on each axis should be smaller than those of the maxs vector. See <see cref="M:Vector2.Sort(Vector2@,Vector2@)">Vector2.Sort</see>.
  - `otherMax`: The maxs vector. Values on each axis should be larger than those of the mins vector. See <see cref="M:Vector2.Sort(Vector2@,Vector2@)">Vector2.Sort</see>.
- `Vector2 Clamp(System.Single min, System.Single max)`
  - Returns a vector each axis of which is clamped to given min and max values.
  - `min`: Minimum value for each axis.
  - `max`: Maximum value for each axis.
- `Vector2 ComponentMin(Vector2 other)`
  - Returns a vector that has the minimum values on each axis between this vector and given vector.
- `Vector2 ComponentMax(Vector2 other)`
  - Returns a vector that has the maximum values on each axis between this vector and given vector.
- `Vector2 LerpTo(Vector2 target, System.Single t, System.Boolean clamp)`
  - Linearly interpolate from this vector to given vector.
- `Vector2 LerpTo(Vector2 target, Vector2 t, System.Boolean clamp)`
  - Linearly interpolate from this vector to given vector with separate fraction for each axis.
- `System.Single Dot(Vector2 b)`
  - Returns the scalar/dot product between this and the given vector.
- `System.Single Distance(Vector2 target)`
  - Returns distance between this and given vectors.
- `System.Single DistanceSquared(Vector2 target)`
  - Returns squared distance between the 2 given vectors. This is faster than <see cref="M:Vector2.Distance(Vector2)">Distance</see>,
and can be used for things like comparing distances, as long as only squared values are used.
- `Vector2 SubtractDirection(Vector2 direction, System.Single strength)`
  - Given a vector like 1,1,1 and direction 1,0,0, will return 0,1,1.
This is useful for velocity collision type events, where you want to
cancel out velocity based on a normal.
For this to work properly, direction should be a normal, but you can scale
how much you want to subtract by scaling the direction. Ie, passing in a direction
with a length of 0.5 will remove half the direction.
- `Vector2 Approach(System.Single length, System.Single amount)`
  - Returns a new vector whos length is closer to given target length by given amount.
- `Vector2 Abs()`
  - Returns a new vector with all values positive. -5 becomes 5, etc.
- `System.Boolean AlmostEqual(Vector2 v, System.Single delta)`
  - Returns true if we're nearly equal to the passed vector.
  - `v`: The value to compare with
  - `delta`: The max difference between component values
  - returns: True if nearly equal
- `Vector2 SnapToGrid(System.Single gridSize, System.Boolean sx, System.Boolean sy)`
  - Snap to grid along all 3 axes.
- `System.Single Angle(Vector2 other)`
  - Returns the distance between this vector and another in degrees.
- `Vector2 AddClamped(Vector2 toAdd, System.Single maxLength)`
  - Try to add to this vector. If we're already over max then don't add.
If we're over max when we add, clamp in that direction so we're not.
- `Vector2 RotateAround(Vector2 center, System.Single angleDegrees)`
  - Rotate this vector around given point by given angle in degrees and
return the result as a new vector.
- `Vector2 WithAcceleration(Vector2 target, System.Single accelerate)`
  - Move to the target vector, by amount acceleration
- `Vector2 WithFriction(System.Single frictionAmount, System.Single stopSpeed)`
