# Angles

Euler angles. Unlike a <see cref="T:Rotation">Rotation</see>, Euler angles can represent multiple revolutions (rotations) around an axis,
but suffer from issues like gimbal lock and lack of a defined "up" vector. Use <see cref="T:Rotation">Rotation</see> for most cases.

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`

## Constructors

- `Angles(System.Single pitch, System.Single yaw, System.Single roll)`
  - Initializes the angles object with given components.
  - `pitch`: The Pitch component.
  - `yaw`: The Yaw component.
  - `roll`: The roll component.
- `Angles(Angles other)`
  - Copies values of given angles object.
- `Angles(Vector3 vector)`
  - Where x, y and z represent the pitch, yaw and roll respectively.
- `Angles(System.Single all)`
  - Initializes the angles object with all components set to given value.

## Properties

- `static Angles Random`
  - Returns the angles of a uniformly random rotation.
- `Angles Normal`
  - Returns normalized version of this object, meaning the angle on each axis is normalized to range of (-180,180].
- `Vector3 Forward`
  - The forward direction vector for this angle.

## Fields

- `System.Single pitch`
  - The pitch component, typically up/down.
- `System.Single yaw`
  - The yaw component, typically left/right.
- `System.Single roll`
  - The roll component, basically rotation around the axis.
- `static Angles Zero`
  - An angle constant that has all its values set to 0. Use this instead of making a static 0,0,0 object yourself.

## Methods

### Static methods

- `static Angles Parse(System.String str)`
  - Given a string, try to convert this into an angles object. The format is "p,y,r".
- `static Angles Parse(System.String str, System.IFormatProvider provider)`
- `static System.Boolean TryParse(System.String str, Angles result)`
- `static System.Boolean TryParse(System.String str, System.IFormatProvider provider, Angles result)`
- `static System.Single ClampAngle(System.Single v)`
  - Clamps the angle to range of [0, 360)
- `static System.Single NormalizeAngle(System.Single v)`
  - Normalizes the angle to range of (-180, 180]
- `static Angles Lerp(Angles source, Angles target, System.Single frac)`
  - Performs linear interpolation on the two given angle objects.
  - `source`: Angle A
  - `target`: Angle B
  - `frac`: Fraction in range [0,1] between the 2 angle objects to use for interpolation.
- `static Vector3 AngleVector(Angles ang)`
  - Converts an angle to a forward vector.

### Instance methods

- `Rotation ToRotation()`
  - Converts these Euler angles to a rotation. The angles will be normalized.
- `Vector3 AsVector3()`
  - Return as a Vector3, where x = pitch etc
- `System.Boolean IsNearlyZero(System.Double tolerance)`
  - Returns true if this angles object's components are all nearly zero with given tolerance.
- `Angles WithPitch(System.Single pitch)`
  - Returns this angles object with given pitch component.
- `Angles WithYaw(System.Single yaw)`
  - Returns this angles object with given yaw component.
- `Angles WithRoll(System.Single roll)`
  - Returns this angles object with given roll component.
- `Angles Clamped()`
  - Returns clamped version of this object, meaning the angle on each axis is transformed to range of [0,360).
- `Angles LerpTo(Angles target, System.Single frac)`
  - Performs linear interpolation on the two given angle objects.
  - `target`: Angle B
  - `frac`: Fraction in range [0,1] between the 2 angle objects to use for interpolation.
- `Angles SnapToGrid(System.Single gridSize, System.Boolean sx, System.Boolean sy, System.Boolean sz)`
  - Snap to grid
