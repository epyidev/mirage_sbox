# Sandbox.MovieMaker.ITrackProperty

A target referencing a member property or field of another target.

- **Kind:** interface
- **Namespace:** `Sandbox.MovieMaker`
- **Assembly:** `Sandbox.Engine`

## Properties

- `Sandbox.MovieMaker.ITrackTarget Parent`
  - Target that this member belongs to.
- `System.Boolean CanRead`
  - False if this member is write-only.
- `System.Boolean CanWrite`
  - False if this member is read-only.
- `System.Object Value`
  - If bound, gets or sets the current value of this member.

## Methods

### Instance methods

- `virtual System.Boolean Update(Sandbox.MovieMaker.IPropertyTrack track, Sandbox.MovieMaker.MovieTime time)`
  - If bound and writable, update this property's value from the
given `track` at the given `time`.
