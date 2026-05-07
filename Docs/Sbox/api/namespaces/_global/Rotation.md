# Rotation

Represents a Quaternion rotation. Can be interpreted as a direction unit vector (x,y,z) + rotation around the direction vector (w) which represents the up direction.
Unlike `Angles`, this cannot store multiple revolutions around an axis.

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`

## Constructors

- `Rotation()`
  - Initializes this rotation to identity.
- `Rotation(System.Single x, System.Single y, System.Single z, System.Single w)`
  - Initializes the rotation from given components.
  - `x`: The X component.
  - `y`: The Y component.
  - `z`: The Z component.
  - `w`: The W component.
- `Rotation(Vector3 v, System.Single w)`
  - Initializes the rotation from a normal vector + rotation around it.
  - `v`: The normal vector.
  - `w`: The W component, aka rotation around the normal vector.

## Properties

- `System.Single x`
  - The X component of this rotation.
- `System.Single y`
  - The Y component of this rotation.
- `System.Single z`
  - The Z component of this rotation.
- `System.Single w`
  - The W component of this rotation (rotation around the normal defined by X,Y,Z components).
- `Vector3 Forward`
  - The forwards direction of this rotation.
- `Vector3 Backward`
  - The backwards direction of this rotation.
- `Vector3 Right`
  - The right hand direction of this rotation.
- `Vector3 Left`
  - The left hand direction of this rotation.
- `Vector3 Up`
  - The upwards direction of this rotation.
- `Vector3 Down`
  - The downwards direction of this rotation.
- `Rotation Inverse`
  - Returns the inverse of this rotation.
- `Rotation Normal`
  - Divides each component of the rotation by its length, normalizing the rotation.
- `Rotation Conjugate`
  - Returns conjugate of this rotation, meaning the X Y and Z components are negated.
- `static Rotation Random`
  - Returns a uniformly random rotation.

## Fields

- `static Rotation Identity`
  - A rotation that represents no rotation.

## Methods

### Static methods

- `static Rotation FromAxis(Vector3 axis, System.Single degrees)`
  - Create from angle and an axis
- `static Rotation From(Angles angles)`
  - Create a Rotation (quaternion) from Angles
- `static Rotation From(System.Single pitch, System.Single yaw, System.Single roll)`
  - Create a Rotation (quaternion) from pitch yaw roll (degrees)
- `static Rotation FromPitch(System.Single pitch)`
  - Create a Rotation (quaternion) from pitch (degrees)
- `static Rotation FromYaw(System.Single yaw)`
  - Create a Rotation (quaternion) from yaw (degrees)
- `static Rotation FromRoll(System.Single roll)`
  - Create a Rotation (quaternion) from roll (degrees)
- `static Rotation LookAt(Vector3 forward, Vector3 up)`
  - Create a Rotation (quaternion) from a forward and up vector
- `static Rotation LookAt(Vector3 forward)`
  - Create a Rotation (quaternion) from a forward vector, using `Vector3.Up` as
an up vector. This won't give nice results if `forward` is very close to straight
up or down, if that can happen you should use `Rotation.LookAt(Vector3,Vector3)`.
- `static Rotation Difference(Rotation from, Rotation to)`
  - Returns the difference between two rotations, as a rotation
- `static Rotation Lerp(Rotation a, Rotation b, System.Single frac, System.Boolean clamp)`
  - Perform a linear interpolation from a to b by given amount.
- `static Rotation Slerp(Rotation a, Rotation b, System.Single amount, System.Boolean clamp)`
  - Perform a spherical interpolation from a to b by given amount.
- `static Rotation SmoothDamp(Rotation current, Rotation target, Vector3 velocity, System.Single smoothTime, System.Single deltaTime)`
  - Smoothly move towards the target rotation
- `static Rotation FromToRotation(Vector3 fromDirection, Vector3 toDirection)`
  - Returns a Rotation that rotates from one direction to another.
- `static Rotation Parse(System.String str)`
  - Given a string, try to convert this into a quaternion rotation. The format is "x,y,z,w"
- `static Rotation Parse(System.String str, System.IFormatProvider provider)`
- `static System.Boolean TryParse(System.String str, Rotation result)`
- `static System.Boolean TryParse(System.String str, System.IFormatProvider provider, Rotation result)`

### Instance methods

- `System.Single Distance(Rotation to)`
  - The degree angular distance between this rotation and the target
- `System.Single Angle()`
  - Returns the turn length of this rotation (from identity) in degrees
- `Angles Angles()`
  - Return this Rotation as pitch, yaw, roll angles
- `System.Single Pitch()`
  - Return this Rotation pitch
- `System.Single Yaw()`
  - Return this Rotation yaw
- `System.Single Roll()`
  - Return this Rotation roll
- `Rotation LerpTo(Rotation target, System.Single frac, System.Boolean clamp)`
  - Perform a linear interpolation from this rotation to a target rotation by given amount.
- `Rotation SlerpTo(Rotation target, System.Single frac, System.Boolean clamp)`
  - Perform a spherical interpolation from this rotation to a target rotation by given amount.
- `Rotation Clamp(Rotation to, System.Single degrees)`
  - Clamp to within degrees of passed rotation
- `Rotation Clamp(Rotation to, System.Single degrees, System.Single change)`
  - Clamp to within degrees of passed rotation. Also pases out the change in degrees, if any.
- `Rotation RotateAroundAxis(Vector3 axis, System.Single degrees)`
  - A convenience function that rotates this rotation around a given axis given amount of degrees
- `Vector3 ClosestAxis(Vector3 normal)`
  - Will give you the axis most aligned with the given normal
- `System.Boolean AlmostEqual(Rotation r, System.Single delta)`
  - Returns true if we're nearly equal to the passed rotation.
Checks if each component is within a threshold, and handles the fact that
there are two ways to represent the same rotation as a quaternion.
  - `r`: The value to compare with
  - `delta`: Per-component threshold.
  - returns: True if nearly equal
