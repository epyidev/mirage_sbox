# Sandbox.MovieMaker.Properties.ITrackPropertyFactory<TParent,TValue>

An `Sandbox.MovieMaker.Properties.ITrackPropertyFactory` that only creates properties nested inside a particular `TParent`
target type, and that always have the same property value type `TValue`.

- **Kind:** interface
- **Namespace:** `Sandbox.MovieMaker.Properties`
- **Assembly:** `Sandbox.Engine`

## Methods

### Instance methods

- `virtual System.Boolean PropertyExists(TParent parent, System.String name)`
- `virtual Sandbox.MovieMaker.ITrackProperty<TValue> CreateProperty(TParent parent, System.String name)`
