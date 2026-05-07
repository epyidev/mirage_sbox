# Sandbox.Utility.Easing

Easing functions used for transitions. See <a href="https://easings.net/">https://easings.net/</a> for examples.

- **Kind:** static class
- **Namespace:** `Sandbox.Utility`
- **Assembly:** `Sandbox.System`

## Methods

### Static methods

- `static System.Single EaseInOut(System.Single f)`
- `static System.Single EaseIn(System.Single f)`
- `static System.Single EaseOut(System.Single f)`
- `static System.Single Linear(System.Single f)`
  - Linear easing function, x=y.
  - `f`: Input in range of 0 to 1.
  - returns: Output in range 0 to 1.
- `static System.Single QuadraticIn(System.Single f)`
  - Quadratic ease in.
  - `f`: Input in range of 0 to 1.
  - returns: Output in range 0 to 1.
- `static System.Single QuadraticOut(System.Single f)`
  - Quadratic ease out.
  - `f`: Input in range of 0 to 1.
  - returns: Output in range 0 to 1.
- `static System.Single QuadraticInOut(System.Single f)`
  - Quadratic ease in and out.
  - `f`: Input in range of 0 to 1.
  - returns: Output in range 0 to 1.
- `static System.Single ExpoIn(System.Single f)`
  - Exponential ease in.
  - `f`: Input in range of 0 to 1.
  - returns: Output in range 0 to 1.
- `static System.Single ExpoOut(System.Single f)`
  - Exponential ease out.
  - `f`: Input in range of 0 to 1.
  - returns: Output in range 0 to 1.
- `static System.Single ExpoInOut(System.Single f)`
  - Exponential ease in and out.
  - `f`: Input in range of 0 to 1.
  - returns: Output in range 0 to 1.
- `static System.Single BounceIn(System.Single f)`
  - Bouncy ease in.
  - `f`: Input in range of 0 to 1.
  - returns: Output in range 0 to 1.
- `static System.Single BounceOut(System.Single f)`
  - Bouncy ease out.
  - `f`: Input in range of 0 to 1.
  - returns: Output in range 0 to 1.
- `static System.Single BounceInOut(System.Single f)`
  - Bouncy ease in and out.
  - `f`: Input in range of 0 to 1.
  - returns: Output in range 0 to 1.
- `static System.Single SineEaseIn(System.Single f)`
  - Sine ease in.
  - `f`: Input in range of 0 to 1.
  - returns: Output in range 0 to 1.
- `static System.Single SineEaseOut(System.Single f)`
  - Sine ease out.
  - `f`: Input in range of 0 to 1.
  - returns: Output in range 0 to 1.
- `static System.Single SineEaseInOut(System.Single f)`
  - Sine ease in and out.
  - `f`: Input in range of 0 to 1.
  - returns: Output in range 0 to 1.
- `static Sandbox.Utility.Easing.Function GetFunction(System.String name)`
  - Get an easing function by name (ie, "ease-in").
If the function doesn't exist we return QuadraticInOut
- `static System.Boolean TryGetFunction(System.String name, Sandbox.Utility.Easing.Function function)`
  - Get an easing function by name (ie, "ease-in").
If the function exists we return true, otherwise return false.
