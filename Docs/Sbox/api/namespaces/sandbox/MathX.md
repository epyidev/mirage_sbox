# Sandbox.MathX

A class to add functionality to the math library that System.Math and System.MathF don't provide.
A lot of these methods are also extensions, so you can use for example `int i = 1.0f.FloorToInt();`

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Methods

### Static methods

- `static System.Single DegreeToRadian(System.Single deg)`
  - Convert degrees to radians.
            


180 degrees is `System.Math.PI` (roughly 3.14) radians, etc.
  - `deg`: A value in degrees to convert.
  - returns: The given value converted to radians.
- `static System.Single RadianToDegree(System.Single rad)`
  - Convert radians to degrees.
            


180 degrees is `System.Math.PI` (roughly 3.14) radians, etc.
  - `rad`: A value in radians to convert.
  - returns: The given value converted to degrees.
- `static System.Single GradiansToDegrees(System.Single grad)`
  - Convert gradians to degrees.
            


100 gradian is 90 degrees, 200 gradian is 180 degrees, etc.
  - `grad`: A value in gradians to convert.
  - returns: The given value converted to degrees.
- `static System.Single GradiansToRadians(System.Single grad)`
  - Convert gradians to radians.
            


200 gradian is `System.Math.PI` (roughly 3.14) radians, etc.
  - `grad`: A value in gradians to convert.
  - returns: The given value converted to radians.
- `static System.Single MeterToInch(System.Single meters)`
  - Convert meters to inches.
- `static System.Single InchToMeter(System.Single inches)`
  - Convert inches to meters.
- `static System.Single InchToMillimeter(System.Single inches)`
  - Convert inches to millimeters.
- `static System.Single MillimeterToInch(System.Single millimeters)`
  - Convert millimeters to inches.
- `static System.Single SnapToGrid(System.Single f, System.Single gridSize)`
  - Snap number to grid
- `static System.Int32 SnapToGrid(System.Int32 f, System.Int32 gridSize)`
  - Snap number to grid
- `static System.Int32 FloorToInt(System.Single f)`
  - Remove the fractional part and return the float as an integer.
- `static System.Single Floor(System.Single f)`
  - Remove the fractional part of given floating point number
- `static System.Int32 CeilToInt(System.Single f)`
  - Rounds up given float to next integer value.
- `static System.Single Clamp(System.Single v, System.Single min, System.Single max)`
  - Clamp a float between 2 given extremes.
If given value is lower than the given minimum value, returns the minimum value, etc.
  - `v`: The value to clamp.
  - `min`: Minimum return value.
  - `max`: Maximum return value.
  - returns: The clamped float.
- `static System.Single Lerp(System.Single from, System.Single to, System.Single frac, System.Boolean clamp)`
  - Performs linear interpolation on floating point numbers.
  - `from`: The "starting value" of the interpolation.
  - `to`: The "final value" of the interpolation.
  - `frac`: The fraction in range of 0 (will return value of `from`) to 1 (will return value of `to`).
  - `clamp`: Whether to clamp the fraction between 0 and 1, and therefore the output value between `from` and `to`.
  - returns: The result of linear interpolation.
- `static System.Double Lerp(System.Double from, System.Double to, System.Double frac, System.Boolean clamp)`
  - Performs linear interpolation on floating point numbers.
  - `from`: The "starting value" of the interpolation.
  - `to`: The "final value" of the interpolation.
  - `frac`: The fraction in range of 0 (will return value of `from`) to 1 (will return value of `to`).
  - `clamp`: Whether to clamp the fraction between 0 and 1, and therefore the output value between `from` and `to`.
  - returns: The result of linear interpolation.
- `static System.Single LerpTo(System.Single from, System.Single to, System.Single frac, System.Boolean clamp)`
- `static System.Single[] LerpTo(System.Single[] from, System.Single[] to, System.Single delta, System.Boolean clamp)`
  - Performs multiple linear interpolations at the same time.
- `static System.Single LerpDegrees(System.Single from, System.Single to, System.Single frac, System.Boolean clamp)`
  - Linearly interpolates between two angles in degrees, taking the shortest arc.
