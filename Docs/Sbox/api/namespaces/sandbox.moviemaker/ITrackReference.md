# Sandbox.MovieMaker.ITrackReference

A target referencing a `Sandbox.GameObject` or `Sandbox.Component` in the scene.

- **Kind:** interface
- **Namespace:** `Sandbox.MovieMaker`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Guid Id`
  - The `Sandbox.MovieMaker.IReferenceTrack.Id` of the reference track this target was created from.
- `Sandbox.MovieMaker.ITrackReference<Sandbox.GameObject> Parent`
  - Optional game object target that contains this one, if from a nested track.

## Methods

### Instance methods

- `virtual System.Void Bind(Sandbox.IValid value)`
  - Explicitly bind this reference to a particular object in the scene, or null to force it to stay unbound.
- `virtual System.Void Reset()`
  - Clear any explicit binding, so this reference will auto-bind based on its name, type, and parent.
