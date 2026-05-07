# Sandbox.MovieMaker.Properties.BindingReference<T>

Used by movie property tracks with `Sandbox.GameObject` or `Sandbox.Component` value
types to reference other tracks. This value will be resolved to whatever the referenced track
is bound to during playback. Needed for properties like `Sandbox.SkinnedModelRenderer.BoneMergeTarget`.

- **Kind:** struct
- **Namespace:** `Sandbox.MovieMaker.Properties`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `BindingReference<T>(System.Nullable<System.Guid> TrackId)`

## Properties

- `System.Nullable<System.Guid> TrackId`
  - Track to look up the binding of during playback.

## Methods

### Instance methods

- `T Get(Sandbox.MovieMaker.TrackBinder binder)`
  - Resolve this binding reference by looking up the current binding for `Sandbox.MovieMaker.Properties.BindingReference`1.TrackId`.
  - `binder`: Binder to look up the current binding in.
- `System.Void Deconstruct(System.Nullable<System.Guid> TrackId)`
