# Sandbox.MovieMaker.Properties.BindingReference

Helper methods for working with `Sandbox.MovieMaker.Properties.BindingReference`1`.

- **Kind:** static class
- **Namespace:** `Sandbox.MovieMaker.Properties`
- **Assembly:** `Sandbox.Engine`

## Methods

### Static methods

- `static System.Boolean CanMakeReference(System.Type type)`
  - Can we make a `Sandbox.MovieMaker.IReferenceTrack`1` or `Sandbox.MovieMaker.Properties.BindingReference`1`
of the given `type`? Returns true if `type` is
either `Sandbox.GameObject`, or derived from `Sandbox.Component`.
- `static System.Type GetUnderlyingType(System.Type refType)`
  - If `refType` is a constructed `Sandbox.MovieMaker.Properties.BindingReference`1`,
gets the wrapped type. Otherwise, returns `null`.
