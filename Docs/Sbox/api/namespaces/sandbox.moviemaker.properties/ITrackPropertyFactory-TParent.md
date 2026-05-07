# Sandbox.MovieMaker.Properties.ITrackPropertyFactory<TParent>

An `Sandbox.MovieMaker.Properties.ITrackPropertyFactory` that only creates properties nested inside a particular `TParent`
target type.

- **Kind:** interface
- **Namespace:** `Sandbox.MovieMaker.Properties`
- **Assembly:** `Sandbox.Engine`

## Methods

### Instance methods

- `virtual System.Collections.Generic.IEnumerable<System.String> GetPropertyNames(TParent parent)`
- `virtual System.String GetCategoryName(TParent parent, System.String name)`
- `virtual System.Type GetTargetType(TParent parent, System.String name)`
- `virtual Sandbox.MovieMaker.ITrackProperty<T> CreateProperty(TParent parent, System.String name)`
