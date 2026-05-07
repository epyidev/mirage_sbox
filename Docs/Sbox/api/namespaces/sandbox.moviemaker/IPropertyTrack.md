# Sandbox.MovieMaker.IPropertyTrack

Controls an `Sandbox.MovieMaker.ITrackProperty` in the scene. Defines what value that property should have
at each moment of time.

- **Kind:** interface
- **Namespace:** `Sandbox.MovieMaker`
- **Assembly:** `Sandbox.Engine`

## Properties

- `Sandbox.MovieMaker.ITrack Parent`

## Methods

### Instance methods

- `virtual System.Boolean TryGetValue(Sandbox.MovieMaker.MovieTime time, System.Object value)`
  - For a given `time`, does this track want to control its mapped property.
If so, also outputs the desired property value.