- `static System.Single LerpDegreesTo(System.Single from, System.Single to, System.Single frac, System.Boolean clamp)`
- `static System.Single LerpRadians(System.Single from, System.Single to, System.Single frac, System.Boolean clamp)`
  - Linearly interpolates between two angles in radians, taking the shortest arc.
- `static System.Single LerpRadiansTo(System.Single from, System.Single to, System.Single frac, System.Boolean clamp)`
- `static System.Single LerpInverse(System.Single value, System.Single from, System.Single to, System.Boolean clamp)`
  - Performs inverse of a linear interpolation, that is, the return value is the fraction of a linear interpolation.
  - `value`: The value relative to `from` and `to`.
  - `from`: The "starting value" of the interpolation. If `value` is at this value or less, the function will return 0 or less.
  - `to`: The "final value" of the interpolation. If `value` is at this value or greater, the function will return 1 or greater.
  - `clamp`: Whether the return value is allowed to exceed range of 0 - 1.
  - returns: The resulting fraction.
- `static System.Single Approach(System.Single f, System.Single target, System.Single delta)`
  - Adds or subtracts given amount based on whether the input is smaller of bigger than the target.
- `static System.Boolean AlmostEqual(System.Single value, System.Single b, System.Single within)`
  - Returns true if given value is close to given value within given tolerance.
- `static System.Single UnsignedMod(System.Single a, System.Single b)`
  - Does what you expected to happen when you did "a % b"
- `static System.Single NormalizeDegrees(System.Single degree)`
  - Convert angle to between 0 - 360
- `static System.Single DeltaDegrees(System.Single from, System.Single to)`
  - Difference between two angles in degrees. Will always be between -180 and +180.
- `static System.Single DeltaRadians(System.Single from, System.Single to)`
  - Difference between two angles in radians. Will always be between -PI and +PI.
- `static System.Single Remap(System.Single value, System.Single oldLow, System.Single oldHigh, System.Single newLow, System.Single newHigh)`
  - Remap a float value from a one range to another. Clamps value between newLow and newHigh.
- `static System.Double Remap(System.Double value, System.Double oldLow, System.Double oldHigh, System.Double newLow, System.Double newHigh)`
  - Remap a double value from one range to another. Clamps value between newLow and newHigh.
- `static System.Single Remap(System.Single value, System.Single oldLow, System.Single oldHigh, System.Single newLow, System.Single newHigh, System.Boolean clamp)`
  - Remap a float value from a one range to another
- `static System.Double Remap(System.Double value, System.Double oldLow, System.Double oldHigh, System.Double newLow, System.Double newHigh, System.Boolean clamp)`
  - Remap a double value from a one range to another
- `static System.Int32 Remap(System.Int32 value, System.Int32 oldLow, System.Int32 oldHigh, System.Int32 newLow, System.Int32 newHigh)`
  - Remap an integer value from a one range to another
- `static System.Single SphereCameraDistance(System.Single radius, System.Single fieldOfView)`
  - Given a sphere and a field of view, how far from the camera should we be to fully see the sphere?
  - `radius`: The radius of the sphere
  - `fieldOfView`: The field of view in degrees
  - returns: The optimal distance from the center of the sphere
- `static System.Single ExponentialDecay(System.Single current, System.Single target, System.Single halflife, System.Single deltaTime)`
  - Smoothly approach the target value using exponential decay.
Cheaper than SmoothDamp but doesn't track velocity for momentum.
Good for non-physical smoothing.
  - `current`: Current value
  - `target`: Target value to approach
  - `halflife`: Time for the difference to reduce by 50%
  - `deltaTime`: Time step
- `static System.Single SmoothDamp(System.Single current, System.Single target, System.Single velocity, System.Single smoothTime, System.Single deltaTime)`
  - Smoothly move towards the target
- `static System.Single SpringDamp(System.Single current, System.Single target, System.Single velocity, System.Single deltaTime, System.Single frequency, System.Single damping)`
  - Smoothly move towards the target using a spring-like motion
