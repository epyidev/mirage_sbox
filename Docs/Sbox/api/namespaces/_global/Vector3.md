# Vector3

A 3-dimentional vector. Typically represents a position, size, or direction in 3D space.

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`

## Constructors

- `Vector3(System.Single x, System.Single y, System.Single z)`
  - Initializes a vector with given components.
  - `x`: The X component.
  - `y`: The Y component.
  - `z`: The Z component.
- `Vector3(System.Single x, System.Single y)`
  - Initializes a vector with given components and Z set to 0.
  - `x`: The X component.
  - `y`: The Y component.
- `Vector3(Vector3 other)`
  - Initializes a Vector3 from a given Vector3, i.e. creating a copy.
- `Vector3(Vector2 other, System.Single z)`
  - Initializes a Vector3 from given Vector2 and Z component.
- `Vector3(System.Single all)`
  - Initializes the vector with all components set to given value.
- `Vector3(System.Numerics.Vector3 v)`

## Properties

- `System.Single x`
  - The X component of this vector.
- `System.Single y`
  - The Y component of this vector.
- `System.Single z`
  - The Z component of this vector.
- `static Vector3 Random`
  - Uniformly samples a 3D position from all points with distance at most 1 from the origin.
- `Vector3 Normal`
  - Returns a unit version of this vector. A unit vector has length of 1.
- `System.Single Length`
  - Length (or magnitude) of the vector (Distance from 0,0,0).
- `System.Single LengthSquared`
  - Squared length of the vector. This is faster than <see cref="P:Vector3.Length">Length</see>, and can be used for things like comparing distances, as long as only squared values are used.
- `Vector3 Inverse`
  - Returns the inverse of this vector, which is useful for scaling vectors.
- `System.Boolean IsNaN`
  - Returns true if x, y or z are NaN
- `System.Boolean IsInfinity`
  - Returns true if x, y or z are infinity
- `System.Boolean IsNearZeroLength`
  - Returns true if the squared length is less than 1e-8 (which is really near zero)
- `Angles EulerAngles`
  - The Euler angles of this direction vector.
- `System.Single Item`

## Fields

- `static Vector3 One`
  - A vector with all components set to 1.
- `static Vector3 Zero`
  - A vector with all components set to 0.
- `static Vector3 Forward`
  - A vector with X set to 1. This represents the forwards direction.
- `static Vector3 Backward`
  - A vector with X set to -1. This represents the backwards direction.
- `static Vector3 Up`
  - A vector with Z set to 1. This represents the upwards direction.
- `static Vector3 Down`
  - A vector with Z set to -1. This represents the downwards direction.
- `static Vector3 Right`
  - A vector with Y set to -1. This represents the right hand direction.
- `static Vector3 Left`
  - A vector with Y set to 1. This represents the left hand direction.

## Methods

### Static methods

- `static Vector3 Clamp(Vector3 value, Vector3 min, Vector3 max)`
  - Restricts a vector between a minimum and a maximum value.
  - `value`: The vector to restrict.
  - `min`: The mins vector. Values on each axis should be smaller than those of the maxs vector. See <see cref="M:Vector3.Sort(Vector3@,Vector3@)">Vector3.Sort</see>.
  - `max`: The maxs vector. Values on each axis should be bigger than those of the mins vector. See <see cref="M:Vector3.Sort(Vector3@,Vector3@)">Vector3.Sort</see>.
- `static Vector3 Min(Vector3 a, Vector3 b)`
  - Returns a vector that has the minimum values on each axis between the 2 given vectors.
- `static Vector3 Max(Vector3 a, Vector3 b)`
  - Returns a vector that has the maximum values on each axis between the 2 given vectors.
- `static Vector3 Lerp(Vector3 a, Vector3 b, System.Single frac, System.Boolean clamp)`
  - Performs linear interpolation between 2 given vectors.
  - `a`: Vector A
  - `b`: Vector B
  - `frac`: Fraction, where 0 would return Vector A, 0.5 would return a point between the 2 vectors, and 1 would return Vector B.
  - `clamp`: Whether to clamp the fraction argument between [0,1]
- `static Vector3 Lerp(Vector3 a, Vector3 b, Vector3 frac, System.Boolean clamp)`
  - Performs linear interpolation between 2 given vectors, with separate fraction for each vector component.
  - `a`: Vector A
  - `b`: Vector B
  - `frac`: Fraction for each axis, where 0 would return Vector A, 0.5 would return a point between the 2 vectors, and 1 would return Vector B.
  - `clamp`: Whether to clamp the fraction argument between [0,1] on each axis
- `static Vector3 Slerp(Vector3 a, Vector3 b, System.Single frac, System.Boolean clamp)`
  - Performs spherical linear interpolation (Slerp) between two vectors.
  - `a`: Starting vector (A).
  - `b`: Target vector (B).
  - `frac`: Interpolation fraction: 0 returns A, 1 returns B, and values in between provide intermediate results along the spherical path.
  - `clamp`: If true, clamps the fraction between 0 and 1.
  - returns: Interpolated vector along the spherical path.
- `static System.Single InverseLerp(Vector3 pos, Vector3 a, Vector3 b, System.Boolean clamp)`
  - Given a position, and two other positions, calculate the inverse lerp position between those
- `static Vector3 Cross(Vector3 a, Vector3 b)`
  - Returns the cross product of the 2 given vectors.
If the given vectors are linearly independent, the resulting vector is perpendicular to them both, also known as a normal of a plane.
- `static System.Single Dot(Vector3 a, Vector3 b)`
  - Returns the scalar/dot product of the 2 given vectors.
- `static System.Single DistanceBetween(Vector3 a, Vector3 b)`
  - Returns distance between the 2 given vectors.
- `static System.Single DistanceBetweenSquared(Vector3 a, Vector3 b)`
  - Returns squared distance between the 2 given vectors. This is faster than <see cref="M:Vector3.DistanceBetween(Vector3@,Vector3@)">DistanceBetween</see>,
and can be used for things like comparing distances, as long as only squared values are used.
- `static Vector3 Direction(Vector3 from, Vector3 to)`
  - Calculates the normalized direction vector from one point to another in 3D space.
- `static Vector3 Abs(Vector3 value)`
  - Returns a new vector with all values positive. -5 becomes 5, etc.
- `static Vector3 Reflect(Vector3 direction, Vector3 normal)`
  - Returns a reflected vector based on incoming direction and plane normal. Like a ray reflecting off of a mirror.
- `static Vector3 VectorPlaneProject(Vector3 v, Vector3 planeNormal)`
  - <a href="https://en.wikipedia.org/wiki/Vector_projection">Projects given vector</a> on a plane defined by `planeNormal`.
  - `v`: The vector to project.
  - `planeNormal`: Normal of a plane to project onto.
  - returns: The projected vector.
- `static System.Void Sort(Vector3 min, Vector3 max)`
  - Sort these two vectors into min and max. This doesn't just swap the vectors, it sorts each component.
So that min will come out containing the minimum x, y and z values.
- `static Vector3 CubicBezier(Vector3 source, Vector3 target, Vector3 sourceTangent, Vector3 targetTangent, System.Single t)`
  - Calculates position of a point on a cubic beizer curve at given fraction.
  - `source`: Point A of the curve in world space.
  - `target`: Point B of the curve in world space.
  - `sourceTangent`: Tangent for the Point A in world space.
  - `targetTangent`: Tangent for the Point B in world space.
  - `t`: How far along the path to get a point on. Range is 0 to 1, inclusive.
  - returns: The point on the curve
- `static System.Single GetAngle(Vector3 v1, Vector3 v2)`
  - Return the distance between the two direction vectors in degrees.
- `static Angles VectorAngle(Vector3 vec)`
  - Converts a direction vector to an angle.
- `static Vector3 Parse(System.String str, System.IFormatProvider provider)`
- `static Vector3 Parse(System.String str)`
- `static System.Boolean TryParse(System.String str, Vector3 result)`
- `static System.Boolean TryParse(System.String str, System.IFormatProvider provider, Vector3 result)`
  - Given a string, try to convert this into a vector. Example input formats that work would be "1,1,1", "1;1;1", "[1 1 1]".
            
This handles a bunch of different separators ( ' ', ',', ';', '\n', '\r' ).
            
It also trims surrounding characters ('[', ']', ' ', '\n', '\r', '\t', '"').
- `static Vector3 CatmullRomSpline(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, System.Single t)`
  - Calculates a point on a Catmull-Rom spline given four control points and a parameter t.
- `static Vector3 TcbSpline(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, System.Single tension, System.Single continuity, System.Single bias, System.Single u)`
  - Calculates an interpolated point using the Kochanek-Bartels spline (TCB spline).
  - `tension`: Tension parameter which affects the sharpness at the control point.
            Positive values make the curve tighter, negative values make it rounder.
  - `continuity`: Continuity parameter which affects the continuity between segments.
            Positive values create smoother transitions, negative values can create corners.
  - `bias`: Bias parameter which affects the direction of the curve as it passes through the control point.
            Positive values bias the curve towards the next point, negative values towards the previous.
  - `u`: The interpolation parameter between 0 and 1, where 0 is the start of the segment and 1 is the end.
  - returns: The interpolated point on the curve.
- `static Vector3 SmoothDamp(Vector3 current, Vector3 target, Vector3 velocity, System.Single smoothTime, System.Single deltaTime)`
  - Smoothly move towards the target vector
- `static Vector3 SpringDamp(Vector3 current, Vector3 target, Vector3 velocity, System.Single deltaTime, System.Single frequency, System.Single damping)`
  - Springly move towards the target vector
- `static Vector3 SpringDamp(Vector3 current, Vector3 target, Vector3 velocity, System.Single smoothTime, System.Single deltaTime, System.Single frequency, System.Single damping)`

### Instance methods

- `Vector3 WithX(System.Single x)`
  - Returns this vector with given X component.
  - `x`: The override for X component.
  - returns: The new vector.
- `Vector3 WithY(System.Single y)`
  - Returns this vector with given Y component.
  - `y`: The override for Y component.
  - returns: The new vector.
- `Vector3 WithZ(System.Single z)`
  - Returns this vector with given Z component.
  - `z`: The override for Z component.
  - returns: The new vector.
- `System.Boolean IsNearlyZero(System.Single tolerance)`
  - Returns true if value on every axis is less than tolerance away from zero
- `Vector3 ClampLength(System.Single maxLength)`
  - Returns a vector whose length is limited to given maximum.
- `Vector3 ClampLength(System.Single minLength, System.Single maxLength)`
  - Returns a vector whose length is limited between given minimum and maximum.
- `Vector3 Clamp(Vector3 otherMin, Vector3 otherMax)`
  - Returns a vector each axis of which is clamped to between the 2 given vectors. Basically clamps a point to an Axis Aligned Bounding Box (AABB).
  - `otherMin`: The mins vector. Values on each axis should be smaller than those of the maxs vector. See <see cref="M:Vector3.Sort(Vector3@,Vector3@)">Vector3.Sort</see>.
  - `otherMax`: The maxs vector. Values on each axis should be bigger than those of the mins vector. See <see cref="M:Vector3.Sort(Vector3@,Vector3@)">Vector3.Sort</see>.
- `Vector3 Clamp(System.Single min, System.Single max)`
  - Returns a vector each axis of which is clamped to given min and max values.
  - `min`: Minimum value for each axis.
  - `max`: Maximum value for each axis.
- `Vector3 ComponentMin(Vector3 other)`
  - Returns a vector that has the minimum values on each axis between this vector and given vector.
- `Vector3 ComponentMax(Vector3 other)`
  - Returns a vector that has the maximum values on each axis between this vector and given vector.
- `Vector3 LerpTo(Vector3 target, System.Single frac, System.Boolean clamp)`
  - Performs linear interpolation between this and given vectors.
  - `target`: Vector B
  - `frac`: Fraction, where 0 would return this, 0.5 would return a point between this and given vectors, and 1 would return the given vector.
  - `clamp`: Whether to clamp the fraction argument between [0,1]
- `Vector3 LerpTo(Vector3 target, Vector3 frac, System.Boolean clamp)`
  - Performs linear interpolation between this and given vectors, with separate fraction for each vector component.
  - `target`: Vector B
  - `frac`: Fraction for each axis, where 0 would return this, 0.5 would return a point between this and given vectors, and 1 would return the given vector.
  - `clamp`: Whether to clamp the fraction argument between [0,1] on each axis
- `Vector3 SlerpTo(Vector3 target, System.Single frac, System.Boolean clamp)`
  - Performs spherical linear interpolation (Slerp) between this vector and a target vector.
  - `target`: The target vector to interpolate towards.
  - `frac`: Interpolation fraction: 0 returns this vector, 1 returns the target vector, and values in between provide intermediate results along the spherical path.
  - `clamp`: If true, clamps the fraction between 0 and 1.
  - returns: Interpolated vector along the spherical path.
- `Vector3 Cross(Vector3 b)`
  - Returns the cross product of this and the given vector.
If this and the given vectors are linearly independent, the resulting vector is perpendicular to them both, also known as a normal of a plane.
- `System.Single Dot(Vector3 b)`
  - Returns the scalar/dot product of this and the given vectors.
- `System.Single Distance(Vector3 target)`
  - Returns distance between this vector to given vector.
- `System.Single DistanceSquared(Vector3 target)`
  - Returns squared distance between this vector to given vector. This is faster than <see cref="M:Vector3.Distance(Vector3@)">Distance</see>,
and can be used for things like comparing distances, as long as only squared values are used.
- `Vector3 SubtractDirection(Vector3 direction, System.Single strength)`
  - Given a vector like 1,1,1 and direction 1,0,0, will return 0,1,1.
This is useful for velocity collision type events, where you want to
cancel out velocity based on a normal.
For this to work properly, direction should be a normal, but you can scale
how much you want to subtract by scaling the direction. Ie, passing in a direction
with a length of 0.5 will remove half the direction.
- `Vector3 Approach(System.Single length, System.Single amount)`
  - Returns a new vector whose length is closer to given target length by given amount.
  - `length`: Target length.
  - `amount`: How much to subtract or add.
- `Vector3 Abs()`
  - Returns a new vector with all values positive. -5 becomes 5, etc.
- `Vector3 ProjectOnNormal(Vector3 normal)`
  - <a href="https://en.wikipedia.org/wiki/Vector_projection">Projects this vector</a> onto another vector.
            
             Basically extends the given normal/unit vector to be as long as necessary to make a right triangle (a triangle which has a 90 degree corner)
             between (0,0,0), this vector and the projected vector.
  - returns: The projected vector.
- `System.Boolean AlmostEqual(Vector3 v, System.Single delta)`
  - Returns true if we're nearly equal to the passed vector.
  - `v`: The value to compare with
  - `delta`: The max difference between component values
  - returns: True if nearly equal
- `Vector3 SnapToGrid(System.Single gridSize, System.Boolean sx, System.Boolean sy, System.Boolean sz)`
  - Snap to grid along any of the 3 axes.
- `System.Single Angle(Vector3 other)`
  - Return the distance between the two direction vectors in degrees.
- `Vector3 AddClamped(Vector3 toAdd, System.Single maxLength)`
  - Try to add to this vector. If we're already over max then don't add.
If we're over max when we add, clamp in that direction so we're not.
- `Vector3 RotateAround(Vector3 center, Rotation rot)`
  - Rotate this vector around given point by given rotation and return the result as a new vector.<br />
See `Transform.RotateAround(Vector3@,Rotation@)` for similar method that also transforms rotation.
  - `center`: Point to rotate around.
  - `rot`: How much to rotate by. `Rotation.FromAxis(Vector3,System.Single)` can be useful.
  - returns: The rotated vector.
- `Vector3 WithAcceleration(Vector3 target, System.Single acceleration)`
  - Move to the target vector, by amount acceleration
- `Vector3 WithFriction(System.Single frictionAmount, System.Single stopSpeed)`
  - Apply an amount of friction to the current velocity.
