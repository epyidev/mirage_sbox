# Sandbox.MovieMaker.Properties.ITrackPropertyFactory

Used by `Sandbox.MovieMaker.TrackBinder` to create `Sandbox.MovieMaker.ITrackProperty` instances that allow `Sandbox.MovieMaker.ITrack`s
to modify values in a scene.

- **Kind:** interface
- **Namespace:** `Sandbox.MovieMaker.Properties`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Int32 Order`
  - Used to sort the order that factories are considered when trying to create a property.

## Methods

### Instance methods

- `virtual System.Collections.Generic.IEnumerable<System.String> GetPropertyNames(Sandbox.MovieMaker.ITrackTarget parent)`
  - Lists all available property names provided by this factory from a given `parent`.
- `virtual System.Type GetTargetType(Sandbox.MovieMaker.ITrackTarget parent, System.String name)`
  - Decides if this factory can create a property given a `parent` target and `name`.
Returns any non-`null` type if this factory can create such a property, after which `Sandbox.MovieMaker.Properties.ITrackPropertyFactory.CreateProperty``1(Sandbox.MovieMaker.ITrackTarget,System.String)`
will be called using that type.
- `virtual System.String GetCategoryName(Sandbox.MovieMaker.ITrackTarget parent, System.String name)`
  - When listing properties to add, what category should we use for the given property provided by this factory?
- `virtual Sandbox.MovieMaker.ITrackProperty<T> CreateProperty(Sandbox.MovieMaker.ITrackTarget parent, System.String name)`
  - Create a property with the given `parent`, `name`, and property value type `T`.
The target type was previously returned by `Sandbox.MovieMaker.Properties.ITrackPropertyFactory.GetTargetType(Sandbox.MovieMaker.ITrackTarget,System.String)`, or read from a deserialized track.
