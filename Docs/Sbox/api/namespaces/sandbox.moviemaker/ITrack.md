# Sandbox.MovieMaker.ITrack

Maps to a `Sandbox.MovieMaker.ITrackTarget` in a scene, and describes how it changes over time.

- **Kind:** interface
- **Namespace:** `Sandbox.MovieMaker`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.String Name`
  - Property or object name, used when auto-binding this track in a scene.
- `System.Type TargetType`
  - What type of object or property is this track targeting.
- `Sandbox.MovieMaker.ITrack Parent`
  - Tracks can be nested, which means child tracks can auto-bind to targets in the scene
if their parent is bound.
