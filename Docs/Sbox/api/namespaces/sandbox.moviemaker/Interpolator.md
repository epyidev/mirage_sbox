# Sandbox.MovieMaker.Interpolator

Helper for accessing `Sandbox.MovieMaker.IInterpolator`1` implementations,
for interpolating between two values of the same type

- **Kind:** static class
- **Namespace:** `Sandbox.MovieMaker`
- **Assembly:** `Sandbox.Engine`

## Methods

### Static methods

- `static Sandbox.MovieMaker.IInterpolator<T> GetDefault()`
  - Attempts to find a default interpolator for type `T`,
returning `null` if not found.
- `static System.Boolean CanInterpolate(System.Type type)`
  - Attempts to find a default interpolator for the given `type`,
returning `null` if not found.
- `static Sandbox.MovieMaker.IInterpolator<T> GetDefaultOrThrow()`
